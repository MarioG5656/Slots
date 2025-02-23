using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;

namespace Slots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            Console.WriteLine("welcome to 'Slots'");
            Console.WriteLine("In this game you start with 100 euro if you win a slot you get your money 2x if you lose you lose it all ");
            Console.WriteLine("play on your own risk 'this game may be addictive 18+'");
            Console.WriteLine("type start when you are ready");




            while (true)
            {
                string a = Console.ReadLine().ToLower();
                if (a == "start")
                {
                    Console.WriteLine("you have 100 euros have fun");
                    break;
                }
                else
                {
                    Console.WriteLine("type start to start plaing");
                }
            }
            Console.Write("plase your bets:");

            int startmoney = 100;

            while (startmoney > 0)
            {
                Console.WriteLine($"your current balance: {startmoney} euros");
                Console.Write("place your bet: ");
                int bet = int.Parse(Console.ReadLine());


                if (bet > startmoney)
                {
                    Console.WriteLine("you don't have enough money bet less");
                    continue;
                }


                Random slot = new Random();


                string sim1 = "", sim2 = "", sim3 = "";
                int roll1 = slot.Next(1, 4);
                int roll2 = slot.Next(1, 4);
                int roll3 = slot.Next(1, 4);

                sim1 = roll1 == 1 ? "🍒" : roll1 == 2 ? "🍋" : "🍉";
                sim2 = roll2 == 1 ? "🍒" : roll2 == 2 ? "🍋" : "🍉";
                sim3 = roll3 == 1 ? "🍒" : roll3 == 2 ? "🍋" : "🍉";


                Console.WriteLine($"rolled: {sim1} {sim2} {sim3}");


                if (sim1 == sim2 && sim2 == sim3)
                {

                    startmoney += bet;
                    Console.WriteLine($"Congratulations You won {bet * 2 } euros your new balance is {startmoney + bet} euros.");
                }
                else
                {

                    startmoney -= bet;
                    Console.WriteLine($"sorry you lost your bet your new balance is {startmoney} euros.");
                }


                if (startmoney <= 0)
                {
                    Console.WriteLine("game over you ran out of money.");
                    break;
                }
               
                
                    Console.WriteLine("do you want to play again? (yes/no)");
                    string playagain = Console.ReadLine();
                if (playagain.ToLower() == "yes")
                {
                    continue;
                }

                else if (playagain.ToLower() == "no")
                {
                    break;

                }

                else 
                {
                    while (true) 
                    {


                        Console.WriteLine("do you want to play again? (yes/no)");
                        string play = Console.ReadLine();
                        if (play.ToLower() == "yes")
                        {
                           break;
                        }

                        else if (play.ToLower() == "no")
                        {
                            break;

                        }

                    }
                }
                   
            }











        }
    }
}

