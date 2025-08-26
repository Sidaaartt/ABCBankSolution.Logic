
namespace SampleBankWinForms
{
    partial class BankingMenuForm
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
            txtAmount = new TextBox();
            btnCheckBalance = new Button();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            btnLogout = new Button();
            SuspendLayout();
         
            txtAmount.Location = new Point(30, 30);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "Enter amount";
            txtAmount.Size = new Size(200, 27);
            txtAmount.TabIndex = 0;
     
            btnCheckBalance.Location = new Point(30, 80);
            btnCheckBalance.Name = "btnCheckBalance";
            btnCheckBalance.Size = new Size(150, 35);
            btnCheckBalance.TabIndex = 1;
            btnCheckBalance.Text = "Check Balance";
            btnCheckBalance.UseVisualStyleBackColor = true;
            btnCheckBalance.Click += btnCheckBalance_Click;
         
            btnDeposit.Location = new Point(30, 130);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(150, 35);
            btnDeposit.TabIndex = 2;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
        
            btnWithdraw.Location = new Point(30, 180);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(150, 35);
            btnWithdraw.TabIndex = 3;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
         
            btnLogout.Location = new Point(30, 230);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 35);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // BankingMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 300);
            Controls.Add(btnLogout);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(btnCheckBalance);
            Controls.Add(txtAmount);
            Name = "BankingMenuForm";
            Text = "Banking Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmount;
        private Button btnCheckBalance;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnLogout;
    }
}
