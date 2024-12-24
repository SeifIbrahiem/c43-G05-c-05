using System.ComponentModel.Design;

namespace democ_session5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Nullable types
            //value type               
            //reference type
            //int x = 6;
            //x = null;   not valid 
            //nullable value type => value type allow null as valid value 
            //nullable <int> : allow int value or null as valid value 
            //int?Age = 20;
            //Age = null;
            //nullable <double> : allow double value or null as valid value 
            //double ?salary = 400.5;
            //salary = null;

            //int x = 5;
            //int ? y = x;
            //Console.WriteLine(y);  // 5
            //y: nullable <int>
            //y: allow int value or null
            //---implicit casting 
            //---- safe casting 
            //int? x = 5;
            //x = null;
            //y: int 
            // y : allow int value only 
            // int y =  x;  < int y = (int)x;
            //explicit casting  // may throw exception


            //Defensive code 
            // if (x != null)  || x is not valid{
            // Y = (int)x;
            //else 
            // y = 0;
            // Console.WriteLine(y);
       // }

        }
    }
}
