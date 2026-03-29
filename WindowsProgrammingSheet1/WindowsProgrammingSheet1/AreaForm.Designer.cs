namespace WindowsProgrammingSheet1
{
    partial class AreaForm
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
            lblShapeLabel = new Label();
            cmbShape = new ComboBox();
            lblDimension1 = new Label();
            txtDimension1 = new TextBox();
            lblDimension2 = new Label();
            txtDimension2 = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            lblResult = new Label();
            SuspendLayout();
            
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.ForeColor = Color.FromArgb(60, 64, 67);
            lblTitle.Location = new Point(120, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(160, 30);
            lblTitle.Text = "Area Calculator";
            
            lblShapeLabel.AutoSize = true;
            lblShapeLabel.Font = new Font("Segoe UI", 10F);
            lblShapeLabel.ForeColor = Color.FromArgb(80, 85, 90);
            lblShapeLabel.Location = new Point(40, 80);
            lblShapeLabel.Name = "lblShapeLabel";
            lblShapeLabel.Size = new Size(85, 19);
            lblShapeLabel.Text = "Select Shape";
            
            cmbShape.BackColor = Color.White;
            cmbShape.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbShape.FlatStyle = FlatStyle.Flat;
            cmbShape.Font = new Font("Segoe UI", 10F);
            cmbShape.Items.AddRange(new object[] { "Rectangle", "Circle", "Triangle" });
            cmbShape.Location = new Point(180, 78);
            cmbShape.Name = "cmbShape";
            cmbShape.Size = new Size(200, 25);
            cmbShape.SelectedIndexChanged += cmbShape_SelectedIndexChanged;
            
            lblDimension1.AutoSize = true;
            lblDimension1.Font = new Font("Segoe UI", 10F);
            lblDimension1.ForeColor = Color.FromArgb(80, 85, 90);
            lblDimension1.Location = new Point(40, 125);
            lblDimension1.Name = "lblDimension1";
            lblDimension1.Size = new Size(50, 19);
            lblDimension1.Text = "Length";
            
            txtDimension1.BackColor = Color.White;
            txtDimension1.BorderStyle = BorderStyle.FixedSingle;
            txtDimension1.Font = new Font("Segoe UI", 10F);
            txtDimension1.Location = new Point(180, 123);
            txtDimension1.Name = "txtDimension1";
            txtDimension1.Size = new Size(200, 25);
            
            lblDimension2.AutoSize = true;
            lblDimension2.Font = new Font("Segoe UI", 10F);
            lblDimension2.ForeColor = Color.FromArgb(80, 85, 90);
            lblDimension2.Location = new Point(40, 170);
            lblDimension2.Name = "lblDimension2";
            lblDimension2.Size = new Size(45, 19);
            lblDimension2.Text = "Width";
            
            txtDimension2.BackColor = Color.White;
            txtDimension2.BorderStyle = BorderStyle.FixedSingle;
            txtDimension2.Font = new Font("Segoe UI", 10F);
            txtDimension2.Location = new Point(180, 168);
            txtDimension2.Name = "txtDimension2";
            txtDimension2.Size = new Size(200, 25);
            
            btnCalculate.BackColor = Color.FromArgb(214, 234, 248);
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 10F);
            btnCalculate.ForeColor = Color.FromArgb(60, 64, 67);
            btnCalculate.Location = new Point(80, 220);
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
            btnClear.Location = new Point(220, 220);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 38);
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F);
            lblResult.ForeColor = Color.FromArgb(60, 64, 67);
            lblResult.Location = new Point(130, 280);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 21);
            lblResult.Text = "";
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(420, 330);
            Controls.Add(lblTitle);
            Controls.Add(lblShapeLabel);
            Controls.Add(cmbShape);
            Controls.Add(lblDimension1);
            Controls.Add(txtDimension1);
            Controls.Add(lblDimension2);
            Controls.Add(txtDimension2);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(lblResult);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AreaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Area Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblShapeLabel;
        private ComboBox cmbShape;
        private Label lblDimension1;
        private TextBox txtDimension1;
        private Label lblDimension2;
        private TextBox txtDimension2;
        private Button btnCalculate;
        private Button btnClear;
        private Label lblResult;
    }
}
