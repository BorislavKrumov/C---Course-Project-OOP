using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary2
{
    public class Functions
    {
        public static void appendCategory(string sCategory,string nameOfCategory)
        {
            using (StreamWriter write = File.AppendText(nameOfCategory))
            {
                write.WriteLine(sCategory);
            }
        }
        public static void reWriteCategory(List<string> categoryList,string nameOfCategory)
        {
            using (StreamWriter write = new StreamWriter(nameOfCategory))
            {
                foreach (string s in categoryList)
                {
                    write.WriteLine(s);
                }
            }

        }
        public static void TEst()
        {
            int x = 10;
        }
    }
}
