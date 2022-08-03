namespace PharmacyManagementSystem.Presentation_Layer
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LogingroupBox = new System.Windows.Forms.GroupBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.Label();
            this.loginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.registrationLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LogingroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogingroupBox
            // 
            this.LogingroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.LogingroupBox.Controls.Add(this.loginButton);
            this.LogingroupBox.Controls.Add(this.loginPasswordTextBox);
            this.LogingroupBox.Controls.Add(this.passwordTextBox);
            this.LogingroupBox.Controls.Add(this.loginUsernameTextBox);
            this.LogingroupBox.Controls.Add(this.usernameLabel);
            this.LogingroupBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogingroupBox.Location = new System.Drawing.Point(199, 88);
            this.LogingroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.LogingroupBox.Name = "LogingroupBox";
            this.LogingroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.LogingroupBox.Size = new System.Drawing.Size(431, 262);
            this.LogingroupBox.TabIndex = 4;
            this.LogingroupBox.TabStop = false;
            this.LogingroupBox.Text = "Login";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(151, 187);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(103, 36);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Location = new System.Drawing.Point(188, 129);
            this.loginPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '*';
            this.loginPasswordTextBox.Size = new System.Drawing.Size(140, 29);
            this.loginPasswordTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AutoSize = true;
            this.passwordTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(80, 129);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(87, 20);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.Text = "Password:";
            // 
            // loginUsernameTextBox
            // 
            this.loginUsernameTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginUsernameTextBox.Location = new System.Drawing.Point(188, 86);
            this.loginUsernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginUsernameTextBox.Name = "loginUsernameTextBox";
            this.loginUsernameTextBox.Size = new System.Drawing.Size(140, 29);
            this.loginUsernameTextBox.TabIndex = 5;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(80, 86);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(90, 20);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username:";
            // 
            // registrationLinkLabel
            // 
            this.registrationLinkLabel.ActiveLinkColor = System.Drawing.Color.Red;
            this.registrationLinkLabel.AutoSize = true;
            this.registrationLinkLabel.BackColor = System.Drawing.Color.MistyRose;
            this.registrationLinkLabel.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationLinkLabel.ForeColor = System.Drawing.Color.White;
            this.registrationLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.registrationLinkLabel.Location = new System.Drawing.Point(347, 381);
            this.registrationLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registrationLinkLabel.Name = "registrationLinkLabel";
            this.registrationLinkLabel.Size = new System.Drawing.Size(123, 20);
            this.registrationLinkLabel.TabIndex = 5;
            this.registrationLinkLabel.TabStop = true;
            this.registrationLinkLabel.Text = "Register Here !";
            this.registrationLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registrationLinkLabel_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(922, 575);
            this.Controls.Add(this.registrationLinkLabel);
            this.Controls.Add(this.LogingroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.LogingroupBox.ResumeLayout(false);
            this.LogingroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LogingroupBox;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.Label passwordTextBox;
        private System.Windows.Forms.TextBox loginUsernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel registrationLinkLabel;
    }
}