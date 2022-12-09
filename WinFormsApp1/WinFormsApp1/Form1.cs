namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += button1_Click;
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Ви ввели число {Convert.ToInt32(textBox1.Text)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка");
            }
            
        }
    }
}