namespace ExerciciosClasse
{
    class Aluno
    {
        string Nome = "Alex Green";
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double NotaRestante()
        {
            return 60.0 - NotaFinal();
        }

        public override string ToString()
        {
            return "Nome do aluno: " + Nome;
        }
    }
}
