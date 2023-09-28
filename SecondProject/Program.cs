using CSharpFundas;

namespace SecondProject
{
    class Program : Absraction
    {
        public static void main(String[] args)
        {
        }

        private static void ProgramMethod1()
        {
            Program p = new();
            p.PublicMethod();
            p.Protectedmethod();
            p.protectedinternalmethod();
        }
        class SecondProgram
        {
            public void Prgm()
            {
                Absraction a = new();
                a.PublicMethod();

            }
        }
    } }
