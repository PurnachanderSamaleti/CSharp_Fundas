using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundas
{
    class Class1
    {
        int a = 23;
        string N;
        public void Name()
        {
            Console.WriteLine("My name is chandu");
            word();         
        }

        public void word()
        {
            Console.WriteLine("hello word");

        }
        public static void value()
        {
            Console.WriteLine("The value is 65");

        }
        static void Main()
        {
            Class1 k = new Class1();
            k.word();
            k.Name();
            value();
            Console.WriteLine("The number is" + k.a);
       }
    }

    }

