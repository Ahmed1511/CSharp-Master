namespace CAinhertance
{
    public class SalesMan : Employee
    {
        protected decimal SalesVolume { get; set; }

        protected decimal Commission { get; set; }
        public SalesMan(int id, string name, decimal loggedHours, decimal wage,decimal salesVolum,decimal commission) : base(id, name, loggedHours, wage)
        {
            this.SalesVolume = salesVolum;
            this.Commission = commission;

        }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }

        private decimal CalculateBonus()
        {
            return SalesVolume * Commission;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"]nCommission{Commission}" +
                $"\nBonus {CalculateBonus()}" +
                $"\nNet Salary {this.Calculate()}";
        }
    }
}
