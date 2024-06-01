using ItemNameSpace;

namespace CashierApplication
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private double total_amount;
        private void button1_Click(object sender, EventArgs e)

        {

            string item_name = textBox1.Text;
            double item_price = Convert.ToDouble(textBox2.Text);
            double item_discount = Convert.ToDouble(textBox3.Text);
            int item_quantity = Convert.ToInt32(textBox4.Text);

            DiscountedItem discountedItem = new DiscountedItem(item_name, item_price, item_quantity, item_discount);
            total_amount = discountedItem.getTotalPrice();
            label8.Text = total_amount.ToString("0.00");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            double paymentRecieved = Convert.ToDouble(textBox5.Text);

            DiscountedItem discountedItem = new DiscountedItem("", 0, 0, 0);
            discountedItem.setPayment(paymentRecieved);
            double change = discountedItem.getChange(total_amount);
            label9.Text = change.ToString("0.00");

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginAccount frmLoginAccount = new frmLoginAccount();
            frmLoginAccount.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

