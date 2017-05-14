namespace EasyReplace
{
  partial class MainForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tbInfo = new System.Windows.Forms.TextBox();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.folderChooser = new EasyReplace.FolderChooser();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbInfo
      // 
      this.tbInfo.AllowDrop = true;
      this.tbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.tbInfo.Location = new System.Drawing.Point(12, 47);
      this.tbInfo.Multiline = true;
      this.tbInfo.Name = "tbInfo";
      this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbInfo.Size = new System.Drawing.Size(603, 237);
      this.tbInfo.TabIndex = 1;
      this.tbInfo.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbInfo_DragDrop);
      this.tbInfo.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbInfo_DragEnter);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
      this.statusStrip1.Location = new System.Drawing.Point(0, 287);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(627, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // folderChooser
      // 
      this.folderChooser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.folderChooser.AutoSize = true;
      this.folderChooser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.folderChooser.FolderName = null;
      this.folderChooser.Location = new System.Drawing.Point(12, 12);
      this.folderChooser.Name = "folderChooser";
      this.folderChooser.Size = new System.Drawing.Size(607, 29);
      this.folderChooser.TabIndex = 0;
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 17);
      this.toolStripStatusLabel1.Text = "by Siderite";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(627, 309);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.tbInfo);
      this.Controls.Add(this.folderChooser);
      this.Name = "MainForm";
      this.Text = "Easy Replace 1.0";
      this.Load += new System.EventHandler(this.mainForm_Load);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private FolderChooser folderChooser;
    private System.Windows.Forms.TextBox tbInfo;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
  }
}