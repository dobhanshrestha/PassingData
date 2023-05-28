namespace PassingData
{
    public partial class Form1 : Form
    {
        public static string Text1;
        public static string Text2;
        public static string Text3;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text1 = textBox1.Text;
            Text2 = textBox2.Text;
            Text3 = textBox3.Text;

            Form2 f2 = new Form2();
                f2.Show();
            }



            private void textBox1_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Fill the First Name!!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox3.Text) == true)
            {
                textBox3.Focus();
                errorProvider2.SetError(this.textBox3, "Fill the Last Name!!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
    }
}