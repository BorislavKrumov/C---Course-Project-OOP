using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using ClassLibrary2;
namespace CarInventoryManagement
{
    class Auto : Products, IVaT,ISum
    {
       
        //Data store
        public static Dictionary<string, Products> autos = new Dictionary<string, Products>();
        public static Dictionary<string, Auto> cart = new Dictionary<string, Auto>();
        public static List<string> commercials = new List<string>();
        public static List<string> categoryList = new List<string>();
        public static Dictionary<string, Auto> bought = new Dictionary<string, Auto>();
        
        
        internal protected double VatOnAuto = 0.20;
        public Auto(string name, string category, int quantity, decimal price,string picPath)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            Price = price;
            PicPath = picPath;
        }
        
       
        
        
      
     
        public override string getProductNFO()
        {
            return "Авточастта с име:  " + Name + " струва " + Price + " лева ";
        }

        //Метод за четене от файл
        
        
        public static void readAutoParts()
        {
            string[] arr;
            try
            {
                List<string> lines = File.ReadAllLines("autoparts.txt").ToList();
                foreach (string line in lines)
                {
                    arr = line.Split(',');

                    string Name = arr[0];
                    string Category = arr[1];
                    int Quantity = int.Parse(arr[2]);
                    decimal Price = decimal.Parse(arr[3]);
                     string PicPath = arr[4];
                    Auto test = new Auto(Name,Category,Quantity,Price,PicPath);
                    autos[arr[0]] = test;

                }
            }
            catch { Console.WriteLine("Проба"); }
        }
        //Метод за Добавяне на категория
       
        public static void appendCategory(string sCategory)
        {
            using (StreamWriter write = File.AppendText("category.txt"))
            {
                write.WriteLine(sCategory);
            }
        }
        public static void reWriteCategory()
        {
            using (StreamWriter write = new StreamWriter("category.txt"))
            {
                foreach (string s in categoryList)
                {
                    write.WriteLine(s);
                }
            }

        }

        public static void ReadItems()
        {
            string[] arr;
            try
            {
                List<string> lines = File.ReadAllLines("autoparts.txt").ToList();
                foreach (string line in lines)
                {
                    arr = line.Split(',');
                    string name = arr[0];
                    string category = arr[1];
                    int quantity = int.Parse(arr[2]);
                    decimal price = decimal.Parse(arr[3]);
                    string path = arr[4];
                    Auto autos = new Auto(name, category, quantity, price, path);

                }

            }
            catch
            {
                Console.WriteLine("Грешка");
            }
                }
        

        public override decimal Sum(int quantity, decimal price)
        {
            return quantity * Price;
        }
        public override decimal CalculateVat(int quantity, decimal price)
        {
            return quantity * Price + ((quantity * price) * (decimal)VatOnAuto);
        }
    }
}
