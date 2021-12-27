namespace Hidden_in_Pict
{
    partial class fHelp
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pBG = new System.Windows.Forms.Panel();
            this.bClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pBG;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pBG
            // 
            this.pBG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBG.BackColor = System.Drawing.Color.White;
            this.pBG.CausesValidation = false;
            this.pBG.Controls.Add(this.bClose);
            this.pBG.Controls.Add(this.label9);
            this.pBG.Controls.Add(this.label8);
            this.pBG.Controls.Add(this.label7);
            this.pBG.Controls.Add(this.label6);
            this.pBG.Controls.Add(this.label5);
            this.pBG.Controls.Add(this.label4);
            this.pBG.Controls.Add(this.label3);
            this.pBG.Controls.Add(this.label2);
            this.pBG.Controls.Add(this.label1);
            this.pBG.Location = new System.Drawing.Point(3, 3);
            this.pBG.Margin = new System.Windows.Forms.Padding(0);
            this.pBG.Name = "pBG";
            this.pBG.Size = new System.Drawing.Size(350, 416);
            this.pBG.TabIndex = 10;
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
            this.bClose.Location = new System.Drawing.Point(142, 322);
            this.bClose.Name = "bClose";
            this.bClose.Normalcolor = System.Drawing.Color.DarkRed;
            this.bClose.OnHovercolor = System.Drawing.Color.Maroon;
            this.bClose.OnHoverTextColor = System.Drawing.Color.White;
            this.bClose.selected = false;
            this.bClose.Size = new System.Drawing.Size(66, 48);
            this.bClose.TabIndex = 8;
            this.bClose.Text = "Close";
            this.bClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bClose.Textcolor = System.Drawing.Color.White;
            this.bClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.CausesValidation = false;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "JUST OPEN THE PICTURE WITH WinRAR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(328, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "TO VIEW HIDDEN ARCHIVE INSIDE THE PICTURE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.CausesValidation = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "*You can add password in rar file manually with WinRAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Location = new System.Drawing.Point(62, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "- Detect and open hidden archive inside picture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.CausesValidation = false;
            this.label5.Location = new System.Drawing.Point(62, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "- Hide archive inside picture";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Location = new System.Drawing.Point(45, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "This program contains following features:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Location = new System.Drawing.Point(62, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hide archive file inside the picture file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Location = new System.Drawing.Point(45, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hidden in Pict";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.CausesValidation = false;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Help";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 7;
            this.bunifuElipse2.TargetControl = this.pBG;
            // 
            // fHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(356, 422);
            this.Controls.Add(this.pBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fHelp";
            this.ShowInTaskbar = false;
            this.Text = "Form2";
            this.pBG.ResumeLayout(false);
            this.pBG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton bClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pBG;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}