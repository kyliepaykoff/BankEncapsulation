namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {


            BankAccount account = new BankAccount();

            Console.WriteLine($"How much would you like to deposit?");
            double amountDeposited = double.Parse(Console.ReadLine());


            account.Deposit(amountDeposited);
            double userBalance = account.GetBalance();
            Console.WriteLine($"Your current balance is {userBalance, 0:c}");





        }
    }
}
