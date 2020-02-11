using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CarInventoryManagement;

namespace CarInventoryManagement
{
    
    public partial class AutoForm : Form
    {
        public AutoForm()
        {
            InitializeComponent();
        }
        
        internal static decimal total = 0;
        private void commercialPb_Click(object sender, EventArgs e)
        {

        }
        internal int counter = 0;
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AutoForm_Load(object sender, EventArgs e)
        {

            //Метод за зареждане на Категориите
            try
            {
                Auto.categoryList = File.ReadAllLines("category.txt").ToList();
                foreach (string line in Auto.categoryList)
                {
                    //Създава бутон за всяка нова категория
                    Button b = new Button();
                    b.BackColor = Color.Maroon;
                    b.Size = new Size(207, 33);
                    b.Text = line;
                    b.Click += delegate
                    {
                        categoryFlp.Focus();
                        foreach (Button btn in categoryFlp.Controls)
                        {
                            btn.BackColor = Color.Maroon;


                        }
                        chooseCateg(partsFlp, b, Auto.autos);
                    };
                    b.MouseEnter += delegate
                    {
                        categoryFlp.Focus();
                    };
                    categoryFlp.Controls.Add(b);
                }
            }
            catch { MessageBox.Show("Данните заредени!"); }

            try
            {
                if (!File.Exists("")) ;
            }
            catch
            {
                MessageBox.Show("Файла не съществува");
            }
            //Зареждане на обявите

            //Зареждане на продуктите 

            Auto.readAutoParts();
            foreach (KeyValuePair<string, Products> kvp in Auto.autos)
            {
              
                Create(kvp.Value.Name, kvp.Value.Category, kvp.Value.Quantity, kvp.Value.Price.ToString(), kvp.Value.PicPath, 
                    categoryFlp, partsFlp, cartFlp,Auto.autos, cartLabel, kvp.Value.Category, totalPriceL,totalPriceIncVatL, searchTextBox, panel1);
            }

        }
        public static void addToCart(FlowLayoutPanel cartFlp, Button b, Label totalPriceLabel, Label cartLabel, FlowLayoutPanel itemFlp)
        {
            decimal total = 0;

            Products autopart;
            Control p = b.Parent;
            string nameofitem = p.Name;
            Auto.autos.TryGetValue(nameofitem, out autopart);
            Label name = new Label();
            Label price = new Label();
            PictureBox picbox = new PictureBox();
            Button del = new Button();
            NumericUpDown quantities = new NumericUpDown();

            name.Text = p.Name;
            price.Text = autopart.Price.ToString();

            total += decimal.Parse(price.Text);

            //PicBox Property
            picbox.Size = new Size(174, 156);
            picbox.BackgroundImage = Image.FromFile(autopart.PicPath);
            picbox.BackgroundImageLayout = ImageLayout.Stretch;

            name.Location = new Point(190, 47);
            name.Font = new Font("Microsoft Sans Serif", 23);
            price.Font = new Font("Microsoft Sans Serif", 23);

            price.Location = new Point(389, 43);
            picbox.Location = new Point(17, 7);
            picbox.Size = new Size(139, 99);
            del.Location = new Point(698, 40);
            quantities.Location = new Point(607, 43);
            quantities.Font = new Font("Microsoft Sans Serif", 23);
            autopart.Quantity = (int)quantities.Value;
            quantities.Value = 1;
            int before, after;
            before = (int)quantities.Value;
            quantities.Click += delegate
            {
                after = (int)quantities.Value;
                if (before < after)
                {
                    total += decimal.Parse((autopart.Price).ToString());
                    totalPriceLabel.Text = total.ToString();
                }
                else if (after < before)
                {
                    int number = (int)quantities.Value;

                    total -= decimal.Parse((autopart.Price).ToString());
                    totalPriceLabel.Text = total.ToString();

                }
                before = after;
            };

            del.Size = new Size(40, 29);
            del.Text = "X";
            del.Click += delegate
            {
                string nameofpart = p.Name;
                Auto.autos.TryGetValue(nameofpart, out autopart);
                cartFlp.Controls.Remove(p);
                Auto.bought.Remove(p.Name);
                foreach (Panel i in cartFlp.Controls)
                {
                    if (i.Name == p.Name)
                    {
                        Point pt = new Point(198, 126);
                        i.GetChildAtPoint(pt).Text = "Добави в количката";
                    }
                }

                int decrement = int.Parse(cartLabel.Text);
                decrement--;
                cartLabel.Text.ToString();


                total -= autopart.Price;


            };
            Panel panelcart;
            panelcart = new Panel();
            panelcart.Name = p.Name;
            panelcart.Margin = new Padding(3, 3, 3, 3);
            panelcart.BackColor = Color.LightGray; ;
            panelcart.Size = new Size(1260, 115);
            panelcart.Location = new Point(3, 3);


            panelcart.Controls.Add(name);
            panelcart.Controls.Add(price);
            panelcart.Controls.Add(picbox);
            panelcart.Controls.Add(del);
            panelcart.Controls.Add(quantities);
            cartFlp.Controls.Add(panelcart);
            Auto.bought[p.Name] = (Auto)autopart;
        }

