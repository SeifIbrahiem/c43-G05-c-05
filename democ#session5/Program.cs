using System.ComponentModel.Design;
using System.Threading.Channels;

namespace democ_session5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exception handling and protecive code
            //try && catch    من خلال execepption تهندل ال 
            //Exception 
            //1.system exeception 
            //1.1 format exception
            //1.2 index out of range exception 
            //1.3 null reference exception 
            //1.4 arthimetic exception 
            //1.4.1 over flow exeception 
            //1.4.2 divid by zero exeception 

            //2. application exception 
            try
            {
                int x, y, z;
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                z = x / y;

                int[] arr = { 1, 2, 3 };

                arr[99] = 10;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("finally");
            // disconnect | dispose un managed resource
            }
        }
    }
}