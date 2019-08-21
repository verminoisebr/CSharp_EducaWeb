using System.Globalization;
namespace ExerciseAbstract.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public float Annualncome { get; set; }

        public Person()
        {
        }
        public Person(string name, float annualncome)
        {
            Name = name;
            Annualncome = annualncome;
        }

        public abstract float AnnualTaxes();

        public override string ToString()
        {
            return Name + ": $ " + AnnualTaxes().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
