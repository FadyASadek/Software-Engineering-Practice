namespace WindowsProgrammingSheet1
{
    partial class AverageForm
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
            lblSubject1 = new Label();
            txtSubject1 = new TextBox();
            lblSubject2 = new Label();
            txtSubject2 = new TextBox();
            lblSubject3 = new Label();
            txtSubject3 = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            lblResult = new Label();
            lblEvaluation = new Label();
            SuspendLayout();
            
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.ForeColor = Color.FromArgb(60, 64, 67);
            lblTitle.Location = new Point(90, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(270, 30);
            lblTitle.Text = "Student Average Calculator";
            
            lblSubject1.AutoSize = true;
            lblSubject1.Font = new Font("Segoe UI", 10F);
            lblSubject1.ForeColor = Color.FromArgb(80, 85, 90);
            lblSubject1.Location = new Point(40, 80);
            lblSubject1.Name = "lblSubject1";
            lblSubject1.Size = new Size(100, 19);
            lblSubject1.Text = "Subject 1 Grade";
            
            txtSubject1.BackColor = Color.White;
            txtSubject1.BorderStyle = BorderStyle.FixedSingle;
            txtSubject1.Font = new Font("Segoe UI", 10F);
            txtSubject1.Location = new Point(200, 78);
            txtSubject1.Name = "txtSubject1";
            txtSubject1.Size = new Size(180, 25);
            
            lblSubject2.AutoSize = true;
            lblSubject2.Font = new Font("Segoe UI", 10F);
            lblSubject2.ForeColor = Color.FromArgb(80, 85, 90);
            lblSubject2.Location = new Point(40, 125);
            lblSubject2.Name = "lblSubject2";
            lblSubject2.Size = new Size(100, 19);
            lblSubject2.Text = "Subject 2 Grade";
            
            txtSubject2.BackColor = Color.White;
            txtSubject2.BorderStyle = BorderStyle.FixedSingle;
            txtSubject2.Font = new Font("Segoe UI", 10F);
            txtSubject2.Location = new Point(200, 123);
            txtSubject2.Name = "txtSubject2";
            txtSubject2.Size = new Size(180, 25);
            
            lblSubject3.AutoSize = true;
            lblSubject3.Font = new Font("Segoe UI", 10F);
            lblSubject3.ForeColor = Color.FromArgb(80, 85, 90);
            lblSubject3.Location = new Point(40, 170);
            lblSubject3.Name = "lblSubject3";
            lblSubject3.Size = new Size(100, 19);
            lblSubject3.Text = "Subject 3 Grade";
            
            txtSubject3.BackColor = Color.White;
            txtSubject3.BorderStyle = BorderStyle.FixedSingle;
            txtSubject3.Font = new Font("Segoe UI", 10F);
            txtSubject3.Location = new Point(200, 168);
            txtSubject3.Name = "txtSubject3";
            txtSubject3.Size = new Size(180, 25);
            
            btnCalculate.BackColor = Color.FromArgb(214, 234, 248);
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 10F);
            btnCalculate.ForeColor = Color.FromArgb(60, 64, 67);
            btnCalculate.Location = new Point(90, 220);
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
            btnClear.Location = new Point(230, 220);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 38);
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F);
            lblResult.ForeColor = Color.FromArgb(60, 64, 67);
            lblResult.Location = new Point(110, 280);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 21);
            lblResult.Text = "";
            
            lblEvaluation.AutoSize = true;
            lblEvaluation.Font = new Font("Segoe UI", 12F);
            lblEvaluation.Location = new Point(110, 310);
            lblEvaluation.Name = "lblEvaluation";
            lblEvaluation.Size = new Size(0, 21);
            lblEvaluation.Text = "";
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(430, 360);
            Controls.Add(lblTitle);
            Controls.Add(lblSubject1);
            Controls.Add(txtSubject1);
            Controls.Add(lblSubject2);
            Controls.Add(txtSubject2);
            Controls.Add(lblSubject3);
            Controls.Add(txtSubject3);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(lblResult);
            Controls.Add(lblEvaluation);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AverageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Average Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblSubject1;
        private TextBox txtSubject1;
        private Label lblSubject2;
        private TextBox txtSubject2;
        private Label lblSubject3;
        private TextBox txtSubject3;
        private Button btnCalculate;
        private Button btnClear;
        private Label lblResult;
        private Label lblEvaluation;
    }
}
