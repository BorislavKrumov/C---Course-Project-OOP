using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using ClassLibrary2;

namespace CarInventoryManagement.Forms.Accessories
{
    public partial class accessoriesHomeForm : Form
    {
        public accessoriesHomeForm()
        {
            
            InitializeComponent();
        }
        internal static decimal total = 0;
        internal decimal totalwithVat = 0;
      
        private void accessoriesHomeForm_Load(object sender, EventArgs e)
        {
            //Прочита и зарежда бутоните категории
            try
            {
                
                AutoAccessoires.categoryAccesoires = File.ReadAllLines("categoryAccessoires.txt").ToList();
                foreach (string line in AutoAccessoires.categoryAccesoires)
                {
                    //Създава бутон за всяка нова категория
                    Button b = new Button();
                    b.BackColor = Color.Tomato;
                    b.Size = new Size(179, 42);
                    b.Text = line;
                    b.Click += delegate
                    {
                        accessoiresFlp.Focus();
                        foreach (Button btn in categoryAFlp.Controls)
                        {
                            btn.BackColor = Color.Tomato;


                        }
                        chooseCateg(accessoiresFlp, b, AutoAccessoires.accessoires);
                    };
                    b.MouseEnter += delegate
                    {
                        categoryAFlp.Focus();
                    };
                    categoryAFlp.Controls.Add(b);
                }
            }
            catch { MessageBox.Show("Данните заредени!"); }

            AutoAccessoires.Read();
            foreach (KeyValuePair<string, Products> kvp in AutoAccessoires.accessoires)
            {
                Create(kvp.Value.Name, kvp.Value.Category, kvp.Value.Quantity, kvp.Value.Price.ToString(), kvp.Value.PicPath, kvp.Value.Brand, kvp.Value.Description, kvp.Value.Dealer, categoryAFlp, accessoiresFlp, cartAccFlp, AutoAccessoires.accessoires, cartLabel, kvp.Value.Category, totalAVatL, TotalAprice, searchTextBox, panel1);
            }
            //Функции с Linq

            CountObject(AutoAccessoires.accessoires, label19);
            MostExpensiveProduct(AutoAccessoires.accessoires, label22);
            CheapestProduct(AutoAccessoires.accessoires, label23);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            accessoriesCategoryAddForm form = new accessoriesCategoryAddForm();
            form.Show();
        }

