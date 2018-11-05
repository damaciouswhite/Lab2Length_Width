using System;


//this lab is done!
namespace Lab2_PerimeterArea
{
    class Classroom
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }


        public static void Intro()
        {
            Console.WriteLine("Lab 2");
            Console.WriteLine("=====");
            Console.WriteLine("");
            Console.WriteLine("Area & Perimeter");
            Console.WriteLine("----------------");
            Console.WriteLine("-This application prompts the user to enter a length and width.\n-The application displays the area & perimeter of the room.\n-The application prompts the user to continue. ");
            Console.WriteLine("");
        }

        public static double GetLength()
        {
            try
            {
                Console.Write("Enter Length: ");
                double Length = Convert.ToDouble(Console.ReadLine());
                return Length;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return GetLength();
            }
        }

        public static double GetWidth()
        {
            try
            {
                Console.Write("Enter Width: ");
                double Width = Convert.ToDouble(Console.ReadLine());
                return Width;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return GetWidth();
            }
                
        }


        public static void GetArea(double Length, double Width)
        {
            double Area = Length * Width;
            Console.WriteLine("");
            Console.WriteLine($"Area: {Area} sq ft");

        }

        public static void GetPerimeter(double Length, double Width)
        {
            double Perimeter = Length + Length + Width + Width;
            Console.WriteLine("");
            Console.WriteLine($"Perimeter: {Perimeter} sq ft");
            Console.WriteLine("");
        }

        public static void GetVolume(double Length, double Width)
        {   
            Console.Write("Enter height for Volume calulation: ");
            double Height = Convert.ToDouble(Console.ReadLine());

            double Volume = Height * Length * Width;
            Console.Write($"Volue: {Volume} cubic ft");
            Console.WriteLine("");
        }

        public static bool ContinueChoice()
        {
            Console.Write("Continue? (y/n) ");
            while (true)
            {
                string Choice = Console.ReadLine().ToLower();
                {
                    if (Choice == "y")
                    {
                        return true;

                    }
                    else if (Choice == "n")
                    {
                        return false;
                    }
                    else {
                        Console.WriteLine("That is not a valid answer. Please Enter (y/n) ");
                    }
                }
            }
        }
       

        static void Main(string[] args)
        {
            Intro();

            bool userContinue = true;
            while (userContinue)
            {   
                double NewLength = GetLength();
                double NewWidth = GetWidth();
                GetArea(NewLength, NewWidth);
                GetPerimeter(NewLength, NewWidth);
                GetVolume(NewLength, NewWidth);
                userContinue = ContinueChoice();
            }
            Console.WriteLine("Goodbye");
        }
    }
}






