using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3DylanRich
{
    class Program
    {

        //Create a structure to hold a persons info
        struct Person
        {
            public string FName;
            public string MName;
            public string LName;
            public string Street1;
            public string Street2;
            public string City;
            public string State;
            public string Zip;
            public string Phone;
            public string Email;

        }
        static void Main(string[] args)
        {
            //Create a Person
            Person temp = new Person();
            //Get data to fill person

            Console.Write("Please enter the persons first name: ");
            temp.FName = Console.ReadLine();

            Console.Write("Please enter the persons middle name: ");
            temp.MName = Console.ReadLine();

            Console.Write("Please enter the persons last name: ");
            temp.LName = Console.ReadLine();

            Console.Write("Please enter the persons Street1: ");
            temp.Street1 = Console.ReadLine();

            Console.Write("Please enter the persons Street2 (if applicable): ");
            temp.Street2 = Console.ReadLine();

            Console.Write("Please enter the persons City: ");
            temp.City = Console.ReadLine();

            Console.Write("Please enter the persons State: ");
            temp.State = Console.ReadLine();

            Console.Write("Please enter the persons Zip Code: ");
            temp.Zip = Console.ReadLine();

            Console.Write("Please enter the persons Phone Number: ");
            temp.Phone = Console.ReadLine();

            Console.Write("Please enter the persons Email: ");
            temp.Email = Console.ReadLine();


            //Output person data
            Console.WriteLine($"New Member: \n{temp.FName} \n{temp.MName} \n{temp.LName} \n{temp.Street1} \n{temp.Street2} \n{temp.City} \n{temp.State} \n{temp.Zip} \n{temp.Phone} \n{temp.Email}");



            //Let the user decide when they are done by waiting (press any key)
            BasicTools.Pause();
        }
    }
}
