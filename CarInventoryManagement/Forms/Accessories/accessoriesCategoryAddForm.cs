using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInventoryManagement.Forms.Accessories
{
    public partial class accessoriesCategoryAddForm : Form
    {
        public accessoriesCategoryAddForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string arr = "";
            for (int i = 0; i < accessoiresTB.Text.Length; i++)
            {
                arr += " ";
            }
            if (accessoiresTB.Text == "")
            {
                errorLabel.Text = "Категорията не може да бъде празна";
                errorLabel.Visible = true;
            }
            else if (accessoiresTB.Text.Substring(0) == arr)
            {
                errorLabel.Text = "Категорията не може да е само с празни пространства";
                errorLabel.Visible = true;
            }
            else
            {
                AutoAccessoires.categoryAccesoires.Add(accessoiresTB.Text);
                ClassLibrary2.Functions.appendCategory(accessoiresTB.Text, "categoryAccessoires.txt");
                
                errorLabel.Visible = false;
                Close();
            }


        }
        internal string CategoryRemove;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!AutoAccessoires.categoryAccesoires.Contains(accessoiresTB.Text))
            {
                errorLabel.Text = "Category does not exist!";
                errorLabel.Visible = true;
            }
            else
            {
                AutoAccessoires.categoryAccesoires.Remove(accessoiresTB.Text);
                CategoryRemove = accessoiresTB.Text;
                ClassLibrary2.Functions.reWriteCategory(AutoAccessoires.categoryAccesoires, "categoryAccessoires.txt");
                this.Close();
            }
        }

        private void accessoriesCategoryAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}