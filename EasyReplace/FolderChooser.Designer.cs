namespace EasyReplace
{
  partial class FolderChooser
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.cmboFolder = new System.Windows.Forms.ComboBox();
      this.btnBrowse = new System.Windows.Forms.Button();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // cmboFolder
      // 
      this.cmboFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.cmboFolder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.cmboFolder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
      this.cmboFolder.FormattingEnabled = true;
      this.cmboFolder.Location = new System.Drawing.Point(3, 3);
      this.cmboFolder.Name = "cmboFolder";
      this.cmboFolder.Size = new System.Drawing.Size(446, 21);
      this.cmboFolder.TabIndex = 0;
      this.cmboFolder.TextChanged += new System.EventHandler(this.cmboFolder_TextChanged);
      // 
      // btnBrowse
      // 
      this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnBrowse.AutoSize = true;
      this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnBrowse.Location = new System.Drawing.Point(455, 3);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(26, 23);
      this.btnBrowse.TabIndex = 1;
      this.btnBrowse.Text = "...";
      this.btnBrowse.UseVisualStyleBackColor = true;
      this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
      // 
      // folderBrowserDialog1
      // 
      this.folderBrowserDialog1.ShowNewFolderButton = false;
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // FolderChooser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.Controls.Add(this.btnBrowse);
      this.Controls.Add(this.cmboFolder);
      this.Name = "FolderChooser";
      this.Size = new System.Drawing.Size(484, 29);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmboFolder;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.ErrorProvider errorProvider1;
  }
}
