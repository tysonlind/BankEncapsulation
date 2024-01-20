namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount tysonsAccount = new BankAccount();
            tysonsAccount.Deposit(15.23);
            Console.WriteLine(tysonsAccount.GetBalance());
            tysonsAccount.Deposit(232.23);
            Console.WriteLine(tysonsAccount.GetBalance());
        }
    }
}
