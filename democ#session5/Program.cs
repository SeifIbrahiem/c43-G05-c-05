using System.ComponentModel.Design;
using System.Threading.Channels;

namespace democ_session5
{
    internal class Program
    {
        static void Dosomeprotectivecode()
        {
            int x, y, z;
            bool flag;
            do
            {
                Console.WriteLine("enter first number:");
                flag = int.TryParse(Console.ReadLine(), out x);
            }
            while (flag==false);
            do
            {
                Console.WriteLine("enter second number:");
                flag = int.TryParse(Console.ReadLine(), out y);
            }
            while (flag == false);
            while (flag == false) ;
            do
            {
                Console.WriteLine("enter third number:");
                flag = int.TryParse(Console.ReadLine(), out z);
            }
            while (flag == false);
        }
         static void Main()
        {
            Dosomeprotectivecode();
        }

    }
 }
