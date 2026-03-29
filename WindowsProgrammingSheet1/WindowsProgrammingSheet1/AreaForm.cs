namespace WindowsProgrammingSheet1
{
    public partial class AreaForm : Form
    {
        public AreaForm()
        {
            InitializeComponent();
            cmbShape.SelectedIndex = 0;
        }

        private void cmbShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";

            switch (cmbShape.SelectedItem?.ToString())
            {
                case "Rectangle":
                    lblDimension1.Text = "Length";
                    lblDimension2.Text = "Width";
                    lblDimension1.Visible = true;
                    txtDimension1.Visible = true;
                    lblDimension2.Visible = true;
                    txtDimension2.Visible = true;
                    break;
                case "Circle":
                    lblDimension1.Text = "Radius";
                    lblDimension1.Visible = true;
                    txtDimension1.Visible = true;
                    lblDimension2.Visible = false;
                    txtDimension2.Visible = false;
                    break;
                case "Triangle":
                    lblDimension1.Text = "Base";
                    lblDimension2.Text = "Height";
                    lblDimension1.Visible = true;
                    txtDimension1.Visible = true;
                    lblDimension2.Visible = true;
                    txtDimension2.Visible = true;
                    break;
            }

            txtDimension1.Clear();
            txtDimension2.Clear();
            txtDimension1.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string shape = cmbShape.SelectedItem?.ToString() ?? "";

            if (!double.TryParse(txtDimension1.Text, out double dim1) || dim1 <= 0)
            {
                MessageBox.Show($"Please enter a valid positive number for {lblDimension1.Text}.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDimension1.Focus();
                return;
            }

            double area = 0;

            switch (shape)
            {
                case "Rectangle":
                    if (!double.TryParse(txtDimension2.Text, out double width) || width <= 0)
                    {
                        MessageBox.Show("Please enter a valid positive number for Width.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDimension2.Focus();
                        return;
                    }
                    area = dim1 * width;
                    break;
                case "Circle":
                    area = Math.PI * dim1 * dim1;
                    break;
                case "Triangle":
                    if (!double.TryParse(txtDimension2.Text, out double height) || height <= 0)
                    {
                        MessageBox.Show("Please enter a valid positive number for Height.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDimension2.Focus();
                        return;
                    }
                    area = 0.5 * dim1 * height;
                    break;
            }

            lblResult.Text = $"Area: {area:F2}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDimension1.Clear();
            txtDimension2.Clear();
            lblResult.Text = "";
            txtDimension1.Focus();
        }
    }
}
