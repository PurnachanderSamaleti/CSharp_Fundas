using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundas
{
    internal class MethodOverLoading
    {
        int a = 1;
        public void Method1()
        {
            //int i = 0;
            //while (i < 101)
            //{
            //    Console.WriteLine("Number " + i);
            //    i ++;
            //}
            //for(int j = 0; j  < 101; j++)
            //{
            //    Console.WriteLine("Number " + j);
            //}
            int[] ad = {1, 2, 3, 4, 5};
            Console.WriteLine(ad.Length);
            //int lm = ad.Length;
            //for (int k = 0; k < lm; k++)
            //{
            //    Console.WriteLine(ad[k]);
            //}
            //foreach (int i in ad)
            //{
            //    Console.WriteLine(i);
            //}
            string[] s = { "Ram", "Shyam", "RRR", "Bhubaku" };
            foreach(string l in s)
            {
                Console.WriteLine(l);
            }
            for (int m = 0; m < s.Length; m++)
            {
                Console.WriteLine(s[m]);
            }
        }
        public void Name(int s)
        {

            if (s < 11)
            {
                Console.WriteLine("Number is " + s);
                s = s + 1;
                Name(s);
            }

        }
        public void Method1(string asm)
        {
           
            Console.WriteLine("Method 1 Called from "+ asm);
            asm = "This is text";
            Console.WriteLine("Method 1 Called from " + asm);
        }
        public void Method1(int j, string b)
        {

           // Console.WriteLine("Method 1 Called from " + m);
        }
        public void Method1(string b, int j)
        {

            // Console.WriteLine("Method 1 Called from " + m);
        }
        public void Method1(string m, string N)
        {

            Console.WriteLine("Method 1 Called from " + m);
        }
        public void Method1(int v)
        {
            Console.WriteLine("Method 1 int Called from " + v);
        }
        //public void Method2()
        //{

        //   // Method1("Method2");
        //}
       
        static void Main()
        {
           MethodOverLoading methodOverLoading = new MethodOverLoading();
            methodOverLoading.Method1();
            //methodOverLoading.Name(0);

        }
    }
}