        static void chooseCateg(FlowLayoutPanel flp, Control b, Dictionary<string, Products> autoparts)
        {

            if (b.Text == "Всички")
            {
                //Показва всички продукти вдига p.Visible = true;
                foreach (Panel p in flp.Controls)
                    if (p.BackColor == Color.LightGray)
                        p.Visible = true;
            }
            else
            {
                //Лист който вкарва имената на продуктите в категории.
                List<string> extra = new List<string>();
                //Обхождане на колекцията 
                //autoparts колекция тип Dictionary
                foreach (KeyValuePair<string, Products> kvp in autoparts)
                {
                    if (kvp.Value.Category.ToLower() == b.Text.ToLower())
                    {
                        extra.Add(kvp.Key.ToLower());
                    }
                }
                //обхождане на елементите авточасти Auto();
                foreach (Panel p in flp.Controls)
                {
                    //Проверка дали притежавам елемент от категорията;
                    if (p.BackColor == Color.LightGray)
                    {
                        if (extra.Contains(p.Name.ToLower()))
                            p.Visible = true;
                        else
                            p.Visible = false;
                    }
                }
            }
        }

        private void commercialPb_Click_1(object sender, EventArgs e)
        {

        }

        private void editCategory_Click(object sender, EventArgs e)
        {
            addCategoryForm categoryForm = new addCategoryForm();
            categoryForm.Show();
        }

