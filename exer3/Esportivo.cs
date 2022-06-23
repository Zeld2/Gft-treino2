namespace exer3
{
    public class Esportivo : Automovel
    {
        public Esportivo()
        {
            this.Combustivel = "Gasolina";
        }

        public override void TipoCombustivel()
        {
            System.Console.WriteLine(this.Combustivel);
        }
    }
}