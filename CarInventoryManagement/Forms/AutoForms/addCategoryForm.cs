using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInventoryManagement
{
    public partial class addCategoryForm : Form
    {
        public addCategoryForm()
        {
            InitializeComponent();
        }

        private void addCategoryForm_Load(object sender, EventArgs e)
        {
            Auto.readAutoParts();
        }
        internal string CategoryRemove;
        private void addCategory_Click(object sender, EventArgs e)
        {
            string arr = "";
            for(int i = 0; i < categorytxtBox.Text.Length; i++)
            {
                arr += " ";
            }
            if(categorytxtBox.Text == "")
            {
                errorNameCategory.Text = "Категорията не може да бъде празна";
                errorNameCategory.Visible = true;
            }
            else if (categorytxtBox.Text.Substring(0) == arr)
            {
                errorNameCategory.Text = "Категорията не може да е само с празни пространства";
                errorNameCategory.Visible = true;
            }
            else
            {
                Auto.categoryList.Add(categorytxtBox.Text);
                ClassLibrary2.Functions.appendCategory(categorytxtBox.Text, "category.txt");
                errorNameCategory.Visible = false;
                Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string categoryRemove;
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Auto.categoryList.Contains(categorytxtBox.Text))
            {
                errorNameCategory.Text = "Category does not exist!";
                errorNameCategory.Visible = true;
            }
            else
            {
                Auto.categoryList.Remove(categorytxtBox.Text);
                categoryRemove = categorytxtBox.Text;
                ClassLibrary2.Functions.reWriteCategory(Auto.categoryList, "category.txt");
                Close();
            }

        }
    }
}
