using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            string radius;
            string menuChoice;

            Console.WriteLine("Welcome to the Circle program!\n");
            do
            {
                Console.WriteLine("Please enter a radius");
                radius = Console.ReadLine();

            } while (ValidateRadius(radius));

            circle.SetRadius(int.Parse(radius));

            while (1 == 1)
            {
                do
                {
                    Console.WriteLine("\nPlease select one of the following options: ");
                    Console.WriteLine("1. Get Circle Radius");
                    Console.WriteLine("2. Change Circle Radius");
                    Console.WriteLine("3. Get Circle Circumference");
                    Console.WriteLine("4. Get Circle Area");
                    Console.WriteLine("5. Exit\n");

                    menuChoice = Console.ReadLine();
                } while (ValidateMenu(menuChoice));

                switch (menuChoice)
                {
                    case "1":
                        Console.WriteLine("\nCircle radius is: " + circle.GetRadius());
                        break;
                    case "2":
                        do
                        {
                            Console.WriteLine("Please enter a new radius");
                            radius = Console.ReadLine();
                        } while (ValidateRadius(radius));
                        circle.SetRadius(int.Parse(radius));
                        break;
                    case "3":
                        Console.WriteLine("\nThe circumfrence of the circle is: " + circle.GetCircumference());
                        break;
                    case "4":
                        Console.WriteLine("\nThe area of the circle is: " + circle.GetArea());
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                }
            }

        }

        public static Boolean ValidateRadius(string radius)
        {
            string errors = "";
            try
            {
                double.Parse(radius);
                    errors = "Number cannot be a decimal\n"; 
                    if (int.Parse(radius) > 0)
                    {
                        return false;
                    }
                    else if (radius.Length < 10)
                    {
                        Console.WriteLine("Number must be greater than 0");
                    }
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Number cannot be greater than 2,147,483,647");
            }
            catch (Exception ex)
            {
                Console.WriteLine("That was not a valid number\n" + errors);
                return true;
            }
            return true;
        }

        public static Boolean ValidateMenu(string menuChoice)
        {
            switch (menuChoice)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    return false;
                default:
                    Console.WriteLine("Please enter only 1, 2, 3, 4, or 5 for your selection\n");
                    return true;
            }
        }
        
    }

    
}