        private void accessoiresFlp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //Методи
        internal static void Create(string name, string category, int quantity, string price, string PicPath, string _Brand, string _Model, string _Vendor, FlowLayoutPanel categoryFlp, FlowLayoutPanel partsFlp, FlowLayoutPanel CartFlp,
   Dictionary<string, Products> Accs, Label cartLabel, string categories, Label totalpriceL, Label totalPriceVat, TextBox searchTextBox, Panel panel1)
        {
            // Пропъртита на Панел
            Panel p = new Panel();
            p.Margin = new Padding(3, 3, 3, 3);
            p.BackColor = Color.LightGray; ;
            p.Size = new Size(340, 230);
            p.Name = name;

            partsFlp.Controls.Add(p);
            Button B = new Button();
            foreach (Button btn in categoryFlp.Controls)
            {
                if (btn.BackColor == Color.Tomato)
                    B = btn;
            }
            if ((B.Text == categories || B.Text == "Всички") && (p.Name.Contains(searchTextBox.Text) || searchTextBox.Text == "Търсене"))
            {
                //Вдига флаг true който показва всички елементи
                p.Visible = true;
            }
            else
                //Когато е вдигнат флаг false,елементите не се показват.
                p.Visible = false;

            //Пропъртита за кутията на изображението
            PictureBox pb = new PictureBox();
            pb.Size = new Size(150, 146);
            pb.Location = new Point(3, 3);
            pb.BackgroundImage = Image.FromFile(PicPath);
            pb.BackgroundImageLayout = ImageLayout.Stretch;


            p.Controls.Add(pb);

            //Пропъртита за Името(label)
            Label lName;
            lName = new Label();
            lName.Text = "Име:" + name;
            lName.Font = new Font("Microsoft Sans Serif", 11);
            lName.AutoSize = true;
            lName.Location = new Point(162, 14);
            p.Controls.Add(lName);


            //Пропъртита за Цената(label)
            Label lPrice;
            lPrice = new Label();
            lPrice.Text = "Цена: " + price + "лева";
            lPrice.Font = new Font("Microsoft Sans Serif", 10);
            lPrice.AutoSize = true;
            lPrice.Location = new Point(162, 44);
            p.Controls.Add(lPrice);

            //Пропъртита за Количеството (label)
            Label Lquantity;
            Lquantity = new Label();
            Lquantity.Text = quantity + "броя";
            Lquantity.AutoSize = true;
            Lquantity.Location = new Point(162, 73);
            p.Controls.Add(Lquantity);

            //Пропъртита за марка (label)
            Label Lbrand;
            Lbrand = new Label();
            Lbrand.Text = "Марка: " + _Brand;
            Lbrand.AutoSize = true;
            Lbrand.Location = new Point(162, 100);
            p.Controls.Add(Lbrand);


            //Пропъртита за модел (label)
            Label Lmodel;
            Lmodel = new Label();
            Lmodel.Text = "Модел: " + _Model;
            Lmodel.AutoSize = true;
            Lmodel.Location = new Point(162, 125);
            p.Controls.Add(Lmodel);


            //Пропъртита за Вносител (label)
            Label Lvendor;
            Lvendor = new Label();
            Lvendor.Text = "Вносител: " + _Vendor + " ООД";
            Lvendor.AutoSize = true;
            Lvendor.Location = new Point(162, 150);
            p.Controls.Add(Lvendor);

            // Пропъртита за бутон INFObtn
            Button infoBtn = new Button();
            infoBtn.Size = new Size(157, 29);
            infoBtn.Location = new Point(152, 178);
            infoBtn.BackColor = Color.Black;
            infoBtn.ForeColor = Color.White;
            infoBtn.Font = new Font("Microsoft Sans Serif", 8);


            infoBtn.Text = "Информация за продукта";

            infoBtn.Click += delegate
            {

                foreach (KeyValuePair<string, Products> kvp in Accs)
                {
                    MessageBox.Show("Общата сумата на аксесоарите с включено ДДС 15% е:" + kvp.Value.CalculateVat(quantity, decimal.Parse(price)) + "лева");
                    //Полиморфизъм
                    MessageBox.Show(kvp.Value.getProductNFO());
                    MessageBox.Show("Oбщата сума на аксесоарите без ддс е:" + kvp.Value.Sum(quantity, decimal.Parse(price)).ToString() + "лева");
                    //Излизам от цикъла иначе ще продължава да показва елементите докато не обходи всички елементи
                    break;
                }




            };
            p.Controls.Add(infoBtn);

            //Пропъртита за бутон добави в количка
            Button buttoncart = new Button();
            buttoncart.Size = new Size(140, 29);
            buttoncart.Location = new Point(2, 178);
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
                    addToCart(CartFlp, buttoncart, totalpriceL, totalPriceVat, cartLabel, partsFlp);

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
                Accs.Remove(deleteButton.Parent.Name);
                partsFlp.Controls.Remove(deleteButton.Parent);
                using (StreamWriter write = new StreamWriter("accessoires.txt"))
                {
                    foreach (KeyValuePair<string, Products> kvp in Accs)
                    {
                        write.WriteLine(kvp.Value.Name.ToString() + "," + kvp.Value.Category + "," + kvp.Value.Quantity.ToString() + "," + kvp.Value.Price.ToString() + "," + kvp.Value.PicPath);
                    }
                }
            };
            p.Controls.Add(deleteButton);

            
            Button B2 = new Button();

        }



