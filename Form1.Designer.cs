namespace LoginApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnLogin = new Button();
            btnCancel = new Button();
            lblUser = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            chkShowPass = new CheckBox();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            lblPass = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SpringGreen;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(259, 248);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(115, 43);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Crimson;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Ivory;
            btnCancel.Location = new Point(408, 248);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 43);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.Coral;
            lblUser.Location = new Point(255, 94);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(101, 25);
            lblUser.TabIndex = 1;
            lblUser.Text = "Username";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(370, 94);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(138, 23);
            txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(370, 136);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(138, 23);
            txtPass.TabIndex = 2;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPass.Location = new Point(370, 197);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(138, 25);
            chkShowPass.TabIndex = 3;
            chkShowPass.Text = "Show Password";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Linen;
            linkLabel1.Location = new Point(448, 302);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPass.ForeColor = Color.Coral;
            lblPass.Location = new Point(255, 136);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(97, 25);
            lblPass.TabIndex = 1;
            lblPass.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(259, 52);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(370, 52);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(138, 23);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(553, 346);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(chkShowPass);
            Controls.Add(txtEmail);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnCancel;
        private Label lblUser;
        private TextBox txtUser;
        private TextBox txtPass;
        private CheckBox chkShowPass;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label lblPass;
        private Label label1;
        private TextBox txtEmail;
    }
}
