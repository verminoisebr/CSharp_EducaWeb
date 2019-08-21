namespace ExerciseAbstract.Entities
{
    class CompanyPerson : Person
    {
        public int NumberOfEmployees { get; set; }

        public CompanyPerson()
        {
        }

        public CompanyPerson(string name, float annualIncome, int numberOfEmployees)
            : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override float AnnualTaxes()
        {
            float taxPercent;
            float tax;

            if (NumberOfEmployees > 10)
                taxPercent = 0.14f;
            else
                taxPercent = 0.16f;

            tax = Annualncome * taxPercent;

            return tax;
        }
    }
}
