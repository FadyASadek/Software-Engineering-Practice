namespace WindowsProgrammingSheet1
{
    public partial class DiscountForm : Form
    {
        public DiscountForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtOriginalPrice.Text, out double originalPrice) || originalPrice < 0)
            {
                MessageBox.Show("Please enter a valid non-negative number for Original Price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOriginalPrice.Focus();
                return;
            }

            if (!double.TryParse(txtDiscount.Text, out double discount) || discount < 0 || discount > 100)
            {
                MessageBox.Show("Please enter a valid Discount Percentage (0 - 100).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiscount.Focus();
                return;
            }

            double finalPrice = originalPrice - (originalPrice * discount / 100);
            lblResult.Text = $"Final Price: {finalPrice:F2}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOriginalPrice.Clear();
            txtDiscount.Clear();
            lblResult.Text = "";
            txtOriginalPrice.Focus();
        }
    }
}
