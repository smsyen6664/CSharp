using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1번
            string myName;
            System.Console.Write("이름 : ");

            myName = System.Console.ReadLine();

            //2번
            string myBirth;
            System.Console.Write("생년: ");

            myBirth = System.Console.ReadLine();

            //3번
            string mySelf;
            System.Console.Write("소개: ");

            mySelf = System.Console.ReadLine();

            //4번
            System.Console.WriteLine(myName);
            System.Console.WriteLine(2023 - Convert.ToInt32(myBirth));
            System.Console.WriteLine(mySelf);

            //5번
            string yourName = "aaa";
            System.Console.WriteLine($"{yourName}");

            //6번
            System.Console.WriteLine(@"
ㅁㅁㅁ
ㅁㅁㅁ
ㅁㅁㅁ");

            //7번
            string[] sss = new string[3];
            sss[0] = myName;
            sss[1] = myBirth;
            sss[2] = mySelf;

            //8번
            System.Console.WriteLine("이름 : {0}, 나이 : {1}, 소개 : {2}", sss[0], sss[1], sss[2]);

            //9번
            System.Console.WriteLine($"이름 : {sss[0]}, 나이 : {sss[1]}, 소개 : { sss[2]}");

        }
    }
}
