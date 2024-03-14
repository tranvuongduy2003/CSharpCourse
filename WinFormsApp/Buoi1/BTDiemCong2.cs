using System.Data;
using WinFormsApp.UserControls;

namespace WinFormsApp.Buoi1
{
    public partial class BTDiemCong2 : Form
    {
        DataTable dt = null;

        public BTDiemCong2()
        {
            InitializeComponent();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTDiemCong2_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("ava", typeof(Image));
            dt.Columns.Add("online", typeof(Image));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("text", typeof(string));
            dt.Rows.Add(1, Image.FromFile("Chat\\ava01.png"), global::WinFormsApp.Properties.Resources.on, "Bảo Anh", "Online");
            dt.Rows.Add(2, Image.FromFile("Chat\\ava02.png"), global::WinFormsApp.Properties.Resources.on, "Huỳnh Trâm", "Chào ngày mới!");
            dt.Rows.Add(3, Image.FromFile("Chat\\ava03.png"), global::WinFormsApp.Properties.Resources.off, "Tùng Dương", "Offline");
            dt.Rows.Add(4, Image.FromFile("Chat\\ava04.png"), global::WinFormsApp.Properties.Resources.on, "Minh Lan", "Rộn ràng");
            dt.Rows.Add(5, Image.FromFile("Chat\\ava05.png"), global::WinFormsApp.Properties.Resources.on, "Tuấn Hưng", "Vừa xong");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoadUser(i);
            }
        }

        int yy = 10;

        void LoadUser(int id)
        {
            UserItem user = new UserItem();
            user.LoadData(
                (int)dt.Rows[id]["ID"],
                (Image)dt.Rows[id]["ava"],
                (Image)dt.Rows[id]["online"],
                (string)dt.Rows[id]["name"],
                (string)dt.Rows[id]["text"]
            );

            user.Click += new EventHandler(UserItemClick);
            panel2.Controls.Add(user);
            user.Location = new System.Drawing.Point(11, yy);

            yy += 100;
        }

        private void UserItemClick(object sender, EventArgs e)
        {
            UserItem user = (UserItem)sender;
            string text = "ID=" + user.userId.ToString();
            foreach (DataRow dr in dt.Select(text))
            {
                currentUserAvt.BackgroundImage = (Image)dr["ava"];
                currentUserName.Text = (string)dr["name"];
                currentUserText.Text = (string)dr["text"];
                currentUserStatus.BackgroundImage = (Image)dr["online"];
            }
        }
    }
}
