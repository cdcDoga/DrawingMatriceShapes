using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/* ÇAĞIL DOĞA ÇAKIR PROJECT-1*/\nWELCOME..");
            string check, shape, character, emptyfull;
            int height, width, r, k, l, s;   // r, k and l are for controlling user's inputs.


            do
            {

                r = 0;  // for entering the loop.
                while (r < 1)  // I use this loop in case user doesn't enter T, t, R, r, P, p, D or d.
                {

                    Console.WriteLine("Write 'T' or 't' for trialgle\n      'R' or 'r' for rectangle\n      'P' or 'p' for parallelogram\n      'D' or 'd' for diamond:");
                    shape = Console.ReadLine();  // Console.ReadLine() fonction took the letter -that user enters- as a string. So I don't need to convert it. 

                    switch (shape)
                    {
                        case "T":
                        case "t":
                            k = 0;  // for entering the loop.
                            while (k < 1)  // I use this loop in case user enters less than 2 units of height.
                            {
                                Console.Write("Enter the height(minimum 2 units) of the triangle: ");
                                height = Convert.ToInt32(Console.ReadLine());
                                if (height >= 2)
                                {
                                    l = 0;  // for entering the loop.
                                    while (l < 1)  // I use this loop in case user doesn't enter E, e, F or f.
                                    {

                                        Console.WriteLine("Do you want to full or empty triangle?\nPlease enter 'E'/'e' for empty and 'F'/'f' for full:");
                                        emptyfull = Console.ReadLine();

                                        switch (emptyfull)
                                        {
                                            case "F":
                                            case "f":
                                                Console.WriteLine("Which character do you want us for drawing?");
                                                character = Console.ReadLine();
                                                Console.WriteLine("\n");

                                                for (int i = 1; i <= height; i++)
                                                {
                                                    for (int j = 1; j <= height; j++)
                                                    {
                                                        if (i >= j)
                                                            Console.Write("{0}", character);  // I make a square matrix and write the character just in half of it.
                                                        if (i < j)
                                                            Console.Write(" ");
                                                    }
                                                    Console.WriteLine();
                                                }
                                                l = 1;
                                                break;

                                            case "E":
                                            case "e":
                                                Console.WriteLine("Which character do you want us for drawing?");
                                                character = Console.ReadLine();
                                                Console.WriteLine("\n");

                                                for (int i = 1; i <= height; i++)
                                                {
                                                    for (int j = 1; j <= height; j++)
                                                    {
                                                        if (i == j || i == height || j == 1)  // for make it empty I just write the caharacters which are on the edge of triangle.
                                                            Console.Write("{0}", character);
                                                        else
                                                            Console.Write(" ");
                                                    }
                                                    Console.WriteLine();
                                                }
                                                l = 1;
                                                break;

                                            default:
                                                Console.WriteLine("You entered a wrong letter.");  // user entered some character except E, e, F or f.
                                                break;  // I didn't chanced the value of l(still =0). So it can break the switch-case but can't break the while. 
                                        }

                                    }
                                    k = 1;
                                }
                                else
                                {
                                    Console.WriteLine("You entered a value less than 2");  // I didn't chanced the value of k(still =0). So it will turn back to the height loop.
                                }
                            }
                            r = 1;
                            break;


                        case "R":
                        case "r":
                            k = 0;  // for entering the loop.
                            while (k < 1)  // I use this loop in case user enters less than 2 units of height or width.
                            {
                                Console.Write("Enter the height(minimum 2 units) of the rectangle: ");
                                height = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Enter the wight(minimum 2 units) of the rectangle: ");
                                width = Convert.ToInt32(Console.ReadLine());

                                if ((height >= 2) && (width >= 2))
                                {
                                    l = 0;  // for entering the loop.
                                    while (l < 1)  // I use this loop in case user doesn't enter E, e, F or f.
                                    {
                                        Console.WriteLine("Do you want to full or empty rectangle?\nPlease enter 'E'/'e' for empty and 'F'/'f' for full:");
                                        emptyfull = Console.ReadLine();

                                        switch (emptyfull)
                                        {
                                            case "F":
                                            case "f":
                                                Console.WriteLine("Which character do you want us for drawing?");
                                                character = Console.ReadLine();
                                                Console.WriteLine("\n");

                                                for (int i = 1; i <= height; i++)
                                                {
                                                    for (int j = 1; j <= width; j++)
                                                    {
                                                        Console.Write("{0}", character);  // I just make an ordinary matrix.
                                                    }
                                                    Console.WriteLine();
                                                }
                                                l = 1;
                                                break;

                                            case "E":
                                            case "e":
                                                Console.WriteLine("Which character do you want us for drawing?");
                                                character = Console.ReadLine();
                                                Console.WriteLine("\n");

                                                for (int i = 1; i <= height; i++)
                                                {
                                                    for (int j = 1; j <= width; j++)
                                                    {
                                                        if (i == 1 || i == height || j == 1 || j == width)  // for make it empty I just write the caharacters which are on the edge of rectancle.
                                                            Console.Write("{0}", character);
                                                        else
                                                            Console.Write(" ");
                                                    }
                                                    Console.WriteLine();
                                                }
                                                l = 1;
                                                break;

                                            default:
                                                Console.WriteLine("You entered a wrong letter.");  // user entered some character except E, e, F or f.
                                                break; // I didn't chanced the value of l(still =0). So it can break the switch-case but can't break the while. 
                                        }

                                    }
                                    k = 1;
                                }
                                else
                                {
                                    Console.WriteLine("You entered a value less than 2");  // I didn't chanced the value of k(still =0). So it will turn back to the height-width loop.
                                }
                            }
                            r = 1;
                            break;


                        case "P":
                        case "p":
                            k = 0;  // for entering the loop.
                            while (k < 1)  // I use this loop in case user enters less than 2 units of height or width.
                            {
                                Console.Write("Enter the height(minimum 2 units) of the parallelogram: ");
                                height = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Enter the wight(minimum 2 units) of the parallelogram: ");
                                width = Convert.ToInt32(Console.ReadLine());

                                if ((height >= 2) && (width >= 2))
                                {
                                    l = 0;  // for entering the loop.
                                    while (l < 1)  // I use this loop in case user doesn't enter E, e, F or f.
                                    {

                                        Console.WriteLine("Do you want to full or empty parallelogram?\nPlease enter 'E'/'e' for empty and 'F'/'f' for full:");
                                        emptyfull = Console.ReadLine();

                                        switch (emptyfull)
                                        {
                                            case "F":
                                            case "f":
                                                Console.WriteLine("Which character do you want us for drawing?");
                                                character = Console.ReadLine();
                                                Console.WriteLine("\n");

                                                for (int i = 1; i <= height; i++)
                                                {
                                                    for (int j = 1; j < i; j++)  // first I make a triangle with writting " "(space).
                                                    {
                                                        if (i > j)
                                                            Console.Write(" ");

                                                    }
                                                    for (int n = 0; n < width; n++)
                                                    {
                                                        Console.Write("{0}", character);  // then I make a rectangle after the invisible triangle.
                                                    }
                                                    Console.WriteLine();
                                                }
                                                l = 1;
                                                break;

                                            case "E":
                                            case "e":
                                                Console.WriteLine("Which character do you want us for drawing?");
                                                character = Console.ReadLine();
                                                Console.WriteLine("\n");

                                                for (int i = 1; i <= height; i++)
                                                {
                                                    for (int j = 1; j < i; j++)
                                                    {
                                                        if (i > j)
                                                            Console.Write(" ");
                                                    }

                                                    for (int n = 0; n < width; n++)
                                                    {
                                                        if (n == 0 || i == 1 || i == height || n == width - 1)  // for make it empty I just write the caharacters which are on the edge of parallelogram(rectancle).
                                                            Console.Write("{0}", character);
                                                        else
                                                            Console.Write(" ");
                                                    }
                                                    Console.WriteLine();
                                                }
                                                l = 1;
                                                break;

                                            default:
                                                Console.WriteLine("You entered a wrong letter.");  // user entered some character except E, e, F or f.
                                                break; // I didn't chanced the value of l(still =0). So it can break the switch-case but can't break the while. 
                                        }

                                    }
                                    k = 1;
                                }
                                else
                                {
                                    Console.WriteLine("You entered a value less than 2");  // I didn't chanced the value of k(still =0). So it will turn back to the height-width loop.
                                }
                            }
                            r = 1;
                            break;


                        case "D":
                        case "d":
                            k = 0;  // for entering the loop.
                            while (k < 1)  // I use this loop in case user enters less than 2 units of height.
                            {
                                Console.Write("Enter the height(minimum 3 units and an odd number) of the diamond: ");
                                height = Convert.ToInt32(Console.ReadLine());
                                if ((height >= 3) && (height % 2 == 1))
                                {
                                    l = 0;  // for entering the loop.
                                    while (l < 1)  // I use this loop in case user doesn't enter E, e, F or f.
                                    {

                                        Console.WriteLine("Do you want to full or empty diamond?\nPlease enter 'E'/'e' for empty and 'F'/'f' for full:");
                                        emptyfull = Console.ReadLine();

                                        switch (emptyfull)
                                        {
                                            case "F":
                                            case "f":
                                                Console.WriteLine("Which character do you want us for drawing?");
                                                character = Console.ReadLine();
                                                Console.WriteLine("\n");

                                                s = height / 2 + 1;    // s is the medium value of height.

                                                for (int i = 1; i <= s; i++)  // I make two triangles for diamod.
                                                {
                                                    for (int j = 1; j <= (s - i); j++)  // first I make an invisible triangle.
                                                    {
                                                        Console.Write(" ");
                                                    }

                                                    for (int n = 1; n <= (2 * i - 1); n++)  // after that invisible triangle I make the upper half of diamond.
                                                    {
                                                        Console.Write("{0}", character);
                                                    }
                                                    Console.WriteLine();

                                                }

                                                for (int w = 1; w <= s - 1; w++)
                                                {
                                                    for (int t = 1; t <= w; t++)  // I make one more invisible triangle.
                                                    {
                                                        Console.Write(" ");
                                                    }

                                                    for (int u = 1; u <= s - 2 * (w - 1); u++)  // after second invisible triangle I make the reverse half of the diamond.
                                                    {
                                                        Console.Write("{0}", character);
                                                    }
                                                    Console.WriteLine();

                                                }

                                                l = 1;
                                                break;


                                            case "E":
                                            case "e":
                                                Console.WriteLine("Which character do you want us for drawing?");
                                                character = Console.ReadLine();
                                                Console.WriteLine("\n");

                                                s = height / 2 + 1;    // s is the medium value of height.

                                                for (int i = 1; i <= s; i++)
                                                {
                                                    for (int j = 1; j <= (s - i); j++)
                                                    {
                                                        Console.Write(" ");
                                                    }

                                                    for (int n = 1; n <= (2 * i - 1); n++)
                                                    {
                                                        if (n == 1 || n == 2 * i - 1)
                                                            Console.Write("{0}", character);  // for make it empty I just write the caharacters which are on the edge of diamond(two traingles).
                                                        else
                                                            Console.Write(" ");
                                                    }
                                                    Console.WriteLine();

                                                }

                                                for (int w = 1; w <= s - 1; w++)
                                                {
                                                    for (int t = 1; t <= w; t++)
                                                    {
                                                        Console.Write(" ");
                                                    }

                                                    for (int u = 1; u <= s - 2 * (w - 1); u++)
                                                    {
                                                        if (u == 1 || u == s - 2 * (w - 1))
                                                            Console.Write("{0}", character);
                                                        else
                                                            Console.Write(" ");
                                                    }
                                                    Console.WriteLine();

                                                }

                                                l = 1;
                                                break;

                                            default:
                                                Console.WriteLine("You entered a wrong letter.");  // user entered some character except E, e, F or f.
                                                break;  // I didn't chanced the value of l(still =0). So it can break the switch-case but can't break the while. 
                                        }

                                    }
                                    k = 1;
                                }
                                else
                                {
                                    Console.WriteLine("You entered a value less than 3 or an even number");  // I didn't chanced the value of k(still =0). So it will turn back to the height loop.
                                }
                            }
                            r = 1;
                            break;

                        default:
                            Console.WriteLine("You entered a wrong letter.");  // user entered some character except T, t, R, r, P, p, D or d.
                            break;  // I didn't chanced the value of r(still =0). So it can break the switch-case but can't break the while.

                    }

                }
                Console.WriteLine("\nDo you want to exit or draw a new shape?\nWrite 'E' or 'e' for exit. Write any other character you want for continue..");
                check = Console.ReadLine();

            }
            while ((check != "E") && (check != "e"));  // I didn't use the fonction Console.ReadLine() => when user enters "e" or "E" that will close the program.
        }
    }
}
