using System;
namespace lesson3
{
    public class Programm
    {
        static void Main()
        {

            decimal userBalance = 300m;
            string basket = "";
            string errorBalanceMessage = "you dont have enough!";

        start: //Метка "start"

            System.Console.WriteLine($"Your balance - {userBalance}");

            if (userBalance <= 0)
            {
                System.Console.WriteLine(errorBalanceMessage);
                goto End;
            };

            System.Console.WriteLine("" +
            " {1} Cola - 10 somon\n" +
            " {2} Snickers - 7 somon \n" +
            " {3} Mars - 9 somon\n" +
            " {4} M&Ms - 4 somon\n" +
            " {5} Chips - 14 somon\n" +
            " {6} Exit\n" +
            "Your choise (1-6):");

            int choice = int.Parse(Console.ReadLine());

            // goto start; //идти к метке "start"
            switch (choice)
            {
                case 1:
                    {
                        if (userBalance - 10 >= 0)
                        {
                            basket += "Cola,";
                            userBalance -= 10;
                        }
                        else
                        {
                            System.Console.WriteLine(errorBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Continue: Yes/No");
                        if (Console.ReadLine().ToLower() == "Yes") goto start;
                    }
                    break;
                    case 2:
                    {
                        if (userBalance - 7 >= 0)
                        {
                            basket += "Snickers,";
                            userBalance -= 7;
                        }
                        else
                        {
                            System.Console.WriteLine(errorBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Continue: Yes/No");
                        if (Console.ReadLine().ToLower() == "Yes") goto start;
                    }
                    break;
                    case 3:
                    {
                        if (userBalance - 9 >= 0)
                        {
                            basket += "Mars,";
                            userBalance -= 9;
                        }
                        else
                        {
                            System.Console.WriteLine(errorBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Continue: Yes/No");
                        if (Console.ReadLine().ToLower() == "Yes") goto start;
                    }
                    break;
                    case 4:
                    {
                        if (userBalance - 4 >= 0)
                        {
                            basket += "M&M's,";
                            userBalance -= 4;
                        }
                        else
                        {
                            System.Console.WriteLine(errorBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Continue: Yes/No");
                        if (Console.ReadLine().ToLower() == "Yes") goto start;
                    }
                    break;
                    case 5:
                    {
                        if (userBalance - 14 >= 0)
                        {
                            basket += "Chips,";
                            userBalance -= 14;
                        }
                        else
                        {
                            System.Console.WriteLine(errorBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Continue: Yes/No");
                        if (Console.ReadLine().ToLower() == "Yes") goto start;
                    }
                    break;
                case 6: goto End;
                break;
                default: goto start;                
            }

        End:
            System.Console.WriteLine($"Your choice:{basket}\n Your balance:{userBalance}");
            Console.ReadKey();
        }
    }
}