namespace WindowSignIn
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
            label1 = new Label();
            id = new TextBox();
            password = new TextBox();
            SignInButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(248, 85);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 0;
            label1.Text = "로그인 창";
            // 
            // id
            // 
            id.Location = new Point(232, 144);
            id.Name = "id";
            id.Size = new Size(171, 23);
            id.TabIndex = 1;
            id.Text = "아이디";
            // 
            // password
            // 
            password.Location = new Point(232, 184);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(171, 23);
            password.TabIndex = 2;
            password.Text = "비밀번호";
            // 
            // SignInButton
            // 
            SignInButton.AutoSize = true;
            SignInButton.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SignInButton.Location = new Point(270, 225);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(96, 40);
            SignInButton.TabIndex = 3;
            SignInButton.Text = "로그인";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SignInButton);
            Controls.Add(password);
            Controls.Add(id);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox id;
        private TextBox password;
        private Button SignInButton;
    }
}