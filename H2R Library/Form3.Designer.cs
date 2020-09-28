namespace H2R_Library
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_std = new System.Windows.Forms.RadioButton();
            this.rad_lib = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameU = new System.Windows.Forms.TextBox();
            this.PasswordConf = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.signup = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdiD = new System.Windows.Forms.TextBox();
            this.Adl = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_std);
            this.groupBox2.Controls.Add(this.rad_lib);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(452, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 132);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Type";
            // 
            // rad_std
            // 
            this.rad_std.AutoSize = true;
            this.rad_std.Location = new System.Drawing.Point(7, 83);
            this.rad_std.Name = "rad_std";
            this.rad_std.Size = new System.Drawing.Size(98, 24);
            this.rad_std.TabIndex = 4;
            this.rad_std.TabStop = true;
            this.rad_std.Text = "Student";
            this.rad_std.UseVisualStyleBackColor = true;
            this.rad_std.CheckedChanged += new System.EventHandler(this.rad_std_CheckedChanged);
            // 
            // rad_lib
            // 
            this.rad_lib.AutoSize = true;
            this.rad_lib.Location = new System.Drawing.Point(7, 44);
            this.rad_lib.Name = "rad_lib";
            this.rad_lib.Size = new System.Drawing.Size(179, 24);
            this.rad_lib.TabIndex = 5;
            this.rad_lib.TabStop = true;
            this.rad_lib.Text = "Librarian Manager";
            this.rad_lib.UseVisualStyleBackColor = true;
            this.rad_lib.CheckedChanged += new System.EventHandler(this.rad_lib_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Adl);
            this.groupBox1.Controls.Add(this.AdiD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NameU);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.PasswordConf);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Controls.Add(this.signup);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(237, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 374);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign Up";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Confirm Password :";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(93, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(93, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(93, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "User Id :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameU
            // 
            this.NameU.Location = new System.Drawing.Point(231, 112);
            this.NameU.Name = "NameU";
            this.NameU.Size = new System.Drawing.Size(147, 25);
            this.NameU.TabIndex = 5;
            // 
            // PasswordConf
            // 
            this.PasswordConf.Location = new System.Drawing.Point(231, 254);
            this.PasswordConf.Name = "PasswordConf";
            this.PasswordConf.PasswordChar = '*';
            this.PasswordConf.Size = new System.Drawing.Size(147, 25);
            this.PasswordConf.TabIndex = 4;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(231, 46);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(147, 25);
            this.Username.TabIndex = 2;
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup.Location = new System.Drawing.Point(491, 216);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(119, 57);
            this.signup.TabIndex = 0;
            this.signup.Text = "Sign Up";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(231, 183);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(147, 25);
            this.Password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(448, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sign - Up";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.HotTrack;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login.Location = new System.Drawing.Point(501, 664);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(119, 57);
            this.login.TabIndex = 12;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(534, 606);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 38);
            this.label6.TabIndex = 13;
            this.label6.Text = "OR";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // AdiD
            // 
            this.AdiD.Location = new System.Drawing.Point(231, 317);
            this.AdiD.Name = "AdiD";
            this.AdiD.Size = new System.Drawing.Size(147, 25);
            this.AdiD.TabIndex = 14;
            // 
            // Adl
            // 
            this.Adl.AutoSize = true;
            this.Adl.Location = new System.Drawing.Point(113, 317);
            this.Adl.Name = "Adl";
            this.Adl.Size = new System.Drawing.Size(90, 20);
            this.Adl.TabIndex = 15;
            this.Adl.Text = "Admin Id :";
            this.Adl.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1059, 756);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form3";
            this.Text = "Sign-up";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_std;
        private System.Windows.Forms.RadioButton rad_lib;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameU;
        private System.Windows.Forms.TextBox PasswordConf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Adl;
        private System.Windows.Forms.TextBox AdiD;
    }
}