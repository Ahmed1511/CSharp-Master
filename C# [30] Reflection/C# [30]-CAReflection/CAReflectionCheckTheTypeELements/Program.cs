using System;
using System.Reflection;

namespace CAReflectionCheckTheTypeELements
{
    class Program
    {
        static void Main(string[] args)
        {
            //BankAccount account = new BankAccount("A123" , "Isam" , 1000);
            //account.OnNigativeBalance += Account_OnNigativeBalance;
            //account.Withdraw(500);
            //Console.WriteLine(account);

            Console.WriteLine("------Member Info---------");
            MemberInfo[] members = typeof(BankAccount).GetMembers();
            MemberInfo[] members2 = typeof(BankAccount).GetMembers(BindingFlags.Public|BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var member in members)
            {
                Console.WriteLine(member);
            }

            // Field Info
            Console.WriteLine("------Field Info---------");

            FieldInfo[] fields = typeof(BankAccount).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var field in fields)
            {
                Console.WriteLine(field);
            }

            // Poperty Info
            Console.WriteLine("------Property Info---------");

            PropertyInfo[] properties = typeof(BankAccount).GetProperties(BindingFlags.Public);
            foreach (var property in properties)
            {
                Console.WriteLine(property);
            }

            // Event Info
            Console.WriteLine("------Event Info---------");

            EventInfo[] events = typeof(BankAccount).GetEvents();
            foreach (var e in events)
            {
                Console.WriteLine(e);
            }

            // Ctor Info
            Console.WriteLine("------Ctor Info---------");

            ConstructorInfo[] ctors = typeof(BankAccount).GetConstructors();
            foreach (var ctor in ctors)
            {
                Console.WriteLine(ctor);
            }

            Console.WriteLine("------ Get Member by Name");
            MemberInfo[] constractors = typeof(BankAccount).GetMember(".ctor");
            foreach (var constractor in constractors)
            {
                Console.WriteLine(constractor);
            }
            Console.ReadKey();
        }


        private static void Account_OnNigativeBalance(object sender, EventArgs e)
        {
            var bankAccount = (BankAccount)sender;
            Console.WriteLine("Nigative Balanc!!!!");
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
            if (this.balance < 0 )
            {
                this.OnNigativeBalance.Invoke(this , null);
            }
        }

        public override string ToString()
        {
            return $"{{Account No : {accountNo} , Holder : {holder} , Balance :${balance}}}";
        }
    }
}
