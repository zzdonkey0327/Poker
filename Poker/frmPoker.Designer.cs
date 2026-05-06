namespace Poker
{
    partial class frmPoker
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
            this.grpPoker = new System.Windows.Forms.GroupBox();
            this.grpBet = new System.Windows.Forms.GroupBox();
            this.lblMoneyText = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblBetText = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.grpBet.SuspendLayout();
            this.grpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPoker
            // 
            this.grpPoker.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.Location = new System.Drawing.Point(12, 12);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Size = new System.Drawing.Size(485, 160);
            this.grpPoker.TabIndex = 0;
            this.grpPoker.TabStop = false;
            this.grpPoker.Text = "牌桌";
            // 
            // grpBet
            // 
            this.grpBet.Controls.Add(this.btnBet);
            this.grpBet.Controls.Add(this.txtBet);
            this.grpBet.Controls.Add(this.lblBetText);
            this.grpBet.Controls.Add(this.txtMoney);
            this.grpBet.Controls.Add(this.lblMoneyText);
            this.grpBet.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
            this.grpBet.Location = new System.Drawing.Point(12, 178);
            this.grpBet.Name = "grpBet";
            this.grpBet.Size = new System.Drawing.Size(485, 80);
            this.grpBet.TabIndex = 1;
            this.grpBet.TabStop = false;
            this.grpBet.Text = "下注";
            // 
            // lblMoneyText
            // 
            this.lblMoneyText.AutoSize = true;
            this.lblMoneyText.Location = new System.Drawing.Point(20, 36);
            this.lblMoneyText.Name = "lblMoneyText";
            this.lblMoneyText.Size = new System.Drawing.Size(58, 20);
            this.lblMoneyText.TabIndex = 0;
            this.lblMoneyText.Text = "總資金";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(84, 33);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(120, 29);
            this.txtMoney.TabIndex = 1;
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBetText
            // 
            this.lblBetText.AutoSize = true;
            this.lblBetText.Location = new System.Drawing.Point(220, 36);
            this.lblBetText.Name = "lblBetText";
            this.lblBetText.Size = new System.Drawing.Size(74, 20);
            this.lblBetText.TabIndex = 2;
            this.lblBetText.Text = "押注金額";
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(300, 33);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(90, 29);
            this.txtBet.TabIndex = 3;
            this.txtBet.Text = "500";
            this.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(400, 30);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(64, 36);
            this.btnBet.TabIndex = 4;
            this.btnBet.Text = "押注";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.lblResult);
            this.grpButton.Controls.Add(this.btnCheck);
            this.grpButton.Controls.Add(this.btnChangeCard);
            this.grpButton.Controls.Add(this.btnDealCard);
            this.grpButton.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
            this.grpButton.Location = new System.Drawing.Point(12, 264);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(485, 80);
            this.grpButton.TabIndex = 2;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "功能";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(252, 28);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(223, 36);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(164, 28);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(82, 36);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Location = new System.Drawing.Point(94, 28);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(64, 36);
            this.btnChangeCard.TabIndex = 1;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = true;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.Location = new System.Drawing.Point(21, 28);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(67, 36);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = true;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 360);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpBet);
            this.Controls.Add(this.grpPoker);
            this.KeyPreview = true;
            this.Name = "frmPoker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五張撲克牌";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPoker_KeyPress);
            this.grpBet.ResumeLayout(false);
            this.grpBet.PerformLayout();
            this.grpButton.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpPoker;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.Label lblResult;

        private System.Windows.Forms.GroupBox grpBet;
        private System.Windows.Forms.Label lblMoneyText;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblBetText;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Button btnBet;
    }
}