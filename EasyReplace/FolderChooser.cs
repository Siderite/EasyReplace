#region Using directives

using System;
using System.IO;
using System.Windows.Forms;

#endregion

namespace EasyReplace
{
  /// <summary>
  /// User control to choose a folder
  /// </summary>
  public partial class FolderChooser : UserControl
  {
    #region Member data

    private bool mExists;
    private string mFolderName;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="FolderChooser"/> class. 
    /// </summary>
    public FolderChooser()
    {
      InitializeComponent();
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the selected folder name
    /// </summary>
    /// <value>
    /// The folder name.
    /// </value>
    public string FolderName
    {
      get
      {
        return mFolderName;
      }
      set
      {
        setFolderName(value);
      }
    }

    /// <summary>
    /// Gets a value indicating whether the selected folder exists
    /// </summary>
    /// <value>
    /// The folder exists value.
    /// </value>
    public bool FolderExists
    {
      get
      {
        return mExists;
      }
    }

    /// <summary>
    /// Gets a list of folders from which the user can choose
    /// </summary>
    /// <value>
    /// The folder list.
    /// </value>
    public ComboBox.ObjectCollection FolderList
    {
      get
      {
        return cmboFolder.Items;
      }
    }

    #endregion

    #region Private Methods

    private void btnBrowse_Click(object sender, EventArgs e)
    {
      folderBrowserDialog1.SelectedPath = FolderName;
      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        FolderName = folderBrowserDialog1.SelectedPath;
      }
    }

    private void cmboFolder_TextChanged(object sender, EventArgs e)
    {
      FolderName = cmboFolder.Text;
    }

    private void setFolderName(string value)
    {
      if (value == mFolderName)
      {
        return;
      }
      mExists = false;
      errorProvider1.Clear();
      if (!string.IsNullOrEmpty(value))
      {
        string folderName = value;
        if (folderName.LastIndexOfAny("\\/".ToCharArray()) != folderName.Length - 1)
        {
          folderName += "/";
        }
        try
        {
          DirectoryInfo di = new DirectoryInfo(folderName);
          mFolderName = di.FullName;
          if (di.Exists)
          {
            mExists = true;
            if (!cmboFolder.Items.Contains(mFolderName))
            {
              cmboFolder.Items.Insert(0, mFolderName);
            }
          }
          else
          {
            errorProvider1.SetError(cmboFolder, "Folder does not exist");
          }
        }
        catch (Exception ex)
        {
          errorProvider1.SetError(cmboFolder, ex.Message);
        }
      }
      cmboFolder.Text = value;
    }

    #endregion
  }
}