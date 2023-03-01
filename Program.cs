namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Userden 10 - 20 arasi reqem isteyin.Eger 10 - 20 arasi olmasa sehv etdiyini bildirib davam edib etmek istemediyini sorushun.
             Davam etmek isteyirse yes yazir, daha sonra reqem yazir yeniden reqemin cut ve ya tek olmagini yoxlayin. Cutdurse cut ededdir, tekdirse tek ededdir deye ekrana cap edin.
            Davam etmek istemirse dayandirin.*/
            while (true)
            {
                Console.WriteLine("10-20 arasi reqem yazin:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number >= 10 && number <= 20)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Reqem cutdur");
                    }
                    else
                    {
                        Console.WriteLine("Reqem tekdir");
                    }
                }
                else
                {
                    Console.WriteLine("Xeta! Reqem 10-20 arasi olmalidir");
                }

                Console.WriteLine("Davam etmek isteyirsiz? (yes/no)");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "no")
                {
                    break;
                }

            }
        }
    }
}