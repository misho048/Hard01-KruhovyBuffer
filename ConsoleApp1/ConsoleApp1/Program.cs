using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularBuffer buffer = new CircularBuffer();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1:Push\n" +
                    "2:Force Push\n" +
                    "3:Pop\n" +
                    "4:Write\n");

                int choice=Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter char to push");
                            if (buffer.Push(Convert.ToChar(Console.ReadLine())))
                            {
                                Console.WriteLine("truee");

                            }
                            else
                            {
                                Console.WriteLine("False");
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter char to Forcepush");
                            buffer.ForcePush(Convert.ToChar(Console.ReadLine()));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"last char is:{buffer.Pop()}");
                            
                            break;
                        }
                    case 4:
                        {
                            buffer.WriteBuffer();
                            break;
                        }

                    default:
                        {
                            break;
                        }

                }
                Console.ReadLine();
            }
        }
    }
}
