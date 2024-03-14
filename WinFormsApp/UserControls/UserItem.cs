namespace WinFormsApp.UserControls
{
    public partial class UserItem : UserControl
    {
        public UserItem()
        {
            InitializeComponent();
        }

        public int userId;

        public void LoadData(int ID, Image ava, Image onoff, string name, string text)
        {
            userId = ID;
            pictureBox4.BackgroundImage = ava;
            label5.Text = name;
            label4.Text = text;
            pictureBox5.BackgroundImage = onoff;
        }
    }
}
