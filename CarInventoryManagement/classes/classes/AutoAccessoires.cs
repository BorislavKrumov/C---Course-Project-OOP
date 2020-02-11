using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace CarInventoryManagement
{
    class AutoAccessoires : Products,ISum,IVaT,IProductDescription
    {
        public static Dictionary<string,Products> accessoires = new Dictionary<string, Products>();
        public static Dictionary<string, AutoAccessoires> cartA = new Dictionary<string, AutoAccessoires>();
        public static List<string> commercialsAccesoires = new List<string>();
        public static List<string> categoryAccesoires = new List<string>();
        public static Dictionary<string, AutoAccessoires> boughtAccesoires = new Dictionary<string, AutoAccessoires>();

        private decimal VatOnAccessoires = 0.15m;

        public override decimal CalculateVat(int quantity, decimal price)
        {
            return quantity * Price + ((quantity * price) * VatOnAccessoires);
        }
       
        public override string getProductNFO()
        {
            return "Аксесоара с име " + Name +" Марка:  "+Brand + " Модел: " + Description +" от Вносител: " +Dealer + " струва " + Price;
        }
        public override decimal Sum(int quantity, decimal price)
        {
            return quantity * price;
        }
        public static void Read()
        {
            
            string[] arr;
            try
            {
                List<string> lines = File.ReadAllLines("accessoires.txt").ToList();
                foreach (string line in lines)
                {
                    arr = line.Split(',');

                    Products objacc = new AutoAccessoires();
                    objacc.Name = arr[0];
                    objacc.Category = arr[1];
                    objacc.Quantity = int.Parse(arr[2]);
                    objacc.Price = decimal.Parse(arr[3]);
                    objacc.Brand = arr[4];
                    objacc.Description = arr[5];
                    objacc.Dealer = arr[6];
                    objacc.PicPath = arr[7];
                    accessoires[arr[0]] = objacc;

                }
            }
            catch { MessageBox.Show("Грешка"); }
        }


      


       

        //Метод за Добавяне на категория
        public static void appendCategory(string sCategory)
        {
            using (StreamWriter write = File.AppendText("categoryAccessoires.txt"))
            {
                write.WriteLine(sCategory);
            }
        }
        public static void reWriteCategory()
        {
            using (StreamWriter write = new StreamWriter("categoryAccessoires.txt"))
            {
                foreach (string s in AutoAccessoires.categoryAccesoires)
                {
                    write.WriteLine(s);
                }
            }

        }

        
       
    }
}
