namespace Zadanie10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyBaseClass myBaseClass = new MyBaseClass("baza");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySubClass mySubClass = new MySubClass("baza", 5);
        }
    }
}
