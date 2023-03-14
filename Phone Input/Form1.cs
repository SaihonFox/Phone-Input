namespace Phone_Input
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void randomButton_Click(object sender, EventArgs e) => randomTextBox.Text = "+79" + new Random().Next(100000000, 999999999 + 1);
    }
}