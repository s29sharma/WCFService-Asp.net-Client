namespace CalcClientForm
{
    partial class Form1
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
            this.PurchasePrice = new System.Windows.Forms.Label();
            this.purchaseText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InterestText = new System.Windows.Forms.TextBox();
            this.Amort = new System.Windows.Forms.Label();
            this.DownPercentage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.downPayment = new System.Windows.Forms.Label();
            this.downText = new System.Windows.Forms.TextBox();
            this.remText = new System.Windows.Forms.TextBox();
            this.monthlyText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Interest = new System.Windows.Forms.Label();
            this.amortization = new System.Windows.Forms.TextBox();
            this.percentDown = new System.Windows.Forms.TextBox();
            this.MiText = new System.Windows.Forms.TextBox();
            this.MonthlyInterest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.AutoSize = true;
            this.PurchasePrice.Location = new System.Drawing.Point(37, 37);
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Size = new System.Drawing.Size(79, 13);
            this.PurchasePrice.TabIndex = 0;
            this.PurchasePrice.Text = "Purchase Price";
            // 
            // purchaseText
            // 
            this.purchaseText.Location = new System.Drawing.Point(204, 30);
            this.purchaseText.Name = "purchaseText";
            this.purchaseText.Size = new System.Drawing.Size(121, 20);
            this.purchaseText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // InterestText
            // 
            this.InterestText.Location = new System.Drawing.Point(204, 74);
            this.InterestText.Name = "InterestText";
            this.InterestText.Size = new System.Drawing.Size(121, 20);
            this.InterestText.TabIndex = 3;
            // 
            // Amort
            // 
            this.Amort.AutoSize = true;
            this.Amort.Location = new System.Drawing.Point(37, 133);
            this.Amort.Name = "Amort";
            this.Amort.Size = new System.Drawing.Size(64, 13);
            this.Amort.TabIndex = 4;
            this.Amort.Text = "Amortization";
            // 
            // DownPercentage
            // 
            this.DownPercentage.AutoSize = true;
            this.DownPercentage.Location = new System.Drawing.Point(37, 190);
            this.DownPercentage.Name = "DownPercentage";
            this.DownPercentage.Size = new System.Drawing.Size(93, 13);
            this.DownPercentage.TabIndex = 7;
            this.DownPercentage.Text = "Down Percentage";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // downPayment
            // 
            this.downPayment.AutoSize = true;
            this.downPayment.Location = new System.Drawing.Point(40, 292);
            this.downPayment.Name = "downPayment";
            this.downPayment.Size = new System.Drawing.Size(79, 13);
            this.downPayment.TabIndex = 9;
            this.downPayment.Text = "Down Payment";
            // 
            // downText
            // 
            this.downText.Location = new System.Drawing.Point(204, 292);
            this.downText.Name = "downText";
            this.downText.Size = new System.Drawing.Size(121, 20);
            this.downText.TabIndex = 10;
            // 
            // remText
            // 
            this.remText.Location = new System.Drawing.Point(204, 328);
            this.remText.Name = "remText";
            this.remText.Size = new System.Drawing.Size(121, 20);
            this.remText.TabIndex = 11;
            // 
            // monthlyText
            // 
            this.monthlyText.Location = new System.Drawing.Point(204, 374);
            this.monthlyText.Name = "monthlyText";
            this.monthlyText.Size = new System.Drawing.Size(121, 20);
            this.monthlyText.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Remaining Mortgage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Monthly Mortgage";
            // 
            // Interest
            // 
            this.Interest.AutoSize = true;
            this.Interest.Location = new System.Drawing.Point(40, 81);
            this.Interest.Name = "Interest";
            this.Interest.Size = new System.Drawing.Size(68, 13);
            this.Interest.TabIndex = 15;
            this.Interest.Text = "Interest Rate";
            // 
            // amortization
            // 
            this.amortization.Location = new System.Drawing.Point(204, 125);
            this.amortization.Name = "amortization";
            this.amortization.Size = new System.Drawing.Size(121, 20);
            this.amortization.TabIndex = 16;
            // 
            // percentDown
            // 
            this.percentDown.Location = new System.Drawing.Point(204, 190);
            this.percentDown.Name = "percentDown";
            this.percentDown.Size = new System.Drawing.Size(121, 20);
            this.percentDown.TabIndex = 17;
            // 
            // MiText
            // 
            this.MiText.Location = new System.Drawing.Point(204, 421);
            this.MiText.Name = "MiText";
            this.MiText.Size = new System.Drawing.Size(121, 20);
            this.MiText.TabIndex = 18;
            // 
            // MonthlyInterest
            // 
            this.MonthlyInterest.AutoSize = true;
            this.MonthlyInterest.Location = new System.Drawing.Point(43, 428);
            this.MonthlyInterest.Name = "MonthlyInterest";
            this.MonthlyInterest.Size = new System.Drawing.Size(82, 13);
            this.MonthlyInterest.TabIndex = 19;
            this.MonthlyInterest.Text = "Monthly Interest";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 469);
            this.Controls.Add(this.MonthlyInterest);
            this.Controls.Add(this.MiText);
            this.Controls.Add(this.percentDown);
            this.Controls.Add(this.amortization);
            this.Controls.Add(this.Interest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monthlyText);
            this.Controls.Add(this.remText);
            this.Controls.Add(this.downText);
            this.Controls.Add(this.downPayment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DownPercentage);
            this.Controls.Add(this.Amort);
            this.Controls.Add(this.InterestText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.purchaseText);
            this.Controls.Add(this.PurchasePrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PurchasePrice;
        private System.Windows.Forms.TextBox purchaseText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InterestText;
        private System.Windows.Forms.Label Amort;
        private System.Windows.Forms.Label DownPercentage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label downPayment;
        private System.Windows.Forms.TextBox downText;
        private System.Windows.Forms.TextBox remText;
        private System.Windows.Forms.TextBox monthlyText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Interest;
        private System.Windows.Forms.TextBox amortization;
        private System.Windows.Forms.TextBox percentDown;
        private System.Windows.Forms.TextBox MiText;
        private System.Windows.Forms.Label MonthlyInterest;
    }
}

