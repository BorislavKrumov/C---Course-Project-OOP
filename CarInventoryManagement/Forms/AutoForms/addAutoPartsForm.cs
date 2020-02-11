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
using System.Xml.Serialization;

namespace CarInventoryManagement
{
    public partial class addAutoPartsForm : Form
    {
        public addAutoPartsForm()
        {
            InitializeComponent();

        }
        public static string k;
        private void addAutoPartsForm_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            


            int counter = Auto.autos.Count();
            string name = nameTxtBox.Text;
            string category = categoryTxtBox.Text;
            int quantity = (int)quantityNumUD.Value;
            decimal price = (decimal)priceNumUD.Value;
            string picpath = picTxtBox.Text;
            if (!Auto.categoryList.Contains(category))
            {
                Auto.categoryList.Add(category);
                try
                {
                    Auto.categoryList = File.ReadAllLines("category.txt").ToList();
                    using (StreamWriter write = File.AppendText("category.txt"))
                    {
                        write.WriteLine(category);
                    }
                }
                catch
                {
                    MessageBox.Show("Зареждане");
                }

            }

            Auto constructparts = new Auto(name, category, quantity, price, picpath);
        

            
            using (StreamWriter write = File.AppendText("autoparts.txt"))
                {
                   
                       
                        write.WriteLine(nameTxtBox.Text + "," + categoryTxtBox.Text + "," + quantityNumUD.Value.ToString() + "," + priceNumUD.Value.ToString() + "," + picpath);

                }
            this.Close();

        }

        private void pathPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picBox.BackgroundImage = Image.FromFile(dialog.FileName);
                picTxtBox.Text = dialog.FileName;
            }
        }

        private void quantityNumUD_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
