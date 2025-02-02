namespace Zadanie11
{
    public partial class Form1 : Form
    {
        private Queen queen;

        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu"}, 175);
            workers[1] = new Worker(new string[] { "Piel�gnacja jaj", "Nauczyanie pszcz�ek" }, 114);
            workers[2] = new Worker(new string[] { "Utrzymanie ula", "Patrol z ��d�ami" }, 149);
            workers[3] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Piel�gnacja jaj", "Nauczanie pszcz�ek", "Nauczanie pszcz�ek", "Utrzymanie ula", "Patrol z ��d�ami"}, 155);
            queen = new Queen(workers, 275);

        }

        private void workerBeeJob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void shifts_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("Nie ma dost�pnych robotnic do wykonania zadania '" + workerBeeJob.Text + "'", "Kr�lowa pszcz� m�wi...");
            else
                MessageBox.Show("Zadanie '" + workerBeeJob.Text + "' b�dzie uko�czone za " + shifts.Value + " zmiany", "Kr�lowa pszcz� m�wi...");
        }
    }
}
