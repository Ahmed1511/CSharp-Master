using System;
using System.Reflection;

namespace CAReflectionInvokeMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("1234","Isam.A",500);
            Type t = typeof(BankAccount);
            // invoke Account.Deposit()
            Type[] parameterType = { typeof(decimal) };
            MethodInfo method = t.GetMethod("Deposit");
            method.Invoke(account , new object[] { 500m });
            Console.WriteLine(account);
            Console.ReadKey();
        }
    }

    public class BankAccount
    {
        private string accountNo;
        private string holder;
        private decimal balance;

        public string AccountNo => accountNo;
        public string Holder => holder;
        public decimal Balance => balance;

        public event EventHandler OnNigativeBalance;
        public BankAccount(string accountNo, string holder, decimal balance)
        {
            this.accountNo = accountNo;
            this.holder = holder;
            this.balance = balance;
        }

        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            this.balance -= amount;
            if (this.balance < 0)
            {
                this.OnNigativeBalance.Invoke(this, null);
            }
        }

        public override string ToString()
        {
            return $"{{Account No : {accountNo} , Holder : {holder} , Balance :${balance}}}";
        }
    }
}
