using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3DylanRich
{
    class ProgramPt3
    {

        //Create a structure to hold a persons info
        public class Person
        {
            private string fName;
            private string mName;
            private string lName;
            private string street1;
            private string street2;
            private string city;
            private string state;
            private string zip;
            private string phone;
            private string email;

            public string FName
            {
                get
                {
                    return fName;
                }

                set
                {
                    fName = value;
                }
            }

            public string MName
            {
                get
                {
                    return mName;
                }

                set
                {
                    mName = value;
                }


            }

            public string LName
            {
                get
                {
                    return lName;
                }

                set
                {
                    lName = value;
                }
            }

            public string Street1
            {
                get
                {
                    return street1;
                }

                set
                {
                    street1 = value;
                }


            }
            public string Street2
            {
                get
                {
                    return street2;
                }

                set
                {
                    street2 = value;
                }
            }
            public string City
            {
                get
                {
                    return city;
                }

                set
                {
                    city = value;
                }
            }
            public string State
            {
                get
                {
                    return state;
                }

                set
                {
                    state = value;
                }
            }
            public string Zip
            {
                get
                {
                    return zip;
                }

                set
                {
                    zip = value;
                }

            }
            public string Phone
            {
                get
                {
                    return phone;
                }

                set
                {
                    phone = value;
                }
            }

            public string Email
            {
                get
                {
                    return email;
                }

                set
                {
                    email = value;
                }
            }



            static void Main(string[] args)
            {
                //Create a Person
                Person temp = new Person();
                //Get data to fill person

                Console.Write("Please enter the persons first name: ");
                temp.fName = Console.ReadLine();

                Console.Write("Please enter the persons middle name: ");
                temp.mName = Console.ReadLine();

                Console.Write("Please enter the persons last name: ");
                temp.lName = Console.ReadLine();

                Console.Write("Please enter the persons Street1: ");
                temp.street1 = Console.ReadLine();

                Console.Write("Please enter the persons Street2 (if applicable): ");
                temp.street2 = Console.ReadLine();

                Console.Write("Please enter the persons City: ");
                temp.city = Console.ReadLine();

                Console.Write("Please enter the persons State: ");
                temp.state = Console.ReadLine();

                Console.Write("Please enter the persons Zip Code: ");
                temp.zip = Console.ReadLine();

                Console.Write("Please enter the persons Phone Number: ");
                temp.phone = Console.ReadLine();

                Console.Write("Please enter the persons Email: ");
                temp.email = Console.ReadLine();


                //Output person data
                Console.WriteLine($"New Member: \n{temp.FName} \n{temp.MName} \n{temp.LName} \n{temp.Street1} \n{temp.Street2} \n{temp.City} \n{temp.State} \n{temp.Zip} \n{temp.Phone} \n{temp.Email}");



                //Let the user decide when they are done by waiting (press any key)
                BasicTools.Pause();
            }
        }
    }
}
