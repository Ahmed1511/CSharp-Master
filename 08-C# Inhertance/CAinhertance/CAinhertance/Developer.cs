namespace CAinhertance
{
    public class Developer : Employee
    {
        public bool taskCompleted { get; set; }
        private decimal commission = 0.03m;
        public Developer(int id, string name, decimal loggedHours, decimal wage,bool taskCompleted) : base(id, name, loggedHours, wage)
        {
           this.taskCompleted = taskCompleted;
        }
        protected override decimal Calculate()
        {
            return base.Calculate() + (base.Calculate() * CalculateBonus());
        }

        private decimal CalculateBonus()
        {
            if (taskCompleted)
            {
                return base.Calculate() * commission;
            }
            return 0;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nTask Completed: ${(taskCompleted ? "Yes" : "No")}" +
                $"\nBonus {CalculateBonus()}" +
                $"\nNet Salary {this.Calculate()}";
        }
    }
}
