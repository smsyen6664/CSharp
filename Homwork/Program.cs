using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            // *매소드
            //int newInt = ShowUpNewSentence(5);
            //int NewInt = Show(5);
            //int i = j(5);
            //int k = L(5);
            string A = System.Console.ReadLine();
            int ANumber = Convert.ToInt32(A);

            string B = System.Console.ReadLine();
            int BNumber = Convert.ToInt32(B);

            int newint = PlusTwoParam(ANumber, BNumber);
            System.Console.WriteLine(newint);

            string s1 = System.Console.ReadLine();

            if (s1 == "+")
            {
                int Q = PlusTwoParam(ANumber, BNumber);
                System.Console.WriteLine("더하기");

            }
            else if (s1 == "-")
            {
                int W = PlusTwoParam(ANumber, BNumber);
                System.Console.WriteLine("빼기");
            }
            else if (s1 == "*")
            {
                int E = PlusTwoParam(ANumber, BNumber);
                System.Console.WriteLine("곱하기");
            }
            else if (s1 == "/")
            {
                int R = PlusTwoParam(ANumber, BNumber);
                System.Console.WriteLine("나누기");
            }
            else
            {
                System.Console.WriteLine("잘못된 기호입력");
            }
        }

            private static int PlusTwoParam(int Cnumber, int Dnumber)
            {
                int resultNumber = Cnumber + Dnumber;
                return resultNumber;
            }

        //private static int ShowUpNewSentence(int number)
        //{
        //    int newNumber = number + 5;
        //    System.Console.WriteLine(newNumber);

        //    return newNumber;
        //}
        //private static int Show(int number)
        //{
        //    int newNumber2 = number * 5;
        //    System.Console.WriteLine(newNumber2);

        //    return newNumber2;
        //}
        //private static int j(int number)
        //{
        //    int newNumber3 = number - 5;
        //    System.Console.WriteLine(newNumber3);

        //    return newNumber3;
        //}
        //private static int L(int number)
        //{
        //    int newNumber4 = number / 5;
        //    System.Console.WriteLine(newNumber4);

        //    return newNumber4;
       
    }
}
