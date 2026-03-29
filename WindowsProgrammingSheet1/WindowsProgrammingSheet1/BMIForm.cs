namespace WindowsProgrammingSheet1
{
    public partial class BMIForm : Form
    {
        public BMIForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtWeight.Text, out double weight) || weight <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for Weight (kg).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeight.Focus();
                return;
            }

            if (!double.TryParse(txtHeight.Text, out double height) || height <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for Height (m).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHeight.Focus();
                return;
            }

            double bmi = weight / (height * height);

            string category;
            Color categoryColor;

            if (bmi < 18.5)
            {
                category = "Underweight";
                categoryColor = Color.FromArgb(243, 156, 18);
            }
            else if (bmi <= 24.9)
            {
                category = "Normal";
                categoryColor = Color.FromArgb(39, 174, 96);
            }
            else if (bmi <= 29.9)
            {
                category = "Overweight";
                categoryColor = Color.FromArgb(230, 126, 34);
            }
            else
            {
                category = "Obese";
                categoryColor = Color.FromArgb(231, 76, 60);
            }

            lblResult.Text = $"BMI: {bmi:F2}";
            lblCategory.Text = $"Category: {category}";
            lblCategory.ForeColor = categoryColor;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWeight.Clear();
            txtHeight.Clear();
            lblResult.Text = "";
            lblCategory.Text = "";
            txtWeight.Focus();
        }
    }
}
