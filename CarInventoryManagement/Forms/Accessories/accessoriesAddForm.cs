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

namespace CarInventoryManagement.Forms.Accessories
{
    public partial class accessoriesAddForm : Form
    {
        public accessoriesAddForm()
        {
            InitializeComponent();
        }

        private void modelLabel_Click(object sender, EventArgs e)
        {

        }

        private void accessoriesAddForm_Load(object sender, EventArgs e)
        {

        }

        private void picBox_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int counter = AutoAccessoires.accessoires.Count();
            string name = nameTxtBox.Text;
            string category = categoryTxtBox.Text;
            int quantity = (int)quantityUD.Value;
            decimal price = (decimal)priceUD.Value;
            string brand = brandTxtBox.Text;
            string model = modelTxtBox.Text;
            string vendor = vendorTxtBox.Text;
            string picPath = textBox1.Text;

            if (!AutoAccessoires.categoryAccesoires.Contains(category))
            {
                AutoAccessoires.categoryAccesoires.Add(category);
                
                    try
                    {
                        AutoAccessoires.categoryAccesoires = File.ReadAllLines("categoryAccessoires.txt").ToList();
                        using (StreamWriter write = File.AppendText("categoryAccessoires.txt"))
                        {
                            write.WriteLine(category);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Зареждане");
                    }
                

                AutoAccessoires addAc = new AutoAccessoires();
                addAc.Name = name;
                addAc.Category = category;
                addAc.Quantity = quantity;
                addAc.Price = price;
                addAc.Brand = brand;
                addAc.Description = model;
                addAc.Dealer = vendor;
                using (StreamWriter write = File.AppendText("accessoires.txt"))
                {
                    write.WriteLine(nameTxtBox.Text + "," + categoryTxtBox.Text + "," + quantityUD.Value.ToString() + "," + priceUD.Value.ToString() + "," +
                        brandTxtBox.Text + "," + modelTxtBox.Text+ "," +vendorTxtBox.Text + "," + textBox1.Text);
                }
                this.Close();
            }
        }

        private void pathPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if(dialog.ShowDialog() ==  DialogResult.OK)
            {
                picBox.BackgroundImage = Image.FromFile(dialog.FileName);
                textBox1.Text = dialog.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void brandTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
