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
            progressBar1.Value = 0;

            if (textBox1.Text != "")
            {
                progressBar1.Value += 25;
            }
            if (textBox2.Text != "")
            {
                progressBar1.Value += 25;
            }
            if (textBox3.Text != "")
            {
                progressBar1.Value += 25;
            }
            if (textBox4.Text != "")
            {
                progressBar1.Value += 25;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                MessageBox.Show($"��'�: {textBox1.Text} --> �������: {textBox2.Text}  -->  г� ���������: {textBox3.Text} --> ���� ������: {textBox4.Text}");
            }
            else
            {
                MessageBox.Show("�� ��������� ���� �������!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}