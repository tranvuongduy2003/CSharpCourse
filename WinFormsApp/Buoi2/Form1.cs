namespace WinFormsApp.Buoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var totalPrice = CalculateTotalPrice();
            this.totalPrice.Text = String.Format("{0:0,0}", totalPrice) + "đ";
            this.promotionTextbox.Text = "0";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private int CalculateTotalPrice()
        {
            var quantity01 = int.Parse(this.itemQuantity01.Text);
            var itemPrice01 = int.Parse(this.itemPrice01.Text.Replace("đ", "").Replace(",", ""));
            var quantity02 = int.Parse(this.itemQuantity02.Text);
            var itemPrice02 = int.Parse(this.itemPrice02.Text.Replace("đ", "").Replace(",", ""));
            var quantity03 = int.Parse(this.itemQuantity03.Text);
            var itemPrice03 = int.Parse(this.itemPrice03.Text.Replace("đ", "").Replace(",", ""));
            var quantity04 = int.Parse(this.itemQuantity04.Text);
            var itemPrice04 = int.Parse(this.itemPrice04.Text.Replace("đ", "").Replace(",", ""));
            var quantity05 = int.Parse(this.itemQuantity05.Text);
            var itemPrice05 = int.Parse(this.itemPrice05.Text.Replace("đ", "").Replace(",", ""));
            var totalPrice = quantity01 * itemPrice01 +
                quantity02 * itemPrice02 +
                quantity03 * itemPrice03 +
                quantity04 * itemPrice04 +
                quantity05 * itemPrice05;
            return totalPrice;
        }

        private void sub01_Click(object sender, EventArgs e)
        {
            var quantity = int.Parse(this.itemQuantity01.Text);
            var itemPrice = int.Parse(this.itemPrice01.Text.Replace("đ", "").Replace(",", ""));
            var totalPrice = CalculateTotalPrice();
            totalPrice = totalPrice - quantity * itemPrice;
            if (quantity > 0)
            {
                quantity -= 1;
            }
            var itemTotalPrice = quantity * itemPrice;
            if (this.promotionTextbox.Text == null || this.promotionTextbox.Text == "")
            {
                this.promotionTextbox.Text = "0";
            }
            var promotionValue = int.Parse(this.promotionTextbox.Text);
            if (promotionValue < 0) promotionValue = 0;
            else if (promotionValue > 100) promotionValue = 100;
            totalPrice += itemTotalPrice;
            totalPrice = totalPrice * (100 - promotionValue) / 100;

            this.totalPrice.Text = String.Format("{0:0,0}", totalPrice) + "đ";

            itemTotalPrice01.Text = String.Format("{0:0,0}", itemTotalPrice) + "đ";

            this.itemQuantity01.Text = quantity.ToString();
        }

        private void add01_Click(object sender, EventArgs e)
        {
            var quantity = int.Parse(this.itemQuantity01.Text);
            var itemPrice = int.Parse(this.itemPrice01.Text.Replace("đ", "").Replace(",", ""));
            var totalPrice = CalculateTotalPrice();
            totalPrice = totalPrice - quantity * itemPrice;
            quantity += 1;
            var itemTotalPrice = quantity * itemPrice;
            if (this.promotionTextbox.Text == null || this.promotionTextbox.Text == "")
            {
                this.promotionTextbox.Text = "0";
            }
            var promotionValue = int.Parse(this.promotionTextbox.Text);
            if (promotionValue < 0) promotionValue = 0;
            else if (promotionValue > 100) promotionValue = 100;
            totalPrice += itemTotalPrice;
            totalPrice = totalPrice * (100 - promotionValue) / 100;

            var strTotalPrice = totalPrice.ToString();
            this.totalPrice.Text = String.Format("{0:0,0}", totalPrice) + "đ";

            itemTotalPrice01.Text = String.Format("{0:0,0}", itemTotalPrice) + "đ";

            this.itemQuantity01.Text = quantity.ToString();
        }

        private void sub02_Click(object sender, EventArgs e)
        {
            var quantity = int.Parse(this.itemQuantity02.Text);
            var itemPrice = int.Parse(this.itemPrice02.Text.Replace("đ", "").Replace(",", ""));
            var totalPrice = CalculateTotalPrice();
            totalPrice = totalPrice - quantity * itemPrice;
            if (quantity > 0)
            {
                quantity -= 1;
            }
            var itemTotalPrice = quantity * itemPrice;
            if (this.promotionTextbox.Text == null || this.promotionTextbox.Text == "")
            {
                this.promotionTextbox.Text = "0";
            }
            var promotionValue = int.Parse(this.promotionTextbox.Text);
            if (promotionValue < 0) promotionValue = 0;
            else if (promotionValue > 100) promotionValue = 100;
            totalPrice += itemTotalPrice;
            totalPrice = totalPrice * (100 - promotionValue) / 100;

            var strTotalPrice = totalPrice.ToString();
            this.totalPrice.Text = String.Format("{0:0,0}", totalPrice) + "đ";

            itemTotalPrice02.Text = String.Format("{0:0,0}", itemTotalPrice) + "đ";

            this.itemQuantity02.Text = quantity.ToString();
        }

        private void add02_Click(object sender, EventArgs e)
        {
            var quantity = int.Parse(this.itemQuantity02.Text);
            var itemPrice = int.Parse(this.itemPrice02.Text.Replace("đ", "").Replace(",", ""));
            var totalPrice = CalculateTotalPrice();
            totalPrice = totalPrice - quantity * itemPrice;
            quantity += 1;
            var itemTotalPrice = quantity * itemPrice;
            if (this.promotionTextbox.Text == null || this.promotionTextbox.Text == "")
            {
                this.promotionTextbox.Text = "0";
            }
            var promotionValue = int.Parse(this.promotionTextbox.Text);
            if (promotionValue < 0) promotionValue = 0;
            else if (promotionValue > 100) promotionValue = 100;
            totalPrice += itemTotalPrice;
            totalPrice = totalPrice * (100 - promotionValue) / 100;

            var strTotalPrice = totalPrice.ToString();
            this.totalPrice.Text = String.Format("{0:0,0}", totalPrice) + "đ";

            itemTotalPrice02.Text = String.Format("{0:0,0}", itemTotalPrice) + "đ";

            this.itemQuantity02.Text = quantity.ToString();
        }

        private void sub03_Click(object sender, EventArgs e)
        {
            var quantity = int.Parse(this.itemQuantity03.Text);
            var itemPrice = int.Parse(this.itemPrice03.Text.Replace("đ", "").Replace(",", ""));
            var totalPrice = CalculateTotalPrice();
            totalPrice = totalPrice - quantity * itemPrice;
            if (quantity > 0)
            {
                quantity -= 1;
            }
            var itemTotalPrice = quantity * itemPrice;
            if (this.promotionTextbox.Text == null || this.promotionTextbox.Text == "")
            {
                this.promotionTextbox.Text = "0";
            }
            var promotionValue = int.Parse(this.promotionTextbox.Text);
            if (promotionValue < 0) promotionValue = 0;
            else if (promotionValue > 100) promotionValue = 100;
            totalPrice += itemTotalPrice;
            totalPrice = totalPrice * (100 - promotionValue) / 100;

            var strTotalPrice = totalPrice.ToString();
            this.totalPrice.Text = String.Format("{0:0,0}", totalPrice) + "đ";

            itemTotalPrice03.Text = String.Format("{0:0,0}", itemTotalPrice) + "đ";

            this.itemQuantity03.Text = quantity.ToString();
        }

        private void add03_Click(object sender, EventArgs e)
        {
            var quantity = int.Parse(this.itemQuantity03.Text);
            var itemPrice = int.Parse(this.itemPrice03.Text.Replace("đ", "").Replace(",", ""));
            var totalPrice = CalculateTotalPrice();
            totalPrice = totalPrice - quantity * itemPrice;
            quantity += 1;
            var itemTotalPrice = quantity * itemPrice;
            if (this.promotionTextbox.Text == null || this.promotionTextbox.Text == "")
            {
                this.promotionTextbox.Text = "0";
            }
            var promotionValue = int.Parse(this.promotionTextbox.Text);
            if (promotionValue < 0) promotionValue = 0;
            else if (promotionValue > 100) promotionValue = 100;
            totalPrice += itemTotalPrice;
            totalPrice = totalPrice * (100 - promotionValue) / 100;

            var strTotalPrice = totalPrice.ToString();
            this.totalPrice.Text = String.Format("{0:0,0}", totalPrice) + "đ";

            itemTotalPrice03.Text = String.Format("{0:0,0}", itemTotalPrice) + "đ";

            this.itemQuantity03.Text = quantity.ToString();
        }

        private void sub04_Click(object sender, EventArgs e)
        {
            var quantity = int.Parse(this.itemQuantity04.Text);
            var itemPrice = int.Parse(this.itemPrice04.Text.Replace("đ", "").Replace(",", ""));
            var totalPrice = CalculateTotalPrice();
            totalPrice = totalPrice - quantity * itemPrice;
            if (quantity > 0)
            {
                quantity -= 1;
            }
            var itemTotalPrice = quantity * itemPrice;
            if (this.promotionTextbox.Text == null || this.promotionTextbox.Text == "")
            {
                this.promotionTextbox.Text = "0";
            }
            var promotionValue = int.Parse(this.promotionTextbox.Text);
            if (promotionValue < 0) promotionValue = 0;
            else if (promotionValue > 100) promotionValue = 100;
            totalPrice += itemTotalPrice;
            totalPrice = totalPrice * (100 - promotionValue) / 100;

            var strTotalPrice = totalPrice.ToString();
            this.totalPrice.Text = String.Format("{0:0,0}", totalPrice) + "đ";

            itemTotalPrice04.Text = String.Format("{0:0,0}", itemTotalPrice) + "đ";

            this.itemQuantity04.Text = quantity.ToString();
        }

        private void add04_Click(object sender, EventArgs e)
        {
            var quantity = int.Parse(this.itemQuantity04.Text);
            var itemPrice = int.Parse(this.itemPrice04.Text.Replace("đ", "").Replace(",", ""));
            var totalPrice = CalculateTotalPrice();
            totalPrice = totalPrice - quantity * itemPrice;
            quantity += 1;
            var itemTotalPrice = quantity * itemPrice;
            if (this.promotionTextbox.Text == null || this.promotionTextbox.Text == "")
            {
                this.promotionTextbox.Text = "0";
            }
            var promotionValue = int.Parse(this.promotionTextbox.Text);
            if (promotionValue < 0) promotionValue = 0;
            else if (promotionValue > 100) promotionValue = 100;
            totalPrice += itemTotalPrice;
            totalPrice = totalPrice * (100 - promotionValue) / 100;

            var strTotalPrice = totalPrice.ToString();
            this.totalPrice.Text = String.Format("{0:0,0}", totalPrice) + "đ";

            itemTotalPrice04.Text = String.Format("{0:0,0}", itemTotalPrice) + "đ";

            this.itemQuantity04.Text = quantity.ToString();
        }

        private void sub05_Click(object sender, EventArgs e)
        {
            var quantity = int.Parse(this.itemQuantity05.Text);
            var itemPrice = int.Parse(this.itemPrice05.Text.Replace("đ", "").Replace(",", ""));
            var totalPrice = CalculateTotalPrice();
            totalPrice = totalPrice - quantity * itemPrice;
            if (quantity > 0)
            {
                quantity -= 1;
            }
            var itemTotalPrice = quantity * itemPrice;
            if (this.promotionTextbox.Text == null || this.promotionTextbox.Text == "")
            {
                this.promotionTextbox.Text = "0";
            }
            var promotionValue = int.Parse(this.promotionTextbox.Text);
            if (promotionValue < 0) promotionValue = 0;
            else if (promotionValue > 100) promotionValue = 100;
            totalPrice += itemTotalPrice;
            totalPrice = totalPrice * (100 - promotionValue) / 100;

            var strTotalPrice = totalPrice.ToString();
            this.totalPrice.Text = String.Format("{0:0,0}", totalPrice) + "đ";

            itemTotalPrice05.Text = String.Format("{0:0,0}", itemTotalPrice) + "đ";

            this.itemQuantity05.Text = quantity.ToString();
        }

        private void add05_Click(object sender, EventArgs e)
        {
            var quantity = int.Parse(this.itemQuantity05.Text);
            var itemPrice = int.Parse(this.itemPrice05.Text.Replace("đ", "").Replace(",", ""));
            var totalPrice = CalculateTotalPrice();
            totalPrice = totalPrice - quantity * itemPrice;
            quantity += 1;
            var itemTotalPrice = quantity * itemPrice;
            if (this.promotionTextbox.Text == null || this.promotionTextbox.Text == "")
            {
                this.promotionTextbox.Text = "0";
            }
            var promotionValue = int.Parse(this.promotionTextbox.Text);
            if (promotionValue < 0) promotionValue = 0;
            else if (promotionValue > 100) promotionValue = 100;
            totalPrice += itemTotalPrice;
            totalPrice = totalPrice * (100 - promotionValue) / 100;

            var strTotalPrice = totalPrice.ToString();
            this.totalPrice.Text = String.Format("{0:0,0}", totalPrice) + "đ";

            itemTotalPrice05.Text = String.Format("{0:0,0}", itemTotalPrice) + "đ";

            this.itemQuantity05.Text = quantity.ToString();
        }

        private void promotionTextbox_TextChanged(object sender, EventArgs e)
        {
            if (this.promotionTextbox.Text == null || this.promotionTextbox.Text == "")
            {
                this.promotionTextbox.Text = "0";
            }
            var promotionValue = int.Parse(this.promotionTextbox.Text);

            if (promotionValue < 0) promotionValue = 0;
            else if (promotionValue > 100) promotionValue = 100;

            var totalPrice = CalculateTotalPrice();

            this.totalPrice.Text = String.Format("{0:0,0}", (totalPrice * (100 - promotionValue) / 100).ToString()) + "đ";

            this.promotionTextbox.Text = promotionValue.ToString();
            promotionLabel.Text = String.Format("{0:0,0}", (totalPrice * promotionValue / 100).ToString()) + "đ";
        }

        private void remove01_Click(object sender, EventArgs e)
        {
            this.item01.Visible = false;
            this.item02.Location = new Point(this.item02.Location.X, this.item02.Location.Y - this.item01.Height);
            this.item03.Location = new Point(this.item03.Location.X, this.item03.Location.Y - this.item02.Height);
            this.item04.Location = new Point(this.item04.Location.X, this.item04.Location.Y - this.item03.Height);
            this.item05.Location = new Point(this.item05.Location.X, this.item05.Location.Y - this.item04.Height);

            var quantity = int.Parse(this.itemQuantity01.Text);
            var itemPrice = int.Parse(this.itemPrice01.Text.Replace("đ", "").Replace(",", ""));
            var totalPrice = CalculateTotalPrice();
            totalPrice = totalPrice - quantity * itemPrice;
            quantity = 0;
            var itemTotalPrice = quantity * itemPrice;
            if (this.promotionTextbox.Text == null || this.promotionTextbox.Text == "")
            {
                this.promotionTextbox.Text = "0";
            }
            var promotionValue = int.Parse(this.promotionTextbox.Text);
            if (promotionValue < 0) promotionValue = 0;
            else if (promotionValue > 100) promotionValue = 100;
            totalPrice += itemTotalPrice;
            totalPrice = totalPrice * (100 - promotionValue) / 100;

            var strTotalPrice = totalPrice.ToString();
            this.totalPrice.Text = String.Format("{0:0,0}", totalPrice) + "đ";
        }

        private void remove02_Click(object sender, EventArgs e)
        {
            this.item02.Visible = false;
            this.item03.Location = new Point(this.item03.Location.X, this.item03.Location.Y - this.item02.Height);
            this.item04.Location = new Point(this.item04.Location.X, this.item04.Location.Y - this.item03.Height);
            this.item05.Location = new Point(this.item05.Location.X, this.item05.Location.Y - this.item04.Height);

            var quantity = int.Parse(this.itemQuantity02.Text);
            var itemPrice = int.Parse(this.itemPrice02.Text.Replace("đ", "").Replace(",", ""));
            var totalPrice = CalculateTotalPrice();
            totalPrice = totalPrice - quantity * itemPrice;
            quantity = 0;
            var itemTotalPrice = quantity * itemPrice;
            if (this.promotionTextbox.Text == null || this.promotionTextbox.Text == "")
            {
                this.promotionTextbox.Text = "0";
            }
            var promotionValue = int.Parse(this.promotionTextbox.Text);
            if (promotionValue < 0) promotionValue = 0;
            else if (promotionValue > 100) promotionValue = 100;
            totalPrice += itemTotalPrice;
            totalPrice = totalPrice * (100 - promotionValue) / 100;

            var strTotalPrice = totalPrice.ToString();
            this.totalPrice.Text = String.Format("{0:0,0}", totalPrice) + "đ";
        }

        private void remove03_Click(object sender, EventArgs e)
        {
            this.item03.Visible = false;
            this.item04.Location = new Point(this.item04.Location.X, this.item04.Location.Y - this.item03.Height);
            this.item05.Location = new Point(this.item05.Location.X, this.item05.Location.Y - this.item04.Height);
            var quantity = int.Parse(this.itemQuantity03.Text);
            var itemPrice = int.Parse(this.itemPrice03.Text.Replace("đ", "").Replace(",", ""));
            var totalPrice = CalculateTotalPrice();
            totalPrice = totalPrice - quantity * itemPrice;
            quantity = 0;
            var itemTotalPrice = quantity * itemPrice;
            if (this.promotionTextbox.Text == null || this.promotionTextbox.Text == "")
            {
                this.promotionTextbox.Text = "0";
            }
            var promotionValue = int.Parse(this.promotionTextbox.Text);
            if (promotionValue < 0) promotionValue = 0;
            else if (promotionValue > 100) promotionValue = 100;
            totalPrice += itemTotalPrice;
            totalPrice = totalPrice * (100 - promotionValue) / 100;

            var strTotalPrice = totalPrice.ToString();
            this.totalPrice.Text = String.Format("{0:0,0}", totalPrice) + "đ";
        }

        private void remove04_Click(object sender, EventArgs e)
        {
            this.item04.Visible = false;
            this.item05.Location = new Point(this.item05.Location.X, this.item05.Location.Y - this.item04.Height);
            var quantity = int.Parse(this.itemQuantity04.Text);
            var itemPrice = int.Parse(this.itemPrice04.Text.Replace("đ", "").Replace(",", ""));
            var totalPrice = CalculateTotalPrice();
            totalPrice = totalPrice - quantity * itemPrice;
            quantity = 0;
            var itemTotalPrice = quantity * itemPrice;
            if (this.promotionTextbox.Text == null || this.promotionTextbox.Text == "")
            {
                this.promotionTextbox.Text = "0";
            }
            var promotionValue = int.Parse(this.promotionTextbox.Text);
            if (promotionValue < 0) promotionValue = 0;
            else if (promotionValue > 100) promotionValue = 100;
            totalPrice += itemTotalPrice;
            totalPrice = totalPrice * (100 - promotionValue) / 100;

            var strTotalPrice = totalPrice.ToString();
            this.totalPrice.Text = String.Format("{0:0,0}", totalPrice) + "đ";
        }

        private void remove05_Click(object sender, EventArgs e)
        {
            this.item05.Visible = false;
            var quantity = int.Parse(this.itemQuantity05.Text);
            var itemPrice = int.Parse(this.itemPrice05.Text.Replace("đ", "").Replace(",", ""));
            var totalPrice = CalculateTotalPrice();
            totalPrice = totalPrice - quantity * itemPrice;
            quantity = 0;
            var itemTotalPrice = quantity * itemPrice;
            if (this.promotionTextbox.Text == null || this.promotionTextbox.Text == "")
            {
                this.promotionTextbox.Text = "0";
            }
            var promotionValue = int.Parse(this.promotionTextbox.Text);
            if (promotionValue < 0) promotionValue = 0;
            else if (promotionValue > 100) promotionValue = 100;
            totalPrice += itemTotalPrice;
            totalPrice = totalPrice * (100 - promotionValue) / 100;

            var strTotalPrice = totalPrice.ToString();
            this.totalPrice.Text = String.Format("{0:0,0}", totalPrice) + "đ";
        }
    }
}
