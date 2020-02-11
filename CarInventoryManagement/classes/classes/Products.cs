using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInventoryManagement
{

    abstract class Products : IVaT, ISum, IProductDescription
    {
        
        internal string Name { get; set; }

        internal decimal Price { get; set; }
      

        internal string Category { get; set; }
      
        internal int Quantity { get; set; }
        
        internal string PicPath { get; set; }
        


        private string _brand;
       

        private string _description;
      
        private string _dealer;

        static decimal addPrice = 20;



        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }
        public string Dealer
        {
            get
            {
                return _dealer;
            }
            set
            {
                _dealer = value;
            }
        }



        public virtual string getProductNFO()
        {
            return "This is Product with name" + Name + "which costs" + Price;

        }


        public virtual decimal CalculateVat(int quantity, decimal price)
        {
            throw new NotImplementedException();
        }

        public virtual decimal Sum(int quantity, decimal price)
        {
            throw new NotImplementedException();
        }

      
       
    }
   
   
}
