using System;

namespace ConsoleApplication
{
    class MainClass
    {
        public static void Main(string[] args)
        {
                //Store two variables
                string firstName = "Heather";
                string location = "Arizona";

                //Output two WriteLine statements that display those
                //two variables with proper labels (My name is ... , I am from ...)
                //using String Interpolation.
                Console.Write("My name is " + firstName + ".");
                Console.Write("I am from " + location + ".");

                //Output the current date but not the current time.
                DateTime thisDate = new DateTime(2020, 1, 11);
                Console.WriteLine(thisDate.ToString("d"));

                //Output the number of days until Christmas
                var Christmas = 300;
                var numberOfDays = Christmas - 4;
                //var numberOfDays = ;
                Console.WriteLine(numberOfDays + "days until Christmas!");

                //Add the program example from section 2.1 in the C# Programming Yellow Book by Rob Miles.
                double width, height, woodLength, glassArea;

                string widthString, heightString;

                widthString = Console.ReadLine();

                width = double.Parse(widthString);

                heightString = Console.ReadLine();

                height = double.Parse(heightString);

                woodLength = 2 * (width + height) * 3.25;

                glassArea = 2 * (width * height);

                Console.WriteLine("The length of the wood is " +

                woodLength + " feet");

                Console.WriteLine("The area of the glass is " +

                glassArea + " square metres");

                //Add these requirements to the code:
                //Provide appropriate text labels when requesting dimensional input.
                //Cause the program to pause in the console so that the application does not automatically terminate when launched from the Visual Studio run debugger tool.
                //Hint: Consider Console.ReadKey()
                //You do NOT need to add any sort of input validation.
            }
        }
    }

