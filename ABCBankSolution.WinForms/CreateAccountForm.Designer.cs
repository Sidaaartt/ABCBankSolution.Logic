
namespace SampleBankWinForms
{
    partial class CreateAccountForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblEmail = new Label();
            lblPassword = new Label();
            lblInitialBalance = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtInitialBalance = new TextBox();
            btnCreate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 30);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(30, 80);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblInitialBalance
            // 
            lblInitialBalance.AutoSize = true;
            lblInitialBalance.Location = new Point(30, 130);
            lblInitialBalance.Name = "lblInitialBalance";
            lblInitialBalance.Size = new Size(98, 20);
            lblInitialBalance.TabIndex = 2;
            lblInitialBalance.Text = "Initial Balance";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 30);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 80);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 4;
            // 
            // txtInitialBalance
            // 
            txtInitialBalance.Location = new Point(150, 130);
            txtInitialBalance.Name = "txtInitialBalance";
            txtInitialBalance.Size = new Size(200, 27);
            txtInitialBalance.TabIndex = 5;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(30, 190);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 35);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(250, 190);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 250);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(txtInitialBalance);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblInitialBalance);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Name = "CreateAccountForm";
            Text = "Create Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblPassword;
        private Label lblInitialBalance;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtInitialBalance;
        private Button btnCreate;
        private Button btnCancel;
    }
}
