using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Topic_5___Descision_Structues_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Banking Machine
            Console.WriteLine("First stop on today's journey, the bank! \nBlorb says you need to get your money in order to properly enjoy your vacation.");
            BankOfBlob();
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();
            ParkingGarage();
            Console.ReadLine();

            
        }

        static void BankOfBlob()
        {
            string bankFunction, billPayment;
            bool realValue = false, paymentFunction = false;
            double balance = 150, transaction;
            balance = balance - .75;
            
            while (!realValue)
               {
                Console.WriteLine("");
                Console.WriteLine("Welcome to the world of economics 101, the bank!\nHow'd you like to start today: A) Deposit  B) Withdrawal  C) Bill Payment D) Account balance ");
                bankFunction = Console.ReadLine().ToLower().Trim();
                while (bankFunction == null)
                {
                    Console.WriteLine("You want to try a real value this time?");
                    bankFunction = Console.ReadLine().ToLower().Trim();
                }
                Random generator = new Random();
               
                    if (bankFunction == "a")
                    {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("DEPOSIT");
                    Console.WriteLine();
                    Console.WriteLine("How much would you like to deposit today?");
                    transaction = Convert.ToDouble(Console.ReadLine());
                    while (transaction <= 0 || transaction == null)
                    {
                        Console.WriteLine("You can only deposit a positive amount blorb bucks, try again!");
                        transaction = Math.Round(Convert.ToDouble(Console.ReadLine()),2);
                    }
                    balance = balance + transaction;
                    realValue = true;

                    }

                    if (bankFunction == "b")
                    {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("WITHDRAWAL");
                    Console.WriteLine();
                    Console.WriteLine($"You have{balance}$ in your account.");
                    Console.WriteLine("How much would you like to withdraw today?");
                    transaction = Convert.ToDouble(Console.ReadLine());
                    while (transaction <= 0 || transaction > balance)
                    {
                        Console.WriteLine("You can only withdraw a positive amount blorb bucks equal to your account balance");
                        transaction = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
                    }
                    balance = (balance - transaction);
                    realValue = true;
                    }

                    if (bankFunction == "c")
                    {

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("BILL PAYMENT");
                    Console.WriteLine();
                    transaction = Math.Round(Convert.ToDouble(generator.Next(0,150)) + generator.NextDouble(), 2);
                    while (!paymentFunction)
                    {
                        Console.WriteLine($"It was seem you owe {transaction}$\nWould you like to pay your bill today?\nY or N");
                        billPayment = Console.ReadLine().ToLower().Trim();
                        if (transaction <= balance)
                        {
                            if (billPayment == "y")
                            {
                                Console.WriteLine("Bill balance: 0$");
                                balance = Math.Round((balance - transaction),2);
                                Console.WriteLine("Enjoy your vacation chump ");
                                paymentFunction = true;

                            }
                            if (billPayment == "n")
                            {
                                Console.WriteLine($"Bill balance: {Math.Round((transaction * 1.1), 2)}$");
                                Console.WriteLine($"Blorb has been angered, and the officials have been notified \nI'd get moving if I was you!");
                                paymentFunction = true;
                            }
                            else if(billPayment != "y" && billPayment != "n")
                            {
                                Console.WriteLine("INVALID INPUT.");
                            }
                        }
                        else
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("Insufficient funds, Get your money up not your funny up :D");
                        }
                        
                    }
                    realValue = true;
                }

                    if (bankFunction == "d")
                    {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("BALANCE UPDATE");
                    realValue = true;
                }
                    if (realValue ==false)
                     {
                    Console.WriteLine("It appears that your value is not on our menu, would you like to try another?");
                     }

                
            }
            Console.WriteLine($"You have {balance}$ left in your account");
            Console.ReadLine();

            
        }
        static void ParkingGarage()
        {
            double bill = 4.00, hours;
                int minutes;
            Console.WriteLine("Lets get your wheels set in for your visit! \nHow many minutes would your like to park for? (whole numbers only)");
            minutes = Convert.ToInt32(Console.ReadLine());
            hours = (Convert.ToInt32(minutes) / 60);
            for (double i = 1; i<hours && i<18; i++)
            {
                bill = bill + 2;
            }
            Console.WriteLine($"BILL:\nHour One - 4.00$\nRemaining X{Math.Round(hours-1,0)} hours - {(bill-2)}");
            Console.ReadLine();
        }
    }
}