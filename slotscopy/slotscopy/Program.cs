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

            int totalMoney = 100;

            while (totalMoney > 0)
            {
                Console.WriteLine($"your current balance: {totalMoney} euros");
                Console.Write("place your bet: ");
                int bet = int.Parse(Console.ReadLine());


                if (bet > totalMoney)
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


                Console.WriteLine($"Rolled: {sim1} {sim2} {sim3}");


                if (sim1 == sim2 && sim2 == sim3)
                {

                    totalMoney += bet;
                    Console.WriteLine($"Congratulations! You won {bet * 2 + bet} euros. Your new balance is {totalMoney} euros.");
                }
                else
                {

                    totalMoney -= bet;
                    Console.WriteLine($"Sorry! You lost your bet. Your new balance is {totalMoney} euros.");
                }


                if (totalMoney <= 0)
                {
                    Console.WriteLine("Game over! You ran out of money.");
                    break;
                }

                Console.WriteLine("Do you want to play again? (yes/no)");
                string playagain = Console.ReadLine();
                if (playagain.ToLower() == "no")
                {
                    break;
                }



            }











        }
    }
}

