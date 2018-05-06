using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pushBoxFinal
{
    class Program
    {
        static int x1 = 1, y1 = 1;   //球的位置
        static int p1 = 16, q1 = 15;      //終點1位置
        static int p2 = 1, q2 = 11;       //終點2位置
        static int p3 = 8, q3 = 1;        //終點3位置
        static int p4 = 17, q4 = 6;       //終點4位置
        

        static void Main(string[] args)
        {
            int count = 0;
            Random ran = new Random();
     
            string[,] migon =
            {   {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"},
                {"#","O"," "," "," "," "," "," "," "," ","#","G"," "," "," "," ","#"},
                {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," "," "," "," "," "," "," "," ","B"," "," "," "," "," "," ","#"},
                {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," "," "," "," "," "," "," "," "," "," "," ","B"," "," "," ","#"},
                {"#","#"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#","G"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," "," ","B"," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," "," "," "," "," "," "," ","B"," "," "," "," "," "," "," ","#"},
                {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},
                {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","G","#"},
                {"#"," "," "," "," ","#","G"," "," "," "," "," "," "," "," ","#","#"},
                {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"}
            };


            while (count <= 15)
            {
                int r;

                r = ran.Next(1, 15);
                int x = r;
                r = ran.Next(1, 14);
                int y = r;

                if (migon[x, y] == " ")
                {
                    migon[x, y] = "#";
                }
                count++;
            }

            for (int i = 0; i <= migon.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= migon.GetUpperBound(1); j++)
                {
                    Console.Write(migon[i, j]);
                }
                Console.WriteLine();
            }


            while (migon[p1, q1] != "B" || migon[p2, q2] != "B" || migon[p3, q3] != "B"|| migon[p4, q4] != "B") 
            {
                char s = Console.ReadKey().KeyChar;
               
                if (s == 'w')
                {
                    if (migon[x1 - 1, y1] == " ")
                    {
                            migon[x1, y1] = " ";
                            x1--;
                            migon[x1, y1] = "O";
                    }
                    else if (migon[x1 - 1, y1] == "B")
                    {
                        if (migon[x1 - 2, y1] == " ")
                        {
                           migon[x1 - 2, y1] = "B";
                           migon[x1, y1] = " ";
                           x1--;
                           migon[x1, y1] = "O";
                        }
                        else if (migon[x1 - 2, y1] == "G")
                        {
                           migon[x1 - 2, y1] = "B";
                           migon[x1, y1] = " ";
                           x1--;
                           migon[x1, y1] = "O";
                        }
                    }
                }
                if (s == 's')
                {
                    if (migon[x1 + 1, y1] == " ")
                    {
                        migon[x1, y1] = " ";
                        x1++;
                        migon[x1, y1] = "O";
                    }
                    else if (migon[x1 + 1, y1] == "B")
                    {
                        if (migon[x1+2, y1 ] == " ")
                        {
                            migon[x1+2, y1 ] = "B";
                            migon[x1, y1] = " ";
                            x1++;
                            migon[x1, y1] = "O";
                        }
                        else if (migon[x1+ 2, y1 ] == "G")
                        {
                            migon[x1+ 2, y1 ] = "B";
                            migon[x1, y1] = " ";
                            x1++;
                            migon[x1, y1] = "O";
                        }
                    }
                }
                if (s == 'a')
                {
                    if (migon[x1, y1 - 1] == " ")
                    {
                        migon[x1, y1] = " ";
                        y1--;
                        migon[x1, y1] = "O";
                    }
                    else if (migon[x1, y1 - 1] == "B")
                    {
                        if (migon[x1, y1 - 2] == " ")
                        {
                            migon[x1, y1 - 2] = "B";
                            migon[x1, y1] = " ";
                            y1--;
                            migon[x1, y1] = "O";
                        }
                        else if (migon[x1, y1 - 2] == "G")
                        {
                            migon[x1, y1 - 2] = "B";
                            migon[x1, y1] = " ";
                            y1--;
                            migon[x1, y1] = "O";
                        }
                    }
                }
                if (s == 'd')
                {
                    if (migon[x1, y1 + 1] == " ")
                    {
                        migon[x1, y1] = " ";
                        y1++;
                        migon[x1, y1] = "O";
                    }
                    else if (migon[x1, y1 + 1] == "B")
                    {
                        if (migon[x1, y1 + 2] == " ")
                        {
                            migon[x1, y1 + 2] = "B";
                            migon[x1, y1] = " ";
                            y1++;
                            migon[x1, y1] = "O";
                        }
                        else if (migon[x1, y1 + 2] == "G")
                        {
                            migon[x1, y1 + 2] = "B";
                            migon[x1, y1] = " ";
                            y1++;
                            migon[x1, y1] = "O";                       
                        }
                    }
                }

               
                Console.Clear();            
                for (int i = 0; i <= migon.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= migon.GetUpperBound(1); j++)
                    {
                        Console.Write(migon[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("恭喜破關 enter to continue");
            Console.Read();

        }
    }
}
