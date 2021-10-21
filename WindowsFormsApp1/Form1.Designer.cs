namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label_usernameRegister = new System.Windows.Forms.Label();
            this.textBox_usernameRegister = new System.Windows.Forms.TextBox();
            this.textBox_passwordRegister = new System.Windows.Forms.TextBox();
            this.label_passwordRegister = new System.Windows.Forms.Label();
            this.label_responseRegister = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_passwordLogin = new System.Windows.Forms.Label();
            this.textBox_passwordLogin = new System.Windows.Forms.TextBox();
            this.textBox_usernameLogin = new System.Windows.Forms.TextBox();
            this.label_usernameLogin = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.label_responseLogin = new System.Windows.Forms.Label();
            this.label_nameRegister = new System.Windows.Forms.Label();
            this.textBox_nameRegister = new System.Windows.Forms.TextBox();
            this.label_lastnameRegister = new System.Windows.Forms.Label();
            this.textBox_lastnameRegister = new System.Windows.Forms.TextBox();
            this.label_confirmPasswordRegister = new System.Windows.Forms.Label();
            this.textBox_confirmPasswordRegister = new System.Windows.Forms.TextBox();
            this.label_statusRegister = new System.Windows.Forms.Label();
            this.label_additionalInformationRegister = new System.Windows.Forms.Label();
            this.comboBox_statusRegister = new System.Windows.Forms.ComboBox();
            this.comboBox_courseRegister = new System.Windows.Forms.ComboBox();
            this.button_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_usernameRegister
            // 
            this.label_usernameRegister.AutoSize = true;
            this.label_usernameRegister.Location = new System.Drawing.Point(64, 52);
            this.label_usernameRegister.Name = "label_usernameRegister";
            this.label_usernameRegister.Size = new System.Drawing.Size(55, 13);
            this.label_usernameRegister.TabIndex = 0;
            this.label_usernameRegister.Text = "Username";
            // 
            // textBox_usernameRegister
            // 
            this.textBox_usernameRegister.Location = new System.Drawing.Point(128, 49);
            this.textBox_usernameRegister.Name = "textBox_usernameRegister";
            this.textBox_usernameRegister.Size = new System.Drawing.Size(100, 20);
            this.textBox_usernameRegister.TabIndex = 1;
            // 
            // textBox_passwordRegister
            // 
            this.textBox_passwordRegister.Location = new System.Drawing.Point(128, 171);
            this.textBox_passwordRegister.Name = "textBox_passwordRegister";
            this.textBox_passwordRegister.Size = new System.Drawing.Size(100, 20);
            this.textBox_passwordRegister.TabIndex = 2;
            // 
            // label_passwordRegister
            // 
            this.label_passwordRegister.AutoSize = true;
            this.label_passwordRegister.Location = new System.Drawing.Point(64, 174);
            this.label_passwordRegister.Name = "label_passwordRegister";
            this.label_passwordRegister.Size = new System.Drawing.Size(53, 13);
            this.label_passwordRegister.TabIndex = 3;
            this.label_passwordRegister.Text = "Password";
            // 
            // label_responseRegister
            // 
            this.label_responseRegister.AutoSize = true;
            this.label_responseRegister.ForeColor = System.Drawing.Color.Black;
            this.label_responseRegister.Location = new System.Drawing.Point(92, 317);
            this.label_responseRegister.Name = "label_responseRegister";
            this.label_responseRegister.Size = new System.Drawing.Size(58, 13);
            this.label_responseRegister.TabIndex = 5;
            this.label_responseRegister.Text = "Response:";
            this.label_responseRegister.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Registration";
            // 
            // label_passwordLogin
            // 
            this.label_passwordLogin.AutoSize = true;
            this.label_passwordLogin.Location = new System.Drawing.Point(289, 89);
            this.label_passwordLogin.Name = "label_passwordLogin";
            this.label_passwordLogin.Size = new System.Drawing.Size(53, 13);
            this.label_passwordLogin.TabIndex = 10;
            this.label_passwordLogin.Text = "Password";
            // 
            // textBox_passwordLogin
            // 
            this.textBox_passwordLogin.Location = new System.Drawing.Point(353, 86);
            this.textBox_passwordLogin.Name = "textBox_passwordLogin";
            this.textBox_passwordLogin.Size = new System.Drawing.Size(100, 20);
            this.textBox_passwordLogin.TabIndex = 9;
            // 
            // textBox_usernameLogin
            // 
            this.textBox_usernameLogin.Location = new System.Drawing.Point(353, 49);
            this.textBox_usernameLogin.Name = "textBox_usernameLogin";
            this.textBox_usernameLogin.Size = new System.Drawing.Size(100, 20);
            this.textBox_usernameLogin.TabIndex = 8;
            // 
            // label_usernameLogin
            // 
            this.label_usernameLogin.AutoSize = true;
            this.label_usernameLogin.Location = new System.Drawing.Point(289, 52);
            this.label_usernameLogin.Name = "label_usernameLogin";
            this.label_usernameLogin.Size = new System.Drawing.Size(58, 13);
            this.label_usernameLogin.TabIndex = 7;
            this.label_usernameLogin.Text = "Username:";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(386, 22);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(37, 13);
            this.label_login.TabIndex = 13;
            this.label_login.Text = "Log In";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(365, 122);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 14;
            this.button_login.Text = "Log In";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_responseLogin
            // 
            this.label_responseLogin.AutoSize = true;
            this.label_responseLogin.Location = new System.Drawing.Point(301, 152);
            this.label_responseLogin.Name = "label_responseLogin";
            this.label_responseLogin.Size = new System.Drawing.Size(53, 13);
            this.label_responseLogin.TabIndex = 15;
            this.label_responseLogin.Text = "response:";
            // 
            // label_nameRegister
            // 
            this.label_nameRegister.AutoSize = true;
            this.label_nameRegister.Location = new System.Drawing.Point(73, 89);
            this.label_nameRegister.Name = "label_nameRegister";
            this.label_nameRegister.Size = new System.Drawing.Size(33, 13);
            this.label_nameRegister.TabIndex = 16;
            this.label_nameRegister.Text = "name";
            // 
            // textBox_nameRegister
            // 
            this.textBox_nameRegister.Location = new System.Drawing.Point(128, 89);
            this.textBox_nameRegister.Name = "textBox_nameRegister";
            this.textBox_nameRegister.Size = new System.Drawing.Size(100, 20);
            this.textBox_nameRegister.TabIndex = 17;
            // 
            // label_lastnameRegister
            // 
            this.label_lastnameRegister.AutoSize = true;
            this.label_lastnameRegister.Location = new System.Drawing.Point(58, 127);
            this.label_lastnameRegister.Name = "label_lastnameRegister";
            this.label_lastnameRegister.Size = new System.Drawing.Size(61, 13);
            this.label_lastnameRegister.TabIndex = 18;
            this.label_lastnameRegister.Text = "Last Name:";
            // 
            // textBox_lastnameRegister
            // 
            this.textBox_lastnameRegister.Location = new System.Drawing.Point(128, 124);
            this.textBox_lastnameRegister.Name = "textBox_lastnameRegister";
            this.textBox_lastnameRegister.Size = new System.Drawing.Size(100, 20);
            this.textBox_lastnameRegister.TabIndex = 19;
            // 
            // label_confirmPasswordRegister
            // 
            this.label_confirmPasswordRegister.AutoSize = true;
            this.label_confirmPasswordRegister.Location = new System.Drawing.Point(12, 206);
            this.label_confirmPasswordRegister.Name = "label_confirmPasswordRegister";
            this.label_confirmPasswordRegister.Size = new System.Drawing.Size(94, 13);
            this.label_confirmPasswordRegister.TabIndex = 20;
            this.label_confirmPasswordRegister.Text = "Confirm Password:";
            // 
            // textBox_confirmPasswordRegister
            // 
            this.textBox_confirmPasswordRegister.Location = new System.Drawing.Point(128, 206);
            this.textBox_confirmPasswordRegister.Name = "textBox_confirmPasswordRegister";
            this.textBox_confirmPasswordRegister.Size = new System.Drawing.Size(100, 20);
            this.textBox_confirmPasswordRegister.TabIndex = 21;
            // 
            // label_statusRegister
            // 
            this.label_statusRegister.AutoSize = true;
            this.label_statusRegister.Location = new System.Drawing.Point(25, 248);
            this.label_statusRegister.Name = "label_statusRegister";
            this.label_statusRegister.Size = new System.Drawing.Size(40, 13);
            this.label_statusRegister.TabIndex = 22;
            this.label_statusRegister.Text = "Status:";
            // 
            // label_additionalInformationRegister
            // 
            this.label_additionalInformationRegister.AutoSize = true;
            this.label_additionalInformationRegister.Location = new System.Drawing.Point(248, 248);
            this.label_additionalInformationRegister.Name = "label_additionalInformationRegister";
            this.label_additionalInformationRegister.Size = new System.Drawing.Size(43, 13);
            this.label_additionalInformationRegister.TabIndex = 23;
            this.label_additionalInformationRegister.Text = "Course:";
            // 
            // comboBox_statusRegister
            // 
            this.comboBox_statusRegister.FormattingEnabled = true;
            this.comboBox_statusRegister.Location = new System.Drawing.Point(86, 245);
            this.comboBox_statusRegister.Name = "comboBox_statusRegister";
            this.comboBox_statusRegister.Size = new System.Drawing.Size(121, 21);
            this.comboBox_statusRegister.TabIndex = 24;
            // 
            // comboBox_courseRegister
            // 
            this.comboBox_courseRegister.FormattingEnabled = true;
            this.comboBox_courseRegister.Location = new System.Drawing.Point(302, 245);
            this.comboBox_courseRegister.Name = "comboBox_courseRegister";
            this.comboBox_courseRegister.Size = new System.Drawing.Size(121, 21);
            this.comboBox_courseRegister.TabIndex = 25;
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(132, 272);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(75, 23);
            this.button_register.TabIndex = 27;
            this.button_register.Text = "register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.comboBox_courseRegister);
            this.Controls.Add(this.comboBox_statusRegister);
            this.Controls.Add(this.label_additionalInformationRegister);
            this.Controls.Add(this.label_statusRegister);
            this.Controls.Add(this.textBox_confirmPasswordRegister);
            this.Controls.Add(this.label_confirmPasswordRegister);
            this.Controls.Add(this.textBox_lastnameRegister);
            this.Controls.Add(this.label_lastnameRegister);
            this.Controls.Add(this.textBox_nameRegister);
            this.Controls.Add(this.label_nameRegister);
            this.Controls.Add(this.label_responseLogin);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_passwordLogin);
            this.Controls.Add(this.textBox_passwordLogin);
            this.Controls.Add(this.textBox_usernameLogin);
            this.Controls.Add(this.label_usernameLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_responseRegister);
            this.Controls.Add(this.label_passwordRegister);
            this.Controls.Add(this.textBox_passwordRegister);
            this.Controls.Add(this.textBox_usernameRegister);
            this.Controls.Add(this.label_usernameRegister);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_usernameRegister;
        private System.Windows.Forms.TextBox textBox_usernameRegister;
        private System.Windows.Forms.TextBox textBox_passwordRegister;
        private System.Windows.Forms.Label label_passwordRegister;
        private System.Windows.Forms.Label label_responseRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_passwordLogin;
        private System.Windows.Forms.TextBox textBox_passwordLogin;
        private System.Windows.Forms.TextBox textBox_usernameLogin;
        private System.Windows.Forms.Label label_usernameLogin;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_responseLogin;
        private System.Windows.Forms.Label label_nameRegister;
        private System.Windows.Forms.TextBox textBox_nameRegister;
        private System.Windows.Forms.Label label_lastnameRegister;
        private System.Windows.Forms.TextBox textBox_lastnameRegister;
        private System.Windows.Forms.Label label_confirmPasswordRegister;
        private System.Windows.Forms.TextBox textBox_confirmPasswordRegister;
        private System.Windows.Forms.Label label_statusRegister;
        private System.Windows.Forms.Label label_additionalInformationRegister;
        private System.Windows.Forms.ComboBox comboBox_statusRegister;
        private System.Windows.Forms.ComboBox comboBox_courseRegister;
        private System.Windows.Forms.Button button_register;
    }
}

