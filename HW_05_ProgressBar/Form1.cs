namespace HW_05_ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GoText(object sender, EventArgs e)
        {
            int numberProgress = 0;
         

            if (textBox1.Text != "")
            {
                numberProgress += 25;
            }
            if (textBox2.Text != "")
            {
                numberProgress += 25;
            }
            if (textBox3.Text != "")
            {
                numberProgress += 25;
            }
            if (textBox4.Text != "")
            {
                numberProgress += 25;
            }
            progressBar1.Value = numberProgress;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                MessageBox.Show($"Ім'я: {textBox1.Text} --> Прізвище: {textBox2.Text}  -->  Рід зайнятості: {textBox3.Text} --> Хочу машину: {textBox4.Text}");
            }
            else
            {
                MessageBox.Show("Не залишайте поля пустими!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}