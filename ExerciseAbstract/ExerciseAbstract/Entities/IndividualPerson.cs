namespace ExerciseAbstract.Entities    
{
    class IndividualPerson : Person
    {
        public float HealthExpenditures { get; set; }

        public IndividualPerson()
        {
        }

        public IndividualPerson(string name, float annualncome, float healthExpenditures)
            : base(name, annualncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override float AnnualTaxes()
        {
            float tax;
            float taxPercent;

            if (Annualncome > 20000)
                taxPercent = 0.25f;
            else
                taxPercent = 0.15f;

            tax = (Annualncome * taxPercent) - (HealthExpenditures * 0.5f);

            return tax;
        }
    }
}
