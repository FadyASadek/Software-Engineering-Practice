namespace WindowsProgrammingSheet1
{
    public partial class AverageForm : Form
    {
        public AverageForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtSubject1.Text, out double grade1) || grade1 < 0 || grade1 > 100)
            {
                MessageBox.Show("Please enter a valid grade (0 - 100) for Subject 1.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubject1.Focus();
                return;
            }

            if (!double.TryParse(txtSubject2.Text, out double grade2) || grade2 < 0 || grade2 > 100)
            {
                MessageBox.Show("Please enter a valid grade (0 - 100) for Subject 2.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubject2.Focus();
                return;
            }

            if (!double.TryParse(txtSubject3.Text, out double grade3) || grade3 < 0 || grade3 > 100)
            {
                MessageBox.Show("Please enter a valid grade (0 - 100) for Subject 3.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubject3.Focus();
                return;
            }

            double average = (grade1 + grade2 + grade3) / 3.0;

            string evaluation;
            Color evalColor;

            if (average < 50)
            {
                evaluation = "Fail";
                evalColor = Color.FromArgb(231, 76, 60);
            }
            else if (average < 65)
            {
                evaluation = "Pass";
                evalColor = Color.FromArgb(243, 156, 18);
            }
            else if (average < 75)
            {
                evaluation = "Good";
                evalColor = Color.FromArgb(52, 152, 219);
            }
            else if (average < 85)
            {
                evaluation = "Very Good";
                evalColor = Color.FromArgb(39, 174, 96);
            }
            else
            {
                evaluation = "Excellent";
                evalColor = Color.FromArgb(46, 204, 113);
            }

            lblResult.Text = $"Average: {average:F2}";
            lblEvaluation.Text = $"Evaluation: {evaluation}";
            lblEvaluation.ForeColor = evalColor;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubject1.Clear();
            txtSubject2.Clear();
            txtSubject3.Clear();
            lblResult.Text = "";
            lblEvaluation.Text = "";
            txtSubject1.Focus();
        }
    }
}
