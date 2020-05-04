using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Triangle
    {
        private double n1;
        private double n2;
        private double n3;


        public Triangle(double num1, double num2, double num3)
        {
            n1 = num1; 
            n2 = num2;
            n3 = num3;
        }
        public bool is_it_triangle()
        {
          bool hum = (n1 + n2) > n3 && (n1 + n3) > n2 && (n2 + n3) > n1;
            return hum;
        }

        public string type_of_angle()
        {
            string ans;

            if (Math.Pow(n1, 2) + Math.Pow(n2, 2) == Math.Pow(n3, 2))
            {
                ans = "Right";
            }
            else if (Math.Pow(n1, 2) + Math.Pow(n2, 2) < Math.Pow(n3, 2))
            {
                ans = "obtuse";
            }
            else
            {
                ans = "acute";
            }
            return ans;
        }
        public string side_sizes()
        {
            string side;
            if (n1 == n2 && n3 == n2)
            {
                side = "equilateral";
            }
            else if (n1 != n2 && n1 != n3 && n2 != n3)
            {
                side = "scalene";
            }
            else
            {
                side = "isoceles";
            }
            return side;
        }

    }
}
