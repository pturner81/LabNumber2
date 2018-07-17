using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //enter lenth
            double Width, Length, Height;

            Console.WriteLine("Enter the room width (in feet using decimals not inches)");
            Width = Convert.ToDouble(Console.ReadLine());
            //enter width
            Console.WriteLine("Enter the room length (in feet using decimals not inches)");
            Length = Convert.ToDouble(Console.ReadLine());
            
            
            //process
            //area
            //perimeter
            double Area = (Width*Length);
            double Perimeter = ((Width * 2) + (Length * 2));
            double Volume;

            //output
            Console.WriteLine($"The Area of the room is {Area} square feet.");
            //area
            Console.WriteLine($"The Perimeter of the room is {Perimeter} feet.");
            //perimeter
            string Vol;
            Console.WriteLine("Would you like to calculate the room's volume? (Y/N)");
            Vol = Console.ReadLine();
            if (Vol == "y" || Vol == "Y" || Vol == "Yes" || Vol == "yes" || Vol == "YES")
            {
                Console.WriteLine("What is the height of the room? (In feet using decimals, not inches.)");
                Height = Convert.ToDouble(Console.ReadLine());
                Volume = (Height * Width * Length);
                Console.WriteLine($"The Volume of the room is {Volume} cubic feet.");

            }

            //Continue upon user request
            string DoAgain;
            Console.WriteLine("Would you like to calculate another room size? (Y/N)");
            DoAgain = Console.ReadLine();
            while (DoAgain == "Y" || DoAgain == "y" || DoAgain == "yes" || DoAgain == "YES" || DoAgain== "Yes")
            {
                //input
                //enter lenth
           

                Console.WriteLine("Enter the room width (in feet using decimals not inches)");
                Width = Convert.ToDouble(Console.ReadLine());
                //enter width
                Console.WriteLine("Enter the room length (in feet using decimals not inches)");
                Length = Convert.ToDouble(Console.ReadLine());


                //process
                //area
                //perimeter
                Area = (Width * Length);
                Perimeter = ((Width * 2) + (Length * 2));


                //output
                Console.WriteLine($"The Area of the room is {Area}'.");
                //area
                Console.WriteLine($"The Perimeter of the room is {Perimeter}'.");
                Console.WriteLine("Would you like to calculate the room's volume? (Y/N)");
                Vol = Console.ReadLine();
                if (Vol == "y" || Vol == "Y" || Vol == "Yes" || Vol == "yes" || Vol == "YES")
                {
                    Console.WriteLine("What is the height of the room? (In feet using decimals, not inches.)");
                    Height = Convert.ToDouble(Console.ReadLine());
                    Volume = (Height * Width * Length);
                    Console.WriteLine($"The Volume of the room is {Volume} cubic feet.");

                }

                Console.WriteLine("Would you like to calculate another room size? (Y/N)");
                DoAgain = Console.ReadLine();
            }
            Console.WriteLine("Thank you, you may close the program.");
            Console.ReadKey();
        }
    }
}
