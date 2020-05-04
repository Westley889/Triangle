using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(args[0]);
            double num2 = Convert.ToDouble(args[1]);
            double num3 = Convert.ToDouble(args[2]);

            int counter = 0;
            string type = "default";
            string angle = "default";

            Triangle triangle = new Triangle(num1, num2, num3);

            if (triangle.is_it_triangle() == true)
            {
                if ((Math.Max(Math.Max(num1, num2), num3)) == num3)
                {
                    angle = triangle.type_of_angle();
                }
                else if ((Math.Max(Math.Max(num1, num2), num3)) == num2)
                {
                    angle = triangle.type_of_angle();
                }
                else
                {
                    angle = triangle.type_of_angle();
                }
            }
            else
            {
                Console.WriteLine("Invalid triangle");
                counter++;
            }
            if (counter == 0)
            {
                type = triangle.side_sizes();
                Console.WriteLine($"This is an {angle} {type} triangle");
            }
        }

        
    }
}
