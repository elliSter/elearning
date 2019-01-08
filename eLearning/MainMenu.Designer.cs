namespace eLearning
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.logOut = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.soundOff = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.soundOn = new System.Windows.Forms.PictureBox();
            this.credits = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logOut
            // 
            this.logOut.BackgroundImage = global::eLearning.Properties.Resources.back;
            this.logOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.logOut.Image = ((System.Drawing.Image)(resources.GetObject("logOut.Image")));
            this.logOut.Location = new System.Drawing.Point(290, 12);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(26, 25);
            this.logOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logOut.TabIndex = 0;
            this.logOut.TabStop = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(100, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "English -> Ελληνικά";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(100, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ελληνικά -> English";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // soundOff
            // 
            this.soundOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soundOff.BackgroundImage")));
            this.soundOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundOff.Image = ((System.Drawing.Image)(resources.GetObject("soundOff.Image")));
            this.soundOff.Location = new System.Drawing.Point(280, 278);
            this.soundOff.Name = "soundOff";
            this.soundOff.Size = new System.Drawing.Size(36, 36);
            this.soundOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soundOff.TabIndex = 3;
            this.soundOff.TabStop = false;
            this.soundOff.Visible = false;
            this.soundOff.Click += new System.EventHandler(this.soundOff_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(280, 278);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(36, 36);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // soundOn
            // 
            this.soundOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soundOn.BackgroundImage")));
            this.soundOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundOn.Image = ((System.Drawing.Image)(resources.GetObject("soundOn.Image")));
            this.soundOn.Location = new System.Drawing.Point(280, 278);
            this.soundOn.Name = "soundOn";
            this.soundOn.Size = new System.Drawing.Size(36, 36);
            this.soundOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soundOn.TabIndex = 5;
            this.soundOn.TabStop = false;
            this.soundOn.Click += new System.EventHandler(this.soundOn_Click);
            // 
            // credits
            // 
            this.credits.BackColor = System.Drawing.Color.Teal;
            this.credits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.credits.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.credits.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.credits.Location = new System.Drawing.Point(12, 278);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(75, 36);
            this.credits.TabIndex = 6;
            this.credits.Text = "CREDITS";
            this.credits.UseVisualStyleBackColor = false;
            this.credits.Click += new System.EventHandler(this.credits_Click);
            this.credits.MouseEnter += new System.EventHandler(this.credits_MouseEnter);
            this.credits.MouseLeave += new System.EventHandler(this.credits_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::eLearning.Properties.Resources.back;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.Image = global::eLearning.Properties.Resources.VisualEditor___Icon___Help_svg;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.help_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(345, 339);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.soundOff);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.soundOn);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Main Menu - eΛearning";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox soundOff;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox soundOn;
        private System.Windows.Forms.Button credits;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}