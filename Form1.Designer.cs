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
            lblAppName.Font = new Font("Engravers MT", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.FromArgb(255, 128, 0);
            lblAppName.Location = new Point(71, 26);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(617, 149);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Login";
            lblAppName.Click += lbl_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.FromArgb(224, 224, 224);
            txtID.Location = new Point(107, 235);
            txtID.Name = "txtID";
            txtID.Size = new Size(539, 107);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.FontChanged += txtID_FontChanged;
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.FromArgb(224, 224, 224);
            txtPW.Location = new Point(107, 363);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(539, 107);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.TextChanged += txtPW_TextChanged;
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 255, 255);
            btnLogin.Font = new Font("휴먼엑스포", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLogin.ForeColor = Color.Teal;
            btnLogin.Location = new Point(188, 611);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(345, 129);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "로그인\r\n";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("나눔고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(107, 498);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(562, 36);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 패스워드가 잘못되었습니다.";
            lblErrorMsg.Visible = false;
            lblErrorMsg.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 820);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Login Screen";
            Load += Form1_Load;
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
