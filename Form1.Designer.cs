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
            lblAppName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Comic Sans MS", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.Location = new Point(133, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(202, 94);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtID.BackColor = SystemColors.Window;
            txtID.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(51, 126);
            txtID.Name = "txtID";
            txtID.Size = new Size(382, 51);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPW.BackColor = SystemColors.Window;
            txtPW.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(51, 209);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(382, 51);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(128, 255, 255);
            btnLogin.Font = new Font("한컴산뜻돋움", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Blue;
            btnLogin.Location = new Point(133, 297);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(202, 49);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(51, 263);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(272, 20);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 혹은 패스워드가 맞지 않습니다.";
            lblErrorMsg.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 400);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
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
