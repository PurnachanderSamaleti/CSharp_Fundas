using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundas
{
    public class Absraction
    {
        //int a, b, c;
        //string d, e, f;
        //public Absraction(int A, int B, int C, string D, string E, string F)
        //{
        //    this.a = A;
        //    this.b = B;
        //    this.c = C;
        //    this.d = D;
        //    this.e = E;
        //    this.f = F;
        //}
        //public Absraction()
        //{

        //}

        static void StaticMethod()
        {
            //public int a = 0;  
            Console.WriteLine("Static Method Called");
           
        }
        public void PublicMethod()
        {
            Console.WriteLine("Public Method Called");
            protectedinternalmethod();
            PrivateMethod();
            Protectedmethod();
            internalmethod();
          //  StaticMethod();
        }
        private void PrivateMethod()
        {
            Console.WriteLine("Private Method Called");
            protectedinternalmethod();
            PublicMethod();
            Protectedmethod();
            internalmethod();
           // StaticMethod();
        }
        protected void Protectedmethod()
        {
            Console.WriteLine("Protected Method Called");
        }
        internal void internalmethod()
        {
            Console.WriteLine("nternal method called");
        }
        protected internal void protectedinternalmethod()
        {
            Console.WriteLine("pimethod Method Called");
        }
        static void Main()
        {
            Absraction c = new Absraction();
            c.PublicMethod();
            c.PrivateMethod();
            c.Protectedmethod();
            c.internalmethod();
            c.protectedinternalmethod();
          //  StaticMethod();
        }
    }
    //class SecondClass
    //{
    //    public void SecondClassMethod()
    //    {

    //    }
    //}
    internal class ChildClass
    {
        // public
        // private
        // inernal
        // protected
        // protected internal
       
        public void ChidMethod()
        {
            Console.WriteLine("Child Method Called");
            // Absraction.StaticMethod();
            Absraction a = new();
            a.PublicMethod();
            a.internalmethod();
            a.protectedinternalmethod();
            
        }
        //static void Main()
        //{
        //    Absraction c = new Absraction();

            
        //}
    }
    class child2: Absraction
    {
        public void CallingAccessModifiers()
        {
            child2 c = new();
            c.PublicMethod();
            c.internalmethod();
            c.protectedinternalmethod();
            c.Protectedmethod()
;        }
    }

}
