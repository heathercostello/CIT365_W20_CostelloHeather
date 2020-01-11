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
                Console.Write("My name is " + firstName + ".\n");
                Console.Write("I am from " + location + ".\n");

                //Output the current date but not the current time.
                DateTime thisDate = new DateTime(2020, 1, 11);
                Console.WriteLine(thisDate.ToString("d"));

                //Output the number of days until Christmas
                DateTime christmas = new DateTime(2020, 12, 25);
                DateTime today = DateTime.Today;
             
                int numberOfDays = (christmas - today).Days;
              
                Console.WriteLine(numberOfDays + " days until Christmas!\n\n");

                //Add the program example from section 2.1 in the C# Programming Yellow Book by Rob Miles.
                Console.Write("Program example from section 2.1\n" +
                    "This program tells you how much wood and glass you will need to make a perfect window.\n");
                double width, height, woodLength, glassArea;

                string widthString, heightString;

                Console.Write("Enter the width of the window:");
                widthString = Console.ReadLine();

                width = double.Parse(widthString);

                Console.Write("Enter the height of the window:");
                heightString = Console.ReadLine();

                height = double.Parse(heightString);

                woodLength = 2 * (width + height) * 3.25;

                glassArea = 2 * (width * height);

                Console.WriteLine("The length of the wood is " +

                woodLength + " feet");

                Console.WriteLine("The area of the glass is " +

                glassArea + " square metres");
                Console.ReadKey();

                //Add these requirements to the code:
                //Provide appropriate text labels when requesting dimensional input.
                //Cause the program to pause in the console so that the application does
                //not automatically terminate when launched from the Visual Studio run debugger tool.
                //Hint: Consider Console.ReadKey()
                //You do NOT need to add any sort of input validation.
        }
        }
    }

