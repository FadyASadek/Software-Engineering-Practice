namespace WindowsProgrammingSheet1
{
    partial class DiscountForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblOriginalPrice = new Label();
            txtOriginalPrice = new TextBox();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            lblResult = new Label();
            SuspendLayout();
            
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.ForeColor = Color.FromArgb(60, 64, 67);
            lblTitle.Location = new Point(110, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 30);
            lblTitle.Text = "Discount Calculator";
            
            lblOriginalPrice.AutoSize = true;
            lblOriginalPrice.Font = new Font("Segoe UI", 10F);
            lblOriginalPrice.ForeColor = Color.FromArgb(80, 85, 90);
            lblOriginalPrice.Location = new Point(40, 80);
            lblOriginalPrice.Name = "lblOriginalPrice";
            lblOriginalPrice.Size = new Size(100, 19);
            lblOriginalPrice.Text = "Original Price";
            
            txtOriginalPrice.Font = new Font("Segoe UI", 10F);
            txtOriginalPrice.BackColor = Color.White;
            txtOriginalPrice.BorderStyle = BorderStyle.FixedSingle;
            txtOriginalPrice.Location = new Point(180, 78);
            txtOriginalPrice.Name = "txtOriginalPrice";
            txtOriginalPrice.Size = new Size(200, 25);
            
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 10F);
            lblDiscount.ForeColor = Color.FromArgb(80, 85, 90);
            lblDiscount.Location = new Point(40, 125);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(95, 19);
            lblDiscount.Text = "Discount (%)";
            
            txtDiscount.Font = new Font("Segoe UI", 10F);
            txtDiscount.BackColor = Color.White;
            txtDiscount.BorderStyle = BorderStyle.FixedSingle;
            txtDiscount.Location = new Point(180, 123);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(200, 25);
            
            btnCalculate.BackColor = Color.FromArgb(214, 234, 248);
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 10F);
            btnCalculate.ForeColor = Color.FromArgb(60, 64, 67);
            btnCalculate.Location = new Point(80, 180);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 38);
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            
            btnClear.BackColor = Color.FromArgb(235, 237, 240);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.ForeColor = Color.FromArgb(60, 64, 67);
            btnClear.Location = new Point(220, 180);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 38);
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F);
            lblResult.ForeColor = Color.FromArgb(60, 64, 67);
            lblResult.Location = new Point(110, 240);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 21);
            lblResult.Text = "";
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(420, 300);
            Controls.Add(lblTitle);
            Controls.Add(lblOriginalPrice);
            Controls.Add(txtOriginalPrice);
            Controls.Add(lblDiscount);
            Controls.Add(txtDiscount);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(lblResult);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DiscountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Discount Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblOriginalPrice;
        private TextBox txtOriginalPrice;
        private Label lblDiscount;
        private TextBox txtDiscount;
        private Button btnCalculate;
        private Button btnClear;
        private Label lblResult;
    }
}
