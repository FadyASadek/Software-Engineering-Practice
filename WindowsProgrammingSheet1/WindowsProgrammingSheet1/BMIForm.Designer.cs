namespace WindowsProgrammingSheet1
{
    partial class BMIForm
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
            lblWeightLabel = new Label();
            txtWeight = new TextBox();
            lblHeightLabel = new Label();
            txtHeight = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            lblResult = new Label();
            lblCategory = new Label();
            SuspendLayout();
            
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.ForeColor = Color.FromArgb(60, 64, 67);
            lblTitle.Location = new Point(120, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(180, 30);
            lblTitle.Text = "BMI Calculator";
            
            lblWeightLabel.AutoSize = true;
            lblWeightLabel.Font = new Font("Segoe UI", 10F);
            lblWeightLabel.ForeColor = Color.FromArgb(80, 85, 90);
            lblWeightLabel.Location = new Point(40, 80);
            lblWeightLabel.Name = "lblWeightLabel";
            lblWeightLabel.Size = new Size(80, 19);
            lblWeightLabel.Text = "Weight (kg)";
            
            txtWeight.BackColor = Color.White;
            txtWeight.BorderStyle = BorderStyle.FixedSingle;
            txtWeight.Font = new Font("Segoe UI", 10F);
            txtWeight.Location = new Point(180, 78);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(200, 25);
            
            lblHeightLabel.AutoSize = true;
            lblHeightLabel.Font = new Font("Segoe UI", 10F);
            lblHeightLabel.ForeColor = Color.FromArgb(80, 85, 90);
            lblHeightLabel.Location = new Point(40, 125);
            lblHeightLabel.Name = "lblHeightLabel";
            lblHeightLabel.Size = new Size(75, 19);
            lblHeightLabel.Text = "Height (m)";
            
            txtHeight.BackColor = Color.White;
            txtHeight.BorderStyle = BorderStyle.FixedSingle;
            txtHeight.Font = new Font("Segoe UI", 10F);
            txtHeight.Location = new Point(180, 123);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(200, 25);
            
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
            lblResult.Location = new Point(120, 240);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 21);
            lblResult.Text = "";
            
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F);
            lblCategory.Location = new Point(120, 270);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(0, 21);
            lblCategory.Text = "";
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(420, 320);
            Controls.Add(lblTitle);
            Controls.Add(lblWeightLabel);
            Controls.Add(txtWeight);
            Controls.Add(lblHeightLabel);
            Controls.Add(txtHeight);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(lblResult);
            Controls.Add(lblCategory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BMIForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BMI Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblWeightLabel;
        private TextBox txtWeight;
        private Label lblHeightLabel;
        private TextBox txtHeight;
        private Button btnCalculate;
        private Button btnClear;
        private Label lblResult;
        private Label lblCategory;
    }
}
