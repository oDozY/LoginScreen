namespace LoginScreen
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
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 50F);
            lblAppName.ForeColor = Color.FromArgb(128, 128, 255);
            lblAppName.Location = new Point(482, 50);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(308, 133);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.Info;
            txtID.Font = new Font("맑은 고딕", 30F);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(288, 297);
            txtID.Name = "txtID";
            txtID.Size = new Size(687, 87);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.BackColor = SystemColors.Info;
            txtPW.Font = new Font("맑은 고딕", 30F);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(288, 411);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(687, 87);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Info;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.Font = new Font("맑은 고딕", 40F);
            btnLogin.ForeColor = Color.FromArgb(192, 192, 255);
            btnLogin.Location = new Point(358, 628);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(550, 150);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("맑은 고딕", 15F);
            lblErrorMsg.ForeColor = Color.IndianRed;
            lblErrorMsg.Location = new Point(343, 537);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(579, 41);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못 되었습니다.";
            lblErrorMsg.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1278, 944);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            ForeColor = SystemColors.HotTrack;
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
        private Label lblErrorMsg;
    }
}
