namespace CAinhertance
{
    public class Maintanance : Employee
    {
        private decimal HardShip = 100m;
        public Maintanance(int id, string name, decimal loggedHours, decimal wage):base( id,  name,  loggedHours,  wage)
        {

        }
        protected override decimal Calculate()
        {
            return base.Calculate() + (base.Calculate() * HardShip);
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nHardShip {HardShip}" +
                $"\nNet Salary {this.Calculate()}";
        }
    }
}
