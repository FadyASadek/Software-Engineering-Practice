namespace WindowsProgrammingSheet1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            DiscountForm form = new DiscountForm();
            form.Show();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            BMIForm form = new BMIForm();
            form.Show();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            AreaForm form = new AreaForm();
            form.Show();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            AverageForm form = new AverageForm();
            form.Show();
        }
    }
}
