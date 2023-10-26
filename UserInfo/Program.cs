using System;

namespace UserInfo
{
    class Program
    {
        static void userInfo(string username,int age,string address)
        {
            Console.WriteLine("Name : " + username);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Address : " + address);
        }

        static void Main(string[] args)
        {

            userInfo("Abdullah", 23, "Nagercoil");



        }
    }
}