using System;


namespace BasicsOfCSharp
{
    //  This program demo how declare variables
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 100;
            sbyte sb = -50;
            short s = 1233;
            int i = -12345;
            uint ui = 123;
            long l = -4234234;
            ulong ul = 353252355;
            double d = 345.45;
            string str = "welcome";
            char c = 'A';
            bool flag = true;

            Console.WriteLine($"byte={b}\tshort={s}\tint={i}\tlong={l}\tdouble={d}\tstring={str}\tchar={c}\tbool={flag}");

            //  Object is a base type of all types in .Net.
            //  All types derieved from System.Object
            object intObj = 34;
            object charObj = 'C';
            object boolObj = false;
            object strObj = "welcome";
            Console.WriteLine($"intObj={intObj}\tcharObj={charObj}\tboolObj={boolObj}\tstrObj={strObj}");

            Console.ReadLine();
        }
    }
}
