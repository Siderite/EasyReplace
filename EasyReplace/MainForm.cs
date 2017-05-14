#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

#endregion

namespace EasyReplace
{
  /// <summary>
  /// The only form of the application
  /// </summary>
  public partial class MainForm : Form
  {
    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class. 
    /// </summary>
    public MainForm()
    {
      InitializeComponent();
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.Form.Closing"/> event.
    /// </summary>
    /// <param name="e">
    /// A <see cref="T:System.ComponentModel.CancelEventArgs"/> that contains the event data. 
    /// </param>
    protected override void OnClosing(CancelEventArgs e)
    {
      base.OnClosing(e);
      saveHistory();
    }

    private void clearInfoBox()
    {
      tbInfo.Text = string.Empty;
      tbInfo.Refresh();
    }

    private static bool confirm(string message, string caption)
    {
      return
          MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 
                          MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification) ==
          DialogResult.OK;
    }

    private void loadHistory()
    {
      try
      {
        string historyFile = Path.Combine(Application.StartupPath, "history.txt");
        if (File.Exists(historyFile))
        {
          string content = File.ReadAllText(historyFile);
          string[] folders = content.Split('\n');
          foreach (string s in folders)
          {
            string folder = s.Trim();
            if (!string.IsNullOrEmpty(folder))
            {
              folderChooser.FolderList.Add(folder);
            }
          }
        }
      }
      catch (Exception ex)
      {
        writeInfo("Failed loading history: " + ex.Message);
      }
    }

    private void mainForm_Load(object sender, EventArgs e)
    {
      loadHistory();
    }

    private void replaceFiles(IEnumerable<string> files)
    {
      StringBuilder message = new StringBuilder();
      message.AppendLine("Replace all occurences of");
      foreach (string file in files)
      {
        message.AppendLine(" - " + Path.GetFileName(file));
      }
      message.AppendLine("in folder");
      message.Append(folderChooser.FolderName + " ?");
      if (folderChooser.FolderExists && confirm(message.ToString(), "Confirm replace"))
      {
        int successfulCopies = 0;
        int failedCopies = 0;
        clearInfoBox();
        writeInfo("Starting file replace in folder " + folderChooser.FolderName);
        replaceFiles(folderChooser.FolderName, files, ref successfulCopies, ref failedCopies);
        writeStatus("Replaced " + successfulCopies + " files. Failed " + failedCopies + " files.");
        writeInfo("Done.");
      }
    }

    private void replaceFiles(string folderName, IEnumerable<string> files, ref int successfulCopies, 
                              ref int failedCopies)
    {
      DirectoryInfo localFolder = new DirectoryInfo(folderName);
      writeStatus(localFolder.FullName);
      FileInfo[] localFiles = localFolder.GetFiles();
      foreach (FileInfo localFile in localFiles)
      {
        foreach (string file in files)
        {
          if (string.Equals(localFile.Name, Path.GetFileName(file), 
                            StringComparison.CurrentCultureIgnoreCase))
          {
            writeInfo("Replacing " + localFile.FullName);
            if (localFile.FullName.Equals(file, StringComparison.CurrentCultureIgnoreCase))
            {
              writeInfo("Same file.");
            }
            else
            {
              try
              {
                File.Copy(file, localFile.FullName, true);
                writeInfo("Success.");
                successfulCopies++;
              }
              catch (Exception ex)
              {
                writeInfo("Error: " + ex.Message);
                failedCopies++;
              }
            }
          }
        }
      }
      DirectoryInfo[] subFolders = localFolder.GetDirectories();
      foreach (DirectoryInfo subFolder in subFolders)
      {
        replaceFiles(subFolder.FullName, files, ref successfulCopies, ref failedCopies);
      }
    }

    private void saveHistory()
    {
      try
      {
        StringBuilder sb = new StringBuilder();
        foreach (object o in folderChooser.FolderList)
        {
          string folder = o.ToString();
          sb.AppendLine(folder);
        }
        string historyFile = Path.Combine(Application.StartupPath, "history.txt");
        File.WriteAllText(historyFile, sb.ToString());
      }
      catch (Exception ex)
      {
        writeInfo("Failed saving history: " + ex.Message);
      }
    }

    private void tbInfo_DragDrop(object sender, DragEventArgs e)
    {
      string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
      replaceFiles(files);
    }

    private void tbInfo_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
      {
        string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
        bool valid = true;
        foreach (string file in files)
        {
          if (!File.Exists(file))
          {
            valid = false;
            break;
          }
        }
        if (valid)
        {
          e.Effect = DragDropEffects.All;
        }
      }
    }

    private void writeInfo(string s)
    {
      if (!string.IsNullOrEmpty(tbInfo.Text))
      {
        tbInfo.Text += "\r\n";
      }
      tbInfo.Text += s;
      tbInfo.Refresh();
    }

    private void writeStatus(string s)
    {
      toolStripStatusLabel1.Text = s;
      statusStrip1.Refresh();
    }

    #endregion
  }
}