using System.ComponentModel.Design;

namespace democ_session5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //null propagation operator ?
            //double x = default; 
            //Console.WriteLine(x); //0
            //char c = default;
            //Console.WriteLine(c); //space
            //bool c = default;
            //Console.WriteLine(c);

            // the default value with reference type is nuul 
            //int[] Arr = default;
            //for (int i = 0; i < args.Length; i++)
            //    Console.WriteLine(Arr[i]); // null reference exception
            //int[] Arr = { 1, 2, 3, 4, 5 };
            ////Best practice 
            //if (Arr is not null)
            //{
            //    for (int i = 0; i < args.Length; i++)
            //        Console.WriteLine(Arr[i]);
            //}
            //int Len = arr.Length;
            //Console.WriteLine(Len);
        }
    }
}
