using System;
using System.Windows.Forms;

namespace Quan_ly_ban_quan_ao
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btn_statistic_Click(object sender, EventArgs e)
        {
            FormStatistic FormStatistic = new FormStatistic();
            FormStatistic.Show();
        }
        private void btn_product_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show("Are you want to exit..?",
               "Warning",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (cc == DialogResult.No)
            {
                MessageBox.Show("Cam on da su dung");
            }
            else
            {
                Hide();
            }
        }
    }
}
