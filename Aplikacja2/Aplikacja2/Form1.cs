namespace Aplikacja2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = Talker.BlahBlahBlah(textBox1.Text, (int)numericUpdDown1.Value);
            MessageBox.Show("D³ugoœæ wiadomoœci to " + len);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
