using System.Net.Http.Headers;

namespace Zadanie7
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty() { NumberOfPeople = 5 };
            dinnerParty.CalculateCostOfDecorations(false);
            dinnerParty.SetHealthyOption(true);
            DisplayDinnerPartyCost();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healthyBox.Checked);
            costLabel.Text = Cost.ToString("c");
        }
    }
}
