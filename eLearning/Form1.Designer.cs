namespace eLearning
{
    partial class startForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signUp = new System.Windows.Forms.Button();
            this.logIn = new System.Windows.Forms.Button();
            this.forgottenPassword = new System.Windows.Forms.Button();
            this.soundOff = new System.Windows.Forms.PictureBox();
            this.soundOn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.soundOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundOn)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(238, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox2.Location = new System.Drawing.Point(238, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(123, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(128, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // signUp
            // 
            this.signUp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.signUp.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.signUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signUp.Location = new System.Drawing.Point(251, 191);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(89, 35);
            this.signUp.TabIndex = 4;
            this.signUp.Text = "Sign Up";
            this.signUp.UseVisualStyleBackColor = false;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            this.signUp.MouseEnter += new System.EventHandler(this.SignUp_MouseEnter);
            this.signUp.MouseLeave += new System.EventHandler(this.SignUp_MouseLeave);
            // 
            // logIn
            // 
            this.logIn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.logIn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.logIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logIn.Location = new System.Drawing.Point(156, 191);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(89, 35);
            this.logIn.TabIndex = 5;
            this.logIn.Text = "Log In";
            this.logIn.UseVisualStyleBackColor = false;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            this.logIn.MouseEnter += new System.EventHandler(this.login_MouseEnter);
            this.logIn.MouseLeave += new System.EventHandler(this.login_MouseLeave);
            // 
            // forgottenPassword
            // 
            this.forgottenPassword.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.forgottenPassword.Location = new System.Drawing.Point(185, 241);
            this.forgottenPassword.Name = "forgottenPassword";
            this.forgottenPassword.Size = new System.Drawing.Size(118, 25);
            this.forgottenPassword.TabIndex = 6;
            this.forgottenPassword.Text = "Renew my password";
            this.forgottenPassword.UseVisualStyleBackColor = true;
            this.forgottenPassword.Click += new System.EventHandler(this.forgottenPassword_Click);
            // 
            // soundOff
            // 
            this.soundOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soundOff.BackgroundImage")));
            this.soundOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundOff.Image = ((System.Drawing.Image)(resources.GetObject("soundOff.Image")));
            this.soundOff.Location = new System.Drawing.Point(398, 293);
            this.soundOff.Name = "soundOff";
            this.soundOff.Size = new System.Drawing.Size(36, 36);
            this.soundOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soundOff.TabIndex = 7;
            this.soundOff.TabStop = false;
            this.soundOff.Click += new System.EventHandler(this.soundOff_Click);
            // 
            // soundOn
            // 
            this.soundOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soundOn.BackgroundImage")));
            this.soundOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundOn.Image = ((System.Drawing.Image)(resources.GetObject("soundOn.Image")));
            this.soundOn.Location = new System.Drawing.Point(398, 293);
            this.soundOn.Name = "soundOn";
            this.soundOn.Size = new System.Drawing.Size(36, 36);
            this.soundOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soundOn.TabIndex = 8;
            this.soundOn.TabStop = false;
            this.soundOn.Click += new System.EventHandler(this.soundOn_Click_1);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eLearning.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.soundOff);
            this.Controls.Add(this.forgottenPassword);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.soundOn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "startForm";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.soundOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Button forgottenPassword;
        private System.Windows.Forms.PictureBox soundOff;
        private System.Windows.Forms.PictureBox soundOn;
    }
}

