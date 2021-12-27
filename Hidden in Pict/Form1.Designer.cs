namespace Hidden_in_Pict
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bProcess = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.opImage = new System.Windows.Forms.OpenFileDialog();
            this.bBrowseImage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbFileImage = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tbFileArchive = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bBrowseArchive = new Bunifu.Framework.UI.BunifuFlatButton();
            this.opArchive = new System.Windows.Forms.OpenFileDialog();
            this.sMid = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbImage = new System.Windows.Forms.Label();
            this.lbArchive = new System.Windows.Forms.Label();
            this.cbCMD = new System.Windows.Forms.CheckBox();
            this.bHelp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pCMD = new System.Diagnostics.Process();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bProcess
            // 
            this.bProcess.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProcess.BorderRadius = 0;
            this.bProcess.ButtonText = "Process";
            this.bProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bProcess.DisabledColor = System.Drawing.Color.Gray;
            this.bProcess.Iconcolor = System.Drawing.Color.Transparent;
            this.bProcess.Iconimage = null;
            this.bProcess.Iconimage_right = null;
            this.bProcess.Iconimage_right_Selected = null;
            this.bProcess.Iconimage_Selected = null;
            this.bProcess.IconMarginLeft = 0;
            this.bProcess.IconMarginRight = 0;
            this.bProcess.IconRightVisible = true;
            this.bProcess.IconRightZoom = 0D;
            this.bProcess.IconVisible = true;
            this.bProcess.IconZoom = 90D;
            this.bProcess.IsTab = false;
            this.bProcess.Location = new System.Drawing.Point(104, 345);
            this.bProcess.Name = "bProcess";
            this.bProcess.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bProcess.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bProcess.OnHoverTextColor = System.Drawing.Color.White;
            this.bProcess.selected = false;
            this.bProcess.Size = new System.Drawing.Size(66, 48);
            this.bProcess.TabIndex = 6;
            this.bProcess.Text = "Process";
            this.bProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bProcess.Textcolor = System.Drawing.Color.White;
            this.bProcess.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProcess.Click += new System.EventHandler(this.BProcess_Click);
            // 
            // bClose
            // 
            this.bClose.Activecolor = System.Drawing.Color.DarkRed;
            this.bClose.BackColor = System.Drawing.Color.DarkRed;
            this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bClose.BorderRadius = 0;
            this.bClose.ButtonText = "Close";
            this.bClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bClose.DisabledColor = System.Drawing.Color.Gray;
            this.bClose.Iconcolor = System.Drawing.Color.Transparent;
            this.bClose.Iconimage = null;
            this.bClose.Iconimage_right = null;
            this.bClose.Iconimage_right_Selected = null;
            this.bClose.Iconimage_Selected = null;
            this.bClose.IconMarginLeft = 0;
            this.bClose.IconMarginRight = 0;
            this.bClose.IconRightVisible = true;
            this.bClose.IconRightZoom = 0D;
            this.bClose.IconVisible = true;
            this.bClose.IconZoom = 90D;
            this.bClose.IsTab = false;
            this.bClose.Location = new System.Drawing.Point(187, 345);
            this.bClose.Name = "bClose";
            this.bClose.Normalcolor = System.Drawing.Color.DarkRed;
            this.bClose.OnHovercolor = System.Drawing.Color.Maroon;
            this.bClose.OnHoverTextColor = System.Drawing.Color.White;
            this.bClose.selected = false;
            this.bClose.Size = new System.Drawing.Size(66, 48);
            this.bClose.TabIndex = 7;
            this.bClose.Text = "Close";
            this.bClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bClose.Textcolor = System.Drawing.Color.White;
            this.bClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // opImage
            // 
            this.opImage.Filter = "Images (*.JPG;*.JPEG;*.PNG)|*.JPG;*.JPEG;*.PNG";
            this.opImage.InitialDirectory = "D:\\";
            this.opImage.RestoreDirectory = true;
            this.opImage.Title = "Browse the Image file";
            // 
            // bBrowseImage
            // 
            this.bBrowseImage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.bBrowseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.bBrowseImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBrowseImage.BorderRadius = 0;
            this.bBrowseImage.ButtonText = "Browse";
            this.bBrowseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBrowseImage.DisabledColor = System.Drawing.Color.Gray;
            this.bBrowseImage.Iconcolor = System.Drawing.Color.Transparent;
            this.bBrowseImage.Iconimage = null;
            this.bBrowseImage.Iconimage_right = null;
            this.bBrowseImage.Iconimage_right_Selected = null;
            this.bBrowseImage.Iconimage_Selected = null;
            this.bBrowseImage.IconMarginLeft = 0;
            this.bBrowseImage.IconMarginRight = 0;
            this.bBrowseImage.IconRightVisible = true;
            this.bBrowseImage.IconRightZoom = 0D;
            this.bBrowseImage.IconVisible = true;
            this.bBrowseImage.IconZoom = 90D;
            this.bBrowseImage.IsTab = false;
            this.bBrowseImage.Location = new System.Drawing.Point(141, 112);
            this.bBrowseImage.Name = "bBrowseImage";
            this.bBrowseImage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.bBrowseImage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.bBrowseImage.OnHoverTextColor = System.Drawing.Color.White;
            this.bBrowseImage.selected = false;
            this.bBrowseImage.Size = new System.Drawing.Size(75, 23);
            this.bBrowseImage.TabIndex = 2;
            this.bBrowseImage.Text = "Browse";
            this.bBrowseImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bBrowseImage.Textcolor = System.Drawing.Color.White;
            this.bBrowseImage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBrowseImage.Click += new System.EventHandler(this.BBrowse_Click);
            // 
            // tbFileImage
            // 
            this.tbFileImage.AllowDrop = true;
            this.tbFileImage.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbFileImage.Location = new System.Drawing.Point(13, 46);
            this.tbFileImage.Multiline = true;
            this.tbFileImage.Name = "tbFileImage";
            this.tbFileImage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFileImage.Size = new System.Drawing.Size(330, 51);
            this.tbFileImage.TabIndex = 1;
            // 
            // tbFileArchive
            // 
            this.tbFileArchive.AllowDrop = true;
            this.tbFileArchive.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbFileArchive.Location = new System.Drawing.Point(13, 201);
            this.tbFileArchive.Multiline = true;
            this.tbFileArchive.Name = "tbFileArchive";
            this.tbFileArchive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFileArchive.Size = new System.Drawing.Size(330, 51);
            this.tbFileArchive.TabIndex = 3;
            // 
            // bBrowseArchive
            // 
            this.bBrowseArchive.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.bBrowseArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.bBrowseArchive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBrowseArchive.BorderRadius = 0;
            this.bBrowseArchive.ButtonText = "Browse";
            this.bBrowseArchive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBrowseArchive.DisabledColor = System.Drawing.Color.Gray;
            this.bBrowseArchive.Iconcolor = System.Drawing.Color.Transparent;
            this.bBrowseArchive.Iconimage = null;
            this.bBrowseArchive.Iconimage_right = null;
            this.bBrowseArchive.Iconimage_right_Selected = null;
            this.bBrowseArchive.Iconimage_Selected = null;
            this.bBrowseArchive.IconMarginLeft = 0;
            this.bBrowseArchive.IconMarginRight = 0;
            this.bBrowseArchive.IconRightVisible = true;
            this.bBrowseArchive.IconRightZoom = 0D;
            this.bBrowseArchive.IconVisible = true;
            this.bBrowseArchive.IconZoom = 90D;
            this.bBrowseArchive.IsTab = false;
            this.bBrowseArchive.Location = new System.Drawing.Point(141, 267);
            this.bBrowseArchive.Name = "bBrowseArchive";
            this.bBrowseArchive.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.bBrowseArchive.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.bBrowseArchive.OnHoverTextColor = System.Drawing.Color.White;
            this.bBrowseArchive.selected = false;
            this.bBrowseArchive.Size = new System.Drawing.Size(75, 23);
            this.bBrowseArchive.TabIndex = 4;
            this.bBrowseArchive.Text = "Browse";
            this.bBrowseArchive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bBrowseArchive.Textcolor = System.Drawing.Color.White;
            this.bBrowseArchive.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBrowseArchive.Click += new System.EventHandler(this.BBrowseArchive_Click);
            // 
            // opArchive
            // 
            this.opArchive.Filter = "Archive (*.RAR)|*.RAR";
            this.opArchive.InitialDirectory = "D:\\";
            this.opArchive.RestoreDirectory = true;
            this.opArchive.Title = "Browse the Archive file";
            // 
            // sMid
            // 
            this.sMid.BackColor = System.Drawing.Color.Transparent;
            this.sMid.CausesValidation = false;
            this.sMid.Enabled = false;
            this.sMid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.sMid.LineThickness = 1;
            this.sMid.Location = new System.Drawing.Point(-4, 135);
            this.sMid.Name = "sMid";
            this.sMid.Size = new System.Drawing.Size(364, 35);
            this.sMid.TabIndex = 0;
            this.sMid.TabStop = false;
            this.sMid.Transparency = 255;
            this.sMid.Vertical = false;
            // 
            // lbImage
            // 
            this.lbImage.AutoSize = true;
            this.lbImage.CausesValidation = false;
            this.lbImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImage.Location = new System.Drawing.Point(20, 9);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(65, 13);
            this.lbImage.TabIndex = 0;
            this.lbImage.Text = "Image File";
            // 
            // lbArchive
            // 
            this.lbArchive.AutoSize = true;
            this.lbArchive.CausesValidation = false;
            this.lbArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArchive.Location = new System.Drawing.Point(20, 173);
            this.lbArchive.Name = "lbArchive";
            this.lbArchive.Size = new System.Drawing.Size(74, 13);
            this.lbArchive.TabIndex = 0;
            this.lbArchive.Text = "Archive File";
            // 
            // cbCMD
            // 
            this.cbCMD.Location = new System.Drawing.Point(142, 307);
            this.cbCMD.Name = "cbCMD";
            this.cbCMD.Size = new System.Drawing.Size(72, 17);
            this.cbCMD.TabIndex = 5;
            this.cbCMD.Text = "Use CMD";
            this.cbCMD.UseVisualStyleBackColor = true;
            // 
            // bHelp
            // 
            this.bHelp.ActiveBorderThickness = 1;
            this.bHelp.ActiveCornerRadius = 20;
            this.bHelp.ActiveFillColor = System.Drawing.Color.Teal;
            this.bHelp.ActiveForecolor = System.Drawing.Color.White;
            this.bHelp.ActiveLineColor = System.Drawing.Color.Teal;
            this.bHelp.BackColor = System.Drawing.SystemColors.Control;
            this.bHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bHelp.BackgroundImage")));
            this.bHelp.ButtonText = "Help";
            this.bHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bHelp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHelp.ForeColor = System.Drawing.Color.Teal;
            this.bHelp.IdleBorderThickness = 1;
            this.bHelp.IdleCornerRadius = 20;
            this.bHelp.IdleFillColor = System.Drawing.Color.White;
            this.bHelp.IdleForecolor = System.Drawing.Color.Teal;
            this.bHelp.IdleLineColor = System.Drawing.Color.Teal;
            this.bHelp.Location = new System.Drawing.Point(290, 1);
            this.bHelp.Margin = new System.Windows.Forms.Padding(5);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(52, 37);
            this.bHelp.TabIndex = 8;
            this.bHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bHelp.Click += new System.EventHandler(this.BHelp_Click);
            // 
            // pCMD
            // 
            this.pCMD.StartInfo.Domain = "";
            this.pCMD.StartInfo.FileName = "cmd";
            this.pCMD.StartInfo.LoadUserProfile = false;
            this.pCMD.StartInfo.Password = null;
            this.pCMD.StartInfo.StandardErrorEncoding = null;
            this.pCMD.StartInfo.StandardOutputEncoding = null;
            this.pCMD.StartInfo.UserName = "";
            this.pCMD.StartInfo.UseShellExecute = false;
            this.pCMD.SynchronizingObject = this;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 422);
            this.Controls.Add(this.lbArchive);
            this.Controls.Add(this.lbImage);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.cbCMD);
            this.Controls.Add(this.sMid);
            this.Controls.Add(this.tbFileArchive);
            this.Controls.Add(this.bBrowseArchive);
            this.Controls.Add(this.tbFileImage);
            this.Controls.Add(this.bBrowseImage);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton bProcess;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.OpenFileDialog opImage;
        private Bunifu.Framework.UI.BunifuFlatButton bBrowseImage;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbFileImage;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbFileArchive;
        private Bunifu.Framework.UI.BunifuFlatButton bBrowseArchive;
        private System.Windows.Forms.OpenFileDialog opArchive;
        private Bunifu.Framework.UI.BunifuSeparator sMid;
        private System.Windows.Forms.Label lbImage;
        private System.Windows.Forms.Label lbArchive;
        private System.Windows.Forms.CheckBox cbCMD;
        private Bunifu.Framework.UI.BunifuFlatButton bClose;
        private Bunifu.Framework.UI.BunifuThinButton2 bHelp;
        private System.Diagnostics.Process pCMD;
    }
}