        public static void addToCart(FlowLayoutPanel cartAFlp, Button b, Label TotalPriceVat, Label totalAPriceLabel, Label cartALabel, FlowLayoutPanel AccFlp)
        {

            Products accessoires;
            Control p = b.Parent;
            string nameofitem = p.Name;
            AutoAccessoires.accessoires.TryGetValue(nameofitem, out accessoires);
            Label name = new Label();
            Label Lname = new Label();

            Label price = new Label();
            Label Lprice = new Label();

            Label model = new Label();
            Label Lmodel = new Label();

            Label brand = new Label();
            Label Lbrand = new Label();

            Label vendor = new Label();
            Label Lvendor = new Label();

            PictureBox picbox = new PictureBox();

            NumericUpDown quantyties = new NumericUpDown();
            Label Lquantity = new Label();
            int max = accessoires.Quantity;



            //Име
            name.Text = "Име";
            name.Location = new Point(165, 3);
            name.Font = new Font("Microsoft Sans Serif", 13);
            name.Size = new Size(57, 24);
            //Lname
            Lname.Text = p.Name;
            Lname.Location = new Point(229, 7);
            Lname.Size = new Size(68, 22);
            Lname.Font = new Font("Microsoft Sans Serif", 13);

            //Total Price



            //Maрка label

            Lbrand.AutoSize = true;
            Lbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Lbrand.Location = new System.Drawing.Point(165, 38);
            Lbrand.Size = new System.Drawing.Size(57, 18);
            Lbrand.TabIndex = 4;
            Lbrand.Text = "Марка:";

            brand.Text = accessoires.Brand.ToString();
            brand.AutoSize = true;
            brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            brand.Location = new System.Drawing.Point(228, 40);
            brand.Size = new System.Drawing.Size(54, 17);
            brand.TabIndex = 9;


            //Model label
            Lmodel.AutoSize = true;
            Lmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Lmodel.Location = new System.Drawing.Point(166, 75);
            Lmodel.Size = new System.Drawing.Size(60, 18);
            Lmodel.TabIndex = 2;
            Lmodel.Text = "Модел:";

            //Модел
            model.Text = accessoires.Description.ToString();
            model.AutoSize = true;
            model.Location = new System.Drawing.Point(229, 79);
            model.Size = new System.Drawing.Size(41, 13);
            model.TabIndex = 10;

            // 
            //ВНосител
            vendor.Text = accessoires.Dealer.ToString();
            vendor.AutoSize = true;
            vendor.Location = new System.Drawing.Point(569, 12);
            vendor.Size = new System.Drawing.Size(41, 13);
            vendor.TabIndex = 11;

            //vendor label
            Lvendor.AutoSize = true;
            Lvendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Lvendor.Location = new System.Drawing.Point(472, 7);
            Lvendor.Name = "label12";
            Lvendor.Size = new System.Drawing.Size(91, 20);
            Lvendor.TabIndex = 5;
            Lvendor.Text = "Вносител: ";
            //Price
            price.Location = new Point(809, 75);
            price.Size = new Size(75, 26);
            price.AutoSize = true;
            price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            price.Location = new System.Drawing.Point(890, 75);
            price.Size = new System.Drawing.Size(24, 26);
            price.TabIndex = 12;
            price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            price.Text = accessoires.Price.ToString();
            // 
            //Price Label
            Lprice.AutoSize = true;
            Lprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Lprice.Location = new System.Drawing.Point(809, 75);
            Lprice.Size = new System.Drawing.Size(75, 26);
            Lprice.TabIndex = 3;
            Lprice.Text = "Цена:";

            // 

            //Pic Box
            picbox.BackgroundImage = Image.FromFile(accessoires.PicPath);
            picbox.BackgroundImageLayout = ImageLayout.Stretch;
            picbox.Location = new Point(3, 3);
            picbox.Size = new Size(156, 106);
            //UD Quantity
            quantyties.Location = new Point(888, 3);
            quantyties.Size = new Size(105, 26);
            quantyties.Maximum = max;
            accessoires.Quantity = (int)quantyties.Value;
            quantyties.Value = 0;
            // Label quantity
            Lquantity.AutoSize = true;
            Lquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Lquantity.Location = new System.Drawing.Point(767, 10);
            Lquantity.Size = new System.Drawing.Size(115, 20);
            Lquantity.TabIndex = 6;
            Lquantity.Text = "Количество:";

            //
            decimal Vat = 15;
            int before, after;
            before = (int)quantyties.Value;
            quantyties.Click += delegate
            {
                after = (int)quantyties.Value;
                if (before < after)
                {
                    int number = (int)quantyties.Value;

                    total += decimal.Parse((accessoires.Price).ToString());
                    totalAPriceLabel.Text = total.ToString();
                    TotalPriceVat.Text = (((total * Vat) / 100) + total).ToString();
                }
                else if (after < before)
                {
                    int number = (int)quantyties.Value;

                    total -= decimal.Parse((accessoires.Price).ToString());
                    totalAPriceLabel.Text = total.ToString();
                    TotalPriceVat.Text = (((total * Vat) / 100) + total).ToString();



                }
                before = after;

            };
            //Панел в таб Количка
            Panel panelcart;
            panelcart = new Panel();
            panelcart.Name = p.Name;
            panelcart.Margin = new Padding(3, 3, 3, 3);
            panelcart.BackColor = Color.LightGray; ;
            panelcart.Size = new Size(1016, 112);
            panelcart.Location = new Point(3, 3);
            
            panelcart.Controls.Add(Lname);
            panelcart.Controls.Add(name);
            panelcart.Controls.Add(price);
            panelcart.Controls.Add(Lprice);
            panelcart.Controls.Add(picbox);
            panelcart.Controls.Add(Lvendor);
            panelcart.Controls.Add(quantyties);
            panelcart.Controls.Add(Lquantity);
            panelcart.Controls.Add(model);
            panelcart.Controls.Add(Lmodel);
            panelcart.Controls.Add(brand);
            panelcart.Controls.Add(Lbrand);
            panelcart.Controls.Add(vendor);
            panelcart.Controls.Add(Lvendor);



            cartAFlp.Controls.Add(panelcart);

            AutoAccessoires.boughtAccesoires[p.Name] = (AutoAccessoires)accessoires;
        }
        private void addItemButton_Click(object sender, EventArgs e)
        {
            this.Close();
            accessoriesAddForm da = new accessoriesAddForm();
            da.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(cartPage);
            MessageBox.Show("Отворихте прозорец количка");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void TotalAprice_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Бутон Купи
            try
            {
                StreamWriter writer = new StreamWriter("CartA.txt");
                writer.Write(",");

                //Записва купените предмети в CartA.txt 

                foreach (var map in AutoAccessoires.boughtAccesoires) 
                {
                    writer.WriteLine(map.Value.Name + "," + map.Value.Category + "," + map.Value.Quantity.ToString() + "," + map.Value.Price.ToString() + "," + map.Value.PicPath);
                }
                writer.Close();
                //Изтрива панелите в количката
                foreach (Control p in cartAccFlp.Controls)
                {
                    if (p is Panel)
                        cartAccFlp.Controls.Remove(p);
                }
                cartLabel.Text = "0";
                TotalAprice.Text = "0";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Button b = null;
            foreach (Button btn in categoryAFlp.Controls)
            {
                if (btn.BackColor == Color.Tomato)

                    b = btn;
            }
            if ((searchTextBox.Text == "Tърсене") || searchTextBox.Text == "")
            {
                chooseCateg(accessoiresFlp, b, AutoAccessoires.accessoires);
            }
            else
            {
                panel1.VerticalScroll.Value = 3;
                //Лист който да притежава обектите от тази категория
                List<string> extra = new List<string>();

                foreach (KeyValuePair<string, Products> kvp in AutoAccessoires.accessoires)
                {
                    if (kvp.Value.Category.ToLower() == b.Text.ToLower() && kvp.Value.Name.ToLower().Contains(searchTextBox.Text.ToLower()) && b.Text != "Всички")
                    {
                        extra.Add(kvp.Key.ToLower());
                    }
                    else if (b.Text == "Всички" && kvp.Value.Name.ToLower().Contains(searchTextBox.Text.ToLower()))
                        extra.Add(kvp.Value.Name.ToLower());
                }
                foreach (Panel p in accessoiresFlp.Controls)
                {
                    if (p.BackColor == Color.Tomato)
                    {
                        //Вдига флаг true ако съдържа името 
                        if (extra.Contains(p.Name.ToLower()))
                            p.Visible = true;
                        else
                            //Вдига флаг false ако не съдържа името
                            p.Visible = false;
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Бутон Всички
            accessoiresFlp.Focus();
            foreach (Button btn in categoryAFlp.Controls)
            {
                btn.BackColor = Color.Tomato;
            }
            chooseCateg(accessoiresFlp, button2, AutoAccessoires.accessoires);
        }

        //Linq
         void CountObject(Dictionary<string,Products> autoaccessoires, Label Counter)
        {
            int counting = autoaccessoires.Count();
            Counter.Text = counting.ToString();

        }

       void MostExpensiveProduct(Dictionary<string,Products> autoaccessoires, Label MostExpensive)
        {
            var mostexpensiveproduct = autoaccessoires
                .Where(s => s.Value.Price == autoaccessoires.Max(z => z.Value.Price))
                .Select(o => "Име: " + o.Value.Name + "  Цена: " + o.Value.Price + Environment.NewLine)
                .Aggregate((f, s) => f + s);

                
            MostExpensive.Text = mostexpensiveproduct;
        }
       
        void CheapestProduct(Dictionary<string,Products> autoaccesories, Label cheapest)
        {
            var cheapestproduct = autoaccesories
                .Where(s => s.Value.Price == autoaccesories.Min(z => z.Value.Price))
                .Select(o => "Име: " + o.Value.Name + " Цена " + o.Value.Price + Environment.NewLine)
                .Aggregate((f, s) => f + s);
            cheapest.Text = cheapestproduct;
        }
        
        private void label19_Click(object sender, EventArgs e)
        {
            
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cartAccFlp_Paint(object sender, PaintEventArgs e)
        {

        }
         void chooseCateg(FlowLayoutPanel flp, Control b, Dictionary<string, Products> accessoires)
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
                foreach (KeyValuePair<string, Products> kvp in accessoires)
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
        

    }
}