        private void categoryFlp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            this.Close();
            addAutoPartsForm addparts = new addAutoPartsForm();
            addparts.Show();

        }
        //Зареждане на Панела с данните от Обекта
       static void Create(string name, string category, int quantity, string price, string PicPath, FlowLayoutPanel categoryFlp, FlowLayoutPanel partsFlp, FlowLayoutPanel CartFlp,
       Dictionary<string, Products> autos, Label cartLabel, string categories, Label totalpriceL,Label TotalVatprice, TextBox searchTextBox, Panel panel1)
        {
            // Пропъртита ма Панел
            Panel p = new Panel();
            p.Margin = new Padding(2, 2, 2, 2);
            p.BackColor = Color.LightGray; ;
            p.Size = new Size(342, 186);
            p.Name = name;

            partsFlp.Controls.Add(p);
            Button B = new Button();
            foreach (Button btn in categoryFlp.Controls)
            {
                if (btn.BackColor == Color.Maroon)
                    B = btn;
            }
            if ((B.Text == categories || B.Text == "Всички") && (p.Name.Contains(searchTextBox.Text) || searchTextBox.Text == "Търсене"))
            {
                p.Visible = true;
            }
            else
                p.Visible = false;

            //Пропъртита за кутията на изображението
            PictureBox pb = new PictureBox();
            pb.Size = new Size(174, 156);
            pb.Location = new Point(13, 15);
            pb.BackgroundImage = Image.FromFile(PicPath);
            pb.BackgroundImageLayout = ImageLayout.Stretch;


            p.Controls.Add(pb);

            //Пропъртита за Името(label)
            Label lName;
            lName = new Label();
            lName.Text = "Име:" + name;
            lName.Font = new Font("Microsoft Sans Serif", 11);
            lName.AutoSize = true;
            lName.Location = new Point(193, 22);
            p.Controls.Add(lName);


            //Пропъртита за Цената(label)
            Label lPrice;
            lPrice = new Label();
            lPrice.Text = "Цена: " + price + "лева";
            lPrice.Font = new Font("Microsoft Sans Serif", 10);
            lPrice.AutoSize = true;
            lPrice.Location = new Point(193, 59);
            p.Controls.Add(lPrice);

            //Пропъртита за Количеството (label)
            Label Lquantity;
            Lquantity = new Label();
            Lquantity.Text = quantity + "броя";
            Lquantity.AutoSize = true;
            Lquantity.Location = new Point(193, 101);
            p.Controls.Add(Lquantity);

            // Пропъртита за бутон INFObtn
            Button infoBtn = new Button();
            infoBtn.Size = new Size(141, 27);
            infoBtn.Location = new Point(198, 75);
            infoBtn.BackColor = Color.Black;
            infoBtn.ForeColor = Color.White;
            infoBtn.Font = new Font("Microsoft Sans Serif", 8);


            infoBtn.Text = "Информация за продукта";

            infoBtn.Click += delegate
        {

            foreach (KeyValuePair<string, Products> kvp in autos)
            {

                MessageBox.Show("ОБщата сума на авточастите с включено ДДС 20% е:" + kvp.Value.CalculateVat(quantity, decimal.Parse(price)) + "лева");
                MessageBox.Show(kvp.Value.getProductNFO());
                MessageBox.Show("Oбщата сума на частта без ддс е:" + kvp.Value.Sum(quantity, decimal.Parse(price)).ToString()+"лева");
                    //Излизам от цикъла иначе ще продължава да показва елементите докато не обходи цели броя елементи
                    break;
            }




        };
            p.Controls.Add(infoBtn);
            //Пропъртита за бутон добави в количка
            Button buttoncart = new Button();
            buttoncart.Size = new Size(127, 36);
            buttoncart.Location = new Point(200, 120);
            buttoncart.Text = "Добави в количката";
            buttoncart.Font = new Font(buttoncart.Font, FontStyle.Bold);
            buttoncart.FlatAppearance.MouseOverBackColor = Color.Tomato;
            buttoncart.FlatAppearance.MouseDownBackColor = Color.Salmon;
            buttoncart.BackColor = Color.OrangeRed;
            buttoncart.FlatAppearance.BorderSize = 0;
            buttoncart.FlatStyle = FlatStyle.Flat;
            buttoncart.ForeColor = SystemColors.ControlLightLight;
            buttoncart.Cursor = Cursors.Hand;
            buttoncart.Click += delegate
            {
                //Проверка дали текста на бутона съответства с този в if case
                if (buttoncart.Text == "Добави в количката")
                {
                    int x = int.Parse(cartLabel.Text);
                    x++;
                    cartLabel.Text = x.ToString();
                    //Cart Edit
                    addToCart(CartFlp, buttoncart, totalpriceL,TotalVatprice, cartLabel, partsFlp);

                    //Промяна на Текста на бутона щом условието е изпълнено
                    buttoncart.Text = "E добавен";
                }

            };

            p.Controls.Add(buttoncart);

            //Пропъртита за бутон Изтрии
            Button deleteButton = new Button();
            deleteButton.Font = new Font("Cambria", 6);
            deleteButton.Size = new Size(28, 16);
            deleteButton.Location = new Point(311, 2);
            deleteButton.Text = "X";
            deleteButton.BackColor = Color.Black;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.ForeColor = SystemColors.ControlLightLight;
            deleteButton.Cursor = Cursors.Hand;

            deleteButton.Visible = true;

            deleteButton.Click += delegate
            {
                autos.Remove(deleteButton.Parent.Name);
                partsFlp.Controls.Remove(deleteButton.Parent);
                using (StreamWriter write = new StreamWriter("autoparts.txt"))
                {
                    foreach (KeyValuePair<string, Products> kvp in autos)
                    {
                        write.WriteLine(kvp.Value.Name.ToString() + "," + kvp.Value.Category + "," + kvp.Value.Quantity.ToString() + "," + kvp.Value.Price.ToString() + "," + kvp.Value.PicPath);
                    }
                }
            };
            p.Controls.Add(deleteButton);

          

            Button B2 = new Button();//Zy int x

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void partsFlp_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void All_Click(object sender, EventArgs e)
        {
            partsFlp.Focus();
            foreach (Button btn in categoryFlp.Controls)
            {
                btn.BackColor = Color.Maroon;
            }

            chooseCateg(partsFlp, All, Auto.autos);
        }

       public static void addToCart(FlowLayoutPanel cartFlp, Button b, Label totalPriceLabel,Label totalVatPriceLabel, Label cartLabel, FlowLayoutPanel autopartsflp)
        {
           
            Products autopart;
            Control p = b.Parent;
            string nameofitem = p.Name;
            Auto.autos.TryGetValue(nameofitem, out autopart);
            Label name = new Label();
            Label price = new Label();
            PictureBox picbox = new PictureBox();
           
            NumericUpDown quantyties = new NumericUpDown();
            int max = autopart.Quantity;
           
         
           

            name.Text = p.Name;
            price.Text = autopart.Price.ToString();
            totalPriceLabel.Text = total.ToString();
            picbox.Size = new Size(174, 156);
            picbox.BackgroundImage = Image.FromFile(autopart.PicPath);
            picbox.BackgroundImageLayout = ImageLayout.Stretch;
            name.Location = new Point(190, 47);
            name.Font = new Font("Microsoft Sans Serif", 18);
            price.Font = new Font("Microsoft Sans Serif", 18);

            price.Location = new Point(380, 47);
            picbox.Location = new Point(17, 7);
            picbox.Size = new Size(174, 156);
            quantyties.Location = new Point(486, 47);
            quantyties.Maximum = max;
            autopart.Quantity = (int)quantyties.Value;
            quantyties.Value = 0;
            decimal vat = 20;
            int before, after;
            before = (int)quantyties.Value;
            quantyties.Click += delegate
            {
                after = (int)quantyties.Value;
                if (before < after)
                {
                    int number = (int)quantyties.Value;

                    total += decimal.Parse((autopart.Price).ToString());
                    totalPriceLabel.Text = total.ToString();
                    totalVatPriceLabel.Text = (((total * vat) / 100) + total).ToString();
                }
                else if (after < before)
                {
                    int number = (int)quantyties.Value;

                    total -= decimal.Parse((autopart.Price).ToString());
                    totalPriceLabel.Text = total.ToString();
                    totalVatPriceLabel.Text = (((total * vat) / 100) + total).ToString();


                }
                before = after;
               
            };
            Panel panelcart;
            panelcart = new Panel();
            panelcart.Name = p.Name;
            panelcart.Margin = new Padding(3, 3, 3, 3);
            panelcart.BackColor = Color.LightGray; ;
            panelcart.Size = new Size(757, 124);
            panelcart.Location = new Point(3, 3);


            panelcart.Controls.Add(name);
            panelcart.Controls.Add(price);
            panelcart.Controls.Add(picbox);
            panelcart.Controls.Add(quantyties);
            cartFlp.Controls.Add(panelcart);
            Auto.bought[p.Name] = (Auto)autopart;
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Button b = null;
            foreach (Button btn in categoryFlp.Controls)
            {
                if (btn.BackColor == Color.Maroon)

                    b = btn;
            }
            if ((searchTextBox.Text == "Tърсене") || searchTextBox.Text == "")
            {
                chooseCateg(partsFlp, b, Auto.autos);
            }
            else
            {
                panel1.VerticalScroll.Value = 209;
                List<string> extra = new List<string>();
                foreach (KeyValuePair<string, Products> kvp in Auto.autos)
                {
                    if (kvp.Value.Category.ToLower() == b.Text.ToLower() && kvp.Value.Name.ToLower().Contains(searchTextBox.Text.ToLower()) && b.Text != "Всички")
                    {
                        extra.Add(kvp.Key.ToLower());
                    }
                    else if (b.Text == "Всички" && kvp.Value.Name.ToLower().Contains(searchTextBox.Text.ToLower()))
                        extra.Add(kvp.Value.Name.ToLower());
                }
                foreach (Panel p in partsFlp.Controls)
                {
                    if (p.BackColor == Color.Maroon)
                    {
                        if (extra.Contains(p.Name.ToLower()))
                            p.Visible = true;
                        else
                            p.Visible = false;
                    }
                }
            }
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Търсене")
            {
                searchTextBox.Text = "";
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {

            if (searchTextBox.Text == "")
            {
                searchTextBox.Text = "Tърсене";
            }
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(cartTP);
            MessageBox.Show("Вие отворихте прозорец количка");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cartFlp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tърсенете завърши!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter("Cart.txt");
                writer.Write(",");

                foreach (var map in Auto.bought) //check this
                {
                    writer.WriteLine(map.Value.Name + "," + map.Value.Category + "," + map.Value.Quantity.ToString() + "," + map.Value.Price.ToString() + "," + map.Value.PicPath);
                }
                writer.Close();

                foreach (Control p in cartFlp.Controls)//delete the cart.
                {
                    if (p is Panel)
                        cartFlp.Controls.Remove(p);
                }
                cartLabel.Text = "0";
                totalPriceL.Text = "0";
             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            this.Close();
        }

        private void totalPriceL_Click(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void cartTP_Click(object sender, EventArgs e)
        {

        }

        private void totalPriceIncVatL_Click(object sender, EventArgs e)
        {

        }
    }
}