using System;
using System.Net;

namespace Rock_paper
{    
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] choice = new string[3]
            {
               "rock",
               "paper",
               "scissors"
            };
            Console.WriteLine("choose between rock , paper , scissors");
            string userinput = Console.ReadLine();
            Random r = new Random();
            int computer = r.Next(choice.Length);
          
            switch (userinput)
            {

                
                case "rock":
                    if (computer == 0)
                    {
                        Console.WriteLine("computer choosed rock");
                        Console.WriteLine("Its a tie");
                    }
                    else if (computer == 1)
                    {
                        Console.WriteLine("Computer choosed paper");
                        Console.WriteLine("You lost");
                    }
                    else if (computer == 2)
                    {
                        Console.WriteLine("Computer choosed scissors");
                        Console.WriteLine("You won!");
                    }
                    break;
                case "paper":
                    if (computer == 0)
                    {
                        Console.WriteLine("computer choosed rock");
                        Console.WriteLine("you won");
                    }
                    else if (computer == 1)
                    {
                        Console.WriteLine("Computer choosed paper");
                        Console.WriteLine("its a tie");
                    }
                    else if (computer == 2)
                    {
                        Console.WriteLine("Computer choosed scissors");
                        Console.WriteLine("You lost");
                    }
                    break;
                case "scissors":
                    if (computer == 0)
                    {
                        Console.WriteLine("computer choosed rock");
                        Console.WriteLine("you lost");
                    }
                    else if (computer == 1)
                    {
                        Console.WriteLine("Computer choosed paper");
                        Console.WriteLine("You won");
                    }
                    else if (computer == 2)
                    {
                        Console.WriteLine("Computer choosed scissors");
                        Console.WriteLine("its a tie");
                    }
                    break;

               
            }




        }
    }
}
