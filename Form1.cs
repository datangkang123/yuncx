namespace yuncx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ��ȡusername��password������ֵ  
            string username = usernameinput.Text; // ���������û���TextBox��ΪtextBoxUsername  
            string password = passwordinput.Text; // ������������TextBox��ΪtextBoxPassword  

            // ��������Խ��е�¼��֤�Ȳ���  
            MessageBox.Show($"Username: {username}\nPassword: {password}");
        }
    }
}
