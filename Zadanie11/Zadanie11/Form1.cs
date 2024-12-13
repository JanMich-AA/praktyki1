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
            workers[1] = new Worker(new string[] { "Pielêgnacja jaj", "Nauczyanie pszczó³ek" }, 114);
            workers[2] = new Worker(new string[] { "Utrzymanie ula", "Patrol z ¿¹d³ami" }, 149);
            workers[3] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Pielêgnacja jaj", "Nauczanie pszczó³ek", "Nauczanie pszczó³ek", "Utrzymanie ula", "Patrol z ¿¹d³ami"}, 155);
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
                MessageBox.Show("Nie ma dostêpnych robotnic do wykonania zadania '" + workerBeeJob.Text + "'", "Królowa pszczó³ mówi...");
            else
                MessageBox.Show("Zadanie '" + workerBeeJob.Text + "' bêdzie ukoñczone za " + shifts.Value + " zmiany", "Królowa pszczó³ mówi...");
        }
    }
}
