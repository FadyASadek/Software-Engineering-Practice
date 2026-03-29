namespace WindowsProgrammingSheet1
{
    partial class Form1
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
            lblSubtitle = new Label();
            btnDiscount = new Button();
            btnBMI = new Button();
            btnArea = new Button();
            btnAverage = new Button();
            SuspendLayout();
            
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F);
            lblTitle.ForeColor = Color.FromArgb(60, 64, 67);
            lblTitle.Location = new Point(140, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 32);
            lblTitle.Text = "Main Dashboard";
            
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 125, 130);
            lblSubtitle.Location = new Point(160, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(180, 19);
            lblSubtitle.Text = "Select a calculator to start";
            
            btnDiscount.BackColor = Color.FromArgb(214, 234, 248);
            btnDiscount.Cursor = Cursors.Hand;
            btnDiscount.FlatAppearance.BorderSize = 0;
            btnDiscount.FlatStyle = FlatStyle.Flat;
            btnDiscount.Font = new Font("Segoe UI", 11F);
            btnDiscount.ForeColor = Color.FromArgb(60, 64, 67);
            btnDiscount.Location = new Point(100, 130);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(300, 45);
            btnDiscount.Text = "Discount Calculator";
            btnDiscount.UseVisualStyleBackColor = false;
            btnDiscount.Click += btnDiscount_Click;
            
            btnBMI.BackColor = Color.FromArgb(212, 239, 223);
            btnBMI.Cursor = Cursors.Hand;
            btnBMI.FlatAppearance.BorderSize = 0;
            btnBMI.FlatStyle = FlatStyle.Flat;
            btnBMI.Font = new Font("Segoe UI", 11F);
            btnBMI.ForeColor = Color.FromArgb(60, 64, 67);
            btnBMI.Location = new Point(100, 190);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(300, 45);
            btnBMI.Text = "BMI Calculator";
            btnBMI.UseVisualStyleBackColor = false;
            btnBMI.Click += btnBMI_Click;
            
            btnArea.BackColor = Color.FromArgb(252, 243, 207);
            btnArea.Cursor = Cursors.Hand;
            btnArea.FlatAppearance.BorderSize = 0;
            btnArea.FlatStyle = FlatStyle.Flat;
            btnArea.Font = new Font("Segoe UI", 11F);
            btnArea.ForeColor = Color.FromArgb(60, 64, 67);
            btnArea.Location = new Point(100, 250);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(300, 45);
            btnArea.Text = "Area Calculator";
            btnArea.UseVisualStyleBackColor = false;
            btnArea.Click += btnArea_Click;
            
            btnAverage.BackColor = Color.FromArgb(235, 222, 240);
            btnAverage.Cursor = Cursors.Hand;
            btnAverage.FlatAppearance.BorderSize = 0;
            btnAverage.FlatStyle = FlatStyle.Flat;
            btnAverage.Font = new Font("Segoe UI", 11F);
            btnAverage.ForeColor = Color.FromArgb(60, 64, 67);
            btnAverage.Location = new Point(100, 310);
            btnAverage.Name = "btnAverage";
            btnAverage.Size = new Size(300, 45);
            btnAverage.Text = "Student Average Calculator";
            btnAverage.UseVisualStyleBackColor = false;
            btnAverage.Click += btnAverage_Click;
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(500, 400);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(btnDiscount);
            Controls.Add(btnBMI);
            Controls.Add(btnArea);
            Controls.Add(btnAverage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows Programming - Sheet 1";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnDiscount;
        private Button btnBMI;
        private Button btnArea;
        private Button btnAverage;
    }
}
