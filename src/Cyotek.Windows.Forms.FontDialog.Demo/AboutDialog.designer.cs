namespace Cyotek.Windows.Forms.Demo
{
  partial class AboutDialog
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
      this.components = new System.ComponentModel.Container();
      this.closeButton = new System.Windows.Forms.Button();
      this.nameLabel = new System.Windows.Forms.Label();
      this.versionLabel = new System.Windows.Forms.Label();
      this.copyrightLabel = new System.Windows.Forms.Label();
      this.iconPictureBox = new System.Windows.Forms.PictureBox();
      this.footerGroupBox = new System.Windows.Forms.Panel();
      this.webLinkLabel = new System.Windows.Forms.LinkLabel();
      this.TabControl = new System.Windows.Forms.TabControl();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
      this.footerGroupBox.SuspendLayout();
      this.SuspendLayout();
      //
      // closeButton
      //
      this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.closeButton.Location = new System.Drawing.Point(528, 12);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(75, 23);
      this.closeButton.TabIndex = 1;
      this.closeButton.Text = "Close";
      this.closeButton.UseVisualStyleBackColor = true;
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      //
      // nameLabel
      //
      this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.nameLabel.AutoSize = true;
      this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nameLabel.Location = new System.Drawing.Point(50, 12);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(38, 13);
      this.nameLabel.TabIndex = 0;
      this.nameLabel.Text = "Name";
      //
      // versionLabel
      //
      this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.versionLabel.AutoSize = true;
      this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.versionLabel.Location = new System.Drawing.Point(50, 25);
      this.versionLabel.Name = "versionLabel";
      this.versionLabel.Size = new System.Drawing.Size(45, 13);
      this.versionLabel.TabIndex = 1;
      this.versionLabel.Text = "Version";
      //
      // copyrightLabel
      //
      this.copyrightLabel.AutoSize = true;
      this.copyrightLabel.Location = new System.Drawing.Point(53, 47);
      this.copyrightLabel.Name = "copyrightLabel";
      this.copyrightLabel.Size = new System.Drawing.Size(58, 15);
      this.copyrightLabel.TabIndex = 2;
      this.copyrightLabel.Text = "copyright";
      //
      // iconPictureBox
      //
      this.iconPictureBox.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.Icon;
      this.iconPictureBox.Location = new System.Drawing.Point(12, 12);
      this.iconPictureBox.Name = "iconPictureBox";
      this.iconPictureBox.Size = new System.Drawing.Size(32, 32);
      this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.iconPictureBox.TabIndex = 4;
      this.iconPictureBox.TabStop = false;
      //
      // footerGroupBox
      //
      this.footerGroupBox.BackColor = System.Drawing.SystemColors.Control;
      this.footerGroupBox.Controls.Add(this.webLinkLabel);
      this.footerGroupBox.Controls.Add(this.closeButton);
      this.footerGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.footerGroupBox.Location = new System.Drawing.Point(0, 448);
      this.footerGroupBox.Name = "footerGroupBox";
      this.footerGroupBox.Size = new System.Drawing.Size(615, 47);
      this.footerGroupBox.TabIndex = 4;
      this.footerGroupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.footerGroupBox_Paint);
      //
      // webLinkLabel
      //
      this.webLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.webLinkLabel.AutoSize = true;
      this.webLinkLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.webLinkLabel.Location = new System.Drawing.Point(12, 16);
      this.webLinkLabel.Name = "webLinkLabel";
      this.webLinkLabel.Size = new System.Drawing.Size(99, 15);
      this.webLinkLabel.TabIndex = 0;
      this.webLinkLabel.TabStop = true;
      this.webLinkLabel.Tag = "www.cyotek.com";
      this.webLinkLabel.Text = "www.cyotek.com";
      this.toolTip.SetToolTip(this.webLinkLabel, "Visit the Cyotek website for development topics and code");
      this.webLinkLabel.Click += new System.EventHandler(this.webLinkLabel_Click);
      //
      // docsTabControl
      //
      this.TabControl.Location = new System.Drawing.Point(12, 77);
      this.TabControl.Name = "TabControl";
      this.TabControl.SelectedIndex = 0;
      this.TabControl.Size = new System.Drawing.Size(591, 365);
      this.TabControl.TabIndex = 3;
      this.TabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.docsTabControl_Selecting);
      //
      // AboutDialog
      //
      this.AcceptButton = this.closeButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.BackColor = System.Drawing.SystemColors.Window;
      this.CancelButton = this.closeButton;
      this.ClientSize = new System.Drawing.Size(615, 495);
      this.Controls.Add(this.TabControl);
      this.Controls.Add(this.footerGroupBox);
      this.Controls.Add(this.iconPictureBox);
      this.Controls.Add(this.copyrightLabel);
      this.Controls.Add(this.versionLabel);
      this.Controls.Add(this.nameLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "AboutDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "About";
      ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
      this.footerGroupBox.ResumeLayout(false);
      this.footerGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.Label versionLabel;
    private System.Windows.Forms.Label copyrightLabel;
    private System.Windows.Forms.PictureBox iconPictureBox;
    private System.Windows.Forms.Panel footerGroupBox;
    private System.Windows.Forms.LinkLabel webLinkLabel;

    private System.Windows.Forms.ToolTip toolTip;
  }
}
