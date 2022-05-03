namespace CAinhertance
{
    public class Manager : Employee
    {
        private decimal AllowenceRate = 0.05m;

        public Manager(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {

        }
        protected override decimal Calculate()
        {
            return base.Calculate() + (base.Calculate() * AllowenceRate);
        }

        private decimal CalculateAllownce()
        {
            return base.Calculate() * AllowenceRate;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nAllownce {CalculateAllownce()}" +
                $"\nNet Salary {this.Calculate()}";
        }
    }
}
