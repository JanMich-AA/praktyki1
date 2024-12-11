namespace Zadanie3
{
    public partial class Form1 : Form
    {

        Guy joe;
        Guy bob;
        int bank = 100;
        public Form1()
        {
            InitializeComponent();
            bob = new Guy();
            bob.Name = "Bob";
            bob.Cash = 100;
            joe = new Guy();
            joe.Name = "Joe";
            joe.Cash = 50;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " ma " + joe.Cash + " z�";
            bobsCashLabel.Text = bob.Name + " ma " + bob.Cash + " z�";
            bankCashLabel.Text = "Bank ma " + bank + " z�";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            } else
            {
                MessageBox.Show("Bank nie posiada takiej ilo�ci pieni�dzy");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }
    }
}
