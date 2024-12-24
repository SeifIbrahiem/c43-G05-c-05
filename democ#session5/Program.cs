namespace democ_session5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Boxingandunboxing
            //boxing>casting from value type to reference type 
            //un Boxing>casting from reference type to value type
            // Object O1;
            // O1 =>can refer to instance of "object" or any instance of any type
            // O1 = 1;
            // O1 = "Ahmed";
            //O1 = 3 ; //case from value type [int] to reference type [object] => Boxing
            //O1 = 1.5 ; //case from value type [double] to reference type [object] => Boxing
            //O1 = 'A' ; //case from value type [char] to reference type [object] => Boxing
            // O1 = new datatime ();// case from value type [date time] to reference type [object] => Boxing
            //01 = true  ; // case from value type [bool] to reference type [object] => Boxing
            int X = 4;
            object O1 = X;
            //IMPLICIT CASTING 
            //BOXING 
            //SAFE CASTING
            //PARENT = CHILD => CHILD IS PARENT
            //ANIMAL = DOG => DOG IS ANIMAL

            Object O2 = 3;
            int Y = (int)O1;

            //EXPLICIT CASTING 
            //UN BOXING 
            //UN SAFE CASTING [MAY THROW EXEPTION]
            //CHILD = PARENT => PARENT IS CHILD
            //DOG = ANIMAL => ANIMAL IS DOG
            #endregion



             
        }
    }
}
