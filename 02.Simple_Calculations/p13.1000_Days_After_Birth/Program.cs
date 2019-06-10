using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
     
            {
            string birthday = Console.ReadLine();
            CultureInfo provider = CultureInfo.InvariantCulture;
            string dateFormat = "dd-MM-yyyy";
            DateTime date = DateTime.ParseExact(birthday,dateFormat , provider);
                date = date.AddDays(999);

                Console.WriteLine(date.ToString(dateFormat));
            }
        }
    }

}
    }
}
