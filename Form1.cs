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
            // 获取username和password的输入值  
            string username = usernameinput.Text; // 假设您的用户名TextBox名为textBoxUsername  
            string password = passwordinput.Text; // 假设您的密码TextBox名为textBoxPassword  

            // 在这里可以进行登录验证等操作  
            MessageBox.Show($"Username: {username}\nPassword: {password}");
        }
    }
}
