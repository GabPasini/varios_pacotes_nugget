namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int idenable = 0;
        public Form1()
        {
            InitializeComponent();
            txtId.ReadOnly = true;
            txtId.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
