using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TechProTask1
{
    class program
    {
        public static void Main()
        {
            
            Console.WriteLine("Enter the number of row for square");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 3)
            {
                Square_Hollow_Pattern(x);
                Console.WriteLine();
                Number_triangle_Pattern(x);
                Console.WriteLine();
                Number_increasing_Pyramid_Pattern(x);
                Console.WriteLine();
                Number_increasing_reverse_Pyramid_Pattern(x);
                Console.WriteLine();
                Number_changing_Pyramid_Pattern(x);
                Console.WriteLine();
                Zero_One_Triangle_Pattern(x);
                Console.WriteLine();
                Palindrome_Triangle_Pattern(x);
                Console.WriteLine();
                Rhombus_Pattern(x);
                Console.WriteLine();
                Diamond_Star_Pattern(x);
                Console.WriteLine();
                Mirror_Image_Triangle_Pattern(x);
                Console.WriteLine();
                Hollow_Triangle_Pattern(x);
                Console.WriteLine();
                Hollow_Reverse_Triangle_Pattern(x);
                Console.WriteLine();
                Hollow_Diamond_Pyramid(x);
                Console.WriteLine();
                Hollow_Hourglass_Pattern(x);
                Console.WriteLine();
                Pascals_Triangle(x);

            }
            else
            {
                Console.WriteLine("Please Enter Value Greater then or Equals to 3");
            }
            Console.ReadLine();
        }

        public static void Square_Hollow_Pattern(int x)
        {

            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= x; j++)
                {
                    if (i == 1 || j == x || i == x || j == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }

        }


        public static void Number_triangle_Pattern(int x)
        {

            for (int i = 1; i <= x; i++)
            {
                for (int j = x - 1; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();

            }

        }



        public static void Number_increasing_Pyramid_Pattern(int x)
        {

            for (int i = 1; i <= x; i++)
            {


                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }



        public static void Number_increasing_reverse_Pyramid_Pattern(int x)
        {
            for (int i = 1; i <= x; i++)
            {


                for (int k = i; k <= x; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }

        }


        public static void Number_changing_Pyramid_Pattern(int x)
        {
            int count = 1;
            for (int i = 1; i <= x; i++)
            {

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(count + " ");
                    count++;
                }
                Console.WriteLine();
            }

        }

        public static void Zero_One_Triangle_Pattern(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write((j % 2 == 1) ? "1 " : "0 ");


                    }
                    else
                    {
                        Console.Write((j % 2 == 1) ? "0 " : "1 ");
                    }

                }
                Console.WriteLine();
            }
        }

        public static void Palindrome_Triangle_Pattern(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = x - 1; j >= i; j--)
                {
                    Console.Write("  ");
                }

                for (int k = i; k >= 1; k--)
                {
                    Console.Write(k + " ");
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write(l + " ");
                }

                Console.WriteLine();

            }
        }

        public static void Rhombus_Pattern(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = i; j <= x - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= x; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void Diamond_Star_Pattern(int x)
        {
            int count = 1;
            for (int i = 1; i <= x; i++)
            {
                for (int j = x; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= count; k++)
                {
                    Console.Write("*");
                }
                count += 2;
                Console.WriteLine();

            }
            for (int i = 1; i <= x + 1; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= count; k++)
                {
                    Console.Write("*");
                }
                count -= 2;
                Console.WriteLine();

            }
        }

        public static void Mirror_Image_Triangle_Pattern(int x)
        {

            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = i; k <= x; k++)
                {
                    Console.Write(k + " ");
                }

                Console.WriteLine();

            }
            for (int i = x - 1; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = i; k <= x; k++)
                {
                    Console.Write(k + " ");
                }

                Console.WriteLine();

            }
        }

        public static void Hollow_Triangle_Pattern(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = i; j <= x - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i * 2 - 1; k++)
                {
                    if (k == 1 || k == i * 2 - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= x * 2 - 1; i++)
            {
                Console.Write("*");
            }

        }

        public static void Hollow_Reverse_Triangle_Pattern(int x)
        {

            for (int i = x; i >= 1; i--)
            {
                for (int j = i; j <= x; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i * 2 - 1; k++)
                {
                    if (k == 1 || i == x)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                Console.WriteLine();
            }

        }

        public static void Hollow_Diamond_Pyramid(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = i; j <= x; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i * 2 - 1; k++)
                {
                    if (k == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                Console.WriteLine();
            }
            for (int i = x; i >= 1; i--)
            {
                for (int j = i; j <= x; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i * 2 - 1; k++)
                {
                    if (k == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                Console.WriteLine();
            }
        }

        public static void Hollow_Hourglass_Pattern(int x)
        {
            for (int i = x; i >= 1; i--)
            {
                for (int j = i; j <= x; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i * 2 - 1; k++)
                {
                    if (k == 1 || i == x)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                Console.WriteLine();
            }
            for (int i = 2; i <= x; i++)
            {
                for (int j = i; j <= x; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i * 2 - 1; k++)
                {
                    if (k == 1 || i == x)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                Console.WriteLine();
            }
            

        }

        public static void Pascals_Triangle(int x)
        {

                for (int i = 0; i < x; i++)
                {
                    int c = 1;
                    for (int j = 0; j < x - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k <= i; k++)
                    {
                        Console.Write(c + " ");
                        c = c * (i - k) / (k + 1);


                    }
                    Console.WriteLine();
                }
            
        }

    }
}
