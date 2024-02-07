using Business.Concrete;
using Entities.Concrete;
using System;
namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("asdasd");
            Person person1 = new Person();
            person1.FirstName = "ALİ";
            person1.LastName = "YAVUZ";
            person1.Tc = 1;
            person1.Year = 2004;
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }
    }
}