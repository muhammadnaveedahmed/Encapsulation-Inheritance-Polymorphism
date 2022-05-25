//using System;
//using System.ComponentModel.DataAnnotations;

//namespace ConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome!");

//            try
//            {
//                //initialize person object
//                Person person = new Person();

//                Console.WriteLine("Please enter age.");
//                //reads age value
//                var age = Console.ReadLine();
//                person.Age = Convert.ToInt32(age);

//                Console.WriteLine("Please enter first name.");
//                //reads age value
//                var fName = Console.ReadLine();
//                person.FName = fName;

//                Console.WriteLine("Please enter last name.");
//                //reads age value
//                var lName = Console.ReadLine();
//                person.LName = lName;

//                Console.WriteLine("Please enter height.");
//                //reads height value
//                var height = Console.ReadLine();
//                person.Height = Convert.ToDouble(height);

//                Console.WriteLine("Please enter weight.");
//                //reads age value
//                var weight = Console.ReadLine();
//                person.Weight = Convert.ToDouble(weight);

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error message: " + ex.Message);
//            }
//        }
//    }

//    class Person
//    {
//        private int age;
//        private string fName;
//        private string lName;
//        private double height;
//        private double weight;

//        public int Age
//        {
//            get { return age; }
//            set
//            {
//                if (value == 0)
//                {
//                    throw new ArgumentException("Age must be greater than zero.");
//                }
//                else
//                {
//                    age = value;
//                }
//            }
//        }

//        public string FName
//        {
//            get { return fName; }
//            set
//            {
//                if (value.Length < 2 || value.Length > 10)
//                {
//                    throw new ArgumentException("First name must not be less than 2 characters or greater than 10 sign.");
//                }
//                else
//                {

//                }
//                fName = value;
//            }
//        }

//        public string LName
//        {
//            get { return lName; }
//            set
//            {
//                if (value.Length < 3 || value.Length > 15)
//                {
//                    throw new ArgumentException("Last name must not be less than 3 characters or greater than 15 sign.");
//                }
//                else
//                {
//                    lName = value;
//                }
//            }
//        }

//        public double Height
//        {
//            get { return height; }
//            set { height = value; }
//        }

//        public double Weight
//        {
//            get { return weight; }
//            set { weight = value; }
//        }
//    }

//    class PersonHandler
//    {
//        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
//        {
//            Person person = new Person
//            {
//                Age = age,
//                FName = fName,
//                LName = lName,
//                Height = height,
//                Weight = weight
//            };

//            return person;
//        }
//    }
//}


using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");

            //test case 1
            try
            {
                //initialize person object
                Person person = new Person();

                Console.WriteLine("Please enter age.");
                //reads age value
                var age = Console.ReadLine();
                person.Age = Convert.ToInt32(age);

                Console.WriteLine("Please enter first name.");
                //reads age value
                var fName = Console.ReadLine();
                person.FName = fName;

                Console.WriteLine("Please enter last name.");
                //reads age value
                var lName = Console.ReadLine();
                person.LName = lName;

                Console.WriteLine("Please enter height.");
                //reads height value
                var height = Console.ReadLine();
                person.Height = Convert.ToDouble(height);

                Console.WriteLine("Please enter weight.");
                //reads age value
                var weight = Console.ReadLine();
                person.Weight = Convert.ToDouble(weight);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error message: " + ex.Message);
            }

            //test case 2
            try
            {
                //initialize person object
                Person person = new Person();

                Console.WriteLine("Please enter age.");
                //reads age value
                var ageValue = Console.ReadLine();
                var age = Convert.ToInt32(ageValue);

                Console.WriteLine("Please enter first name.");
                //reads age value
                var fName = Console.ReadLine();

                Console.WriteLine("Please enter last name.");
                //reads age value
                var lName = Console.ReadLine();

                Console.WriteLine("Please enter height.");
                //reads height value
                var heightValue = Console.ReadLine();
                var height = Convert.ToDouble(heightValue);

                Console.WriteLine("Please enter weight.");
                //reads age value
                var weightValue = Console.ReadLine();
                var weight = Convert.ToDouble(weightValue);

                PersonHandler personHandler = new PersonHandler();
                personHandler.CreatePerson(age, fName, lName, height, weight);

                Console.WriteLine("Person created.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error message: " + ex.Message);
            }
        }
    }

    class Person
    {
        private int age;
        private string? fName;
        private string? lName;
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Age must be greater than zero.");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string? FName
        {
            get { return fName; }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First name must not be less than 2 characters or greater than 10 sign.");
                }
                else
                {

                }
                fName = value;
            }
        }

        public string? LName
        {
            get { return lName; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last name must not be less than 3 characters or greater than 15 sign.");
                }
                else
                {
                    lName = value;
                }
            }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }

    class PersonHandler
    {
        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person person = new Person
            {
                Age = age,
                FName = fName,
                LName = lName,
                Height = height,
                Weight = weight
            };

            return person;
        }
    }
}