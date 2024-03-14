using System.Data;

namespace WinFormsApp.Buoi3
{
    public partial class Form1 : Form
    {
        public int CurrentQuestionNumber { get; set; } = 0;
        public DataTable DataTable { get; set; } = new DataTable();

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnQ1.Click += new EventHandler(btnClick);
            btnQ2.Click += new EventHandler(btnClick);
            btnQ3.Click += new EventHandler(btnClick);
            btnQ4.Click += new EventHandler(btnClick);
            btnQ5.Click += new EventHandler(btnClick);
            btnQ6.Click += new EventHandler(btnClick);
            btnQ7.Click += new EventHandler(btnClick);
            btnQ8.Click += new EventHandler(btnClick);
            btnQ9.Click += new EventHandler(btnClick);
            ResetPanels();
            ResetButtons();
        }

        void btnClick(object sender, EventArgs e)
        {
            ResetButtons();
            Button a = (Button)sender;
            int id = int.Parse(a.Name.Split("btnQ")[1]);
            CurrentQuestionNumber = id;
            labelQuestion.Text = "Question " + id.ToString() + ": ";
            a.BackColor = Color.DeepSkyBlue;

            if (id < 4)
            {
                //radio
                //21, 95
                ResetPanels();
                radioPanel.Visible = true;
                radioPanel.AutoScrollPosition = new Point(21, 95);
                labelRadio.Text = DataTable.Rows[id]["Q"].ToString();
                radioButton1.Text = DataTable.Rows[id]["A"].ToString();
                radioButton2.Text = DataTable.Rows[id]["B"].ToString();
                radioButton3.Text = DataTable.Rows[id]["C"].ToString();
                radioButton4.Text = DataTable.Rows[id]["D"].ToString();
            }
            else if (id < 7)
            {
                //textbox
                ResetPanels();
                textboxPanel.Visible = true;
                textboxPanel.AutoScrollPosition = new Point(21, 95);
                labelTextbox.Text = DataTable.Rows[id]["Q"].ToString();
            }
            else
            {
                //checkbox
                ResetPanels();
                checkboxPanel.Visible = true;
                checkboxPanel.AutoScrollPosition = new Point(21, 95);
                labelCheckbox.Text = DataTable.Rows[id]["Q"].ToString();
                checkBox1.Text = DataTable.Rows[id]["A"].ToString();
                checkBox2.Text = DataTable.Rows[id]["B"].ToString();
                checkBox3.Text = DataTable.Rows[id]["C"].ToString();
                checkBox4.Text = DataTable.Rows[id]["D"].ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ResetButtons();
            switch (CurrentQuestionNumber)
            {
                case 1:
                    btnClick(btnQ1, e);
                    break;
                case 2:
                    btnClick(btnQ2, e);
                    break;
                case 3:
                    btnClick(btnQ3, e);
                    break;
                case 4:
                    btnClick(btnQ4, e);
                    break;
                case 5:
                    btnClick(btnQ5, e);
                    break;
                case 6:
                    btnClick(btnQ6, e);
                    break;
                case 7:
                    btnClick(btnQ7, e);
                    break;
                case 8:
                    btnClick(btnQ8, e);
                    break;
                case 9:
                    btnClick(btnQ9, e);
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnClick(btnQ1, e);
        }

        void ResetButtons()
        {
            btnQ1.BackColor = Color.White;
            btnQ2.BackColor = Color.White;
            btnQ3.BackColor = Color.White;
            btnQ4.BackColor = Color.White;
            btnQ5.BackColor = Color.White;
            btnQ6.BackColor = Color.White;
            btnQ7.BackColor = Color.White;
            btnQ8.BackColor = Color.White;
            btnQ9.BackColor = Color.White;
        }

        void ResetPanels()
        {
            checkboxPanel.Visible = false;
            textboxPanel.Visible = false;
            textboxPanel.Visible = false;
        }

        void LoadData()
        {
            DataTable.Columns.Add("Q", typeof(string));
            DataTable.Columns.Add("A", typeof(string));
            DataTable.Columns.Add("B", typeof(string));
            DataTable.Columns.Add("C", typeof(string));
            DataTable.Columns.Add("D", typeof(string));
            //
            DataTable.Rows.Add("“Just think,............2 years' time, we'll be 20 both.”", "A. under", "B. in", "C. after", "D. over");
            DataTable.Rows.Add("“He couldn’t get back............his car. He had locked himself out.”", "A. on", "B. into", "C. in", "D. to");
            DataTable.Rows.Add("“If I were in charge, I............things differently.”", "A. will do", "B. would do", "C. would have done", "D. had done");
            DataTable.Rows.Add("It  was not  until she  had arrived home............remembered \nher appointment with the doctor.”", "", "", "", "");
            DataTable.Rows.Add("Janet has left home and is............of her parents.”", "", "", "", "");
            DataTable.Rows.Add("He is going to get married............the end of this month.”", "", "", "", "");
            DataTable.Rows.Add("............he did not attend the English class, he knew the lesson\nquite well.", "A. In spite of", "B. However", "C. Although", "D. Despite");
            DataTable.Rows.Add("It’s said that he has............friends of his age.", "A. few", "B. plenty", "C. a little", "D. little");
            DataTable.Rows.Add("He’s a very............person because he can make other workers \nfollow his advice.", "A. creative", "B. influential", "C. deciding", "D. effective");
        }
    }
}
