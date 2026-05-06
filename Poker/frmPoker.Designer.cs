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
            this.btnBet = new System.Windows.Forms.Button();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.lblBetText = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblMoneyText = new System.Windows.Forms.Label();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPrize = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.grpBet.SuspendLayout();
            this.grpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPoker
            // 
            this.grpPoker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.Location = new System.Drawing.Point(18, 18);
            this.grpPoker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPoker.Size = new System.Drawing.Size(728, 240);
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
            this.grpBet.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.grpBet.Location = new System.Drawing.Point(18, 267);
            this.grpBet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBet.Name = "grpBet";
            this.grpBet.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBet.Size = new System.Drawing.Size(728, 120);
            this.grpBet.TabIndex = 1;
            this.grpBet.TabStop = false;
            this.grpBet.Text = "下注";
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(600, 45);
            this.btnBet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(96, 54);
            this.btnBet.TabIndex = 4;
            this.btnBet.Text = "押注";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(450, 50);
            this.txtBet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(133, 39);
            this.txtBet.TabIndex = 3;
            this.txtBet.Text = "500";
            this.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBetText
            // 
            this.lblBetText.AutoSize = true;
            this.lblBetText.Location = new System.Drawing.Point(330, 54);
            this.lblBetText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBetText.Name = "lblBetText";
            this.lblBetText.Size = new System.Drawing.Size(109, 30);
            this.lblBetText.TabIndex = 2;
            this.lblBetText.Text = "押注金額";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(126, 50);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(178, 39);
            this.txtMoney.TabIndex = 1;
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMoneyText
            // 
            this.lblMoneyText.AutoSize = true;
            this.lblMoneyText.Location = new System.Drawing.Point(30, 54);
            this.lblMoneyText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoneyText.Name = "lblMoneyText";
            this.lblMoneyText.Size = new System.Drawing.Size(85, 30);
            this.lblMoneyText.TabIndex = 0;
            this.lblMoneyText.Text = "總資金";
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.lblResult);
            this.grpButton.Controls.Add(this.lblPrize);
            this.grpButton.Controls.Add(this.btnCheck);
            this.grpButton.Controls.Add(this.btnChangeCard);
            this.grpButton.Controls.Add(this.btnDealCard);
            this.grpButton.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.grpButton.Location = new System.Drawing.Point(18, 396);
            this.grpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpButton.Name = "grpButton";
            this.grpButton.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpButton.Size = new System.Drawing.Size(728, 142);
            this.grpButton.TabIndex = 2;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "功能";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(377, 34);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(334, 39);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrize
            // 
            this.lblPrize.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblPrize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrize.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.lblPrize.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPrize.Location = new System.Drawing.Point(377, 79);
            this.lblPrize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(334, 42);
            this.lblPrize.TabIndex = 4;
            this.lblPrize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(238, 53);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(123, 54);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Location = new System.Drawing.Point(133, 53);
            this.btnChangeCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(96, 54);
            this.btnChangeCard.TabIndex = 1;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = true;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.Location = new System.Drawing.Point(24, 53);
            this.btnDealCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(100, 54);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = true;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 570);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpBet);
            this.Controls.Add(this.grpPoker);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

        private System.Windows.Forms.Label lblPrize;
    }
}