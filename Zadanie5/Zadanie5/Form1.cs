namespace Zadanie5
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;

        

        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant()
            { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant()
            { Name = "lloyd", EarSize = 40 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = lloyd;
            lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Obiekty zmienione");
        }
    }
}
