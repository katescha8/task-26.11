using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using ClassWork11;


namespace ClassWork11
{
    class Program
    {
        public class Bank
        {
            public BankAccount CreateAccount()
            {
                BankAccount opened = new BankAccount();
                accounts[opened.Number()] = opened;
                return opened;
            }
            public void DeleteAccount(long number)
            {
                accounts.Remove(accounts[number]);
            }
            private Hashtable accounts = new Hashtable();
        }
        public class BankAccount
        {
            private long number;
            internal BankAccount() { Generic(); }
            public void Generic()
            {
                Random r = new Random();
                number = r.NextInt64(1000000000000000, 10000000000000000);
            }
            public long Number() { return number; }
        }
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            BankAccount bankacc1 = bank.CreateAccount();
            BankAccount bankacc2 = bank.CreateAccount();
            bank.DeleteAccount(bankacc1.Number());
            Console.WriteLine(bankacc1.Number());
        }
    }
}