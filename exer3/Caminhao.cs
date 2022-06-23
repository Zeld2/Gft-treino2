namespace exer3
{
    public class Caminhao : Automovel
    {
        public Caminhao()
        {
            this.Combustivel = "Diesel";
        }

        public override void TipoCombustivel()
        {
            System.Console.WriteLine(this.Combustivel);
        }
    }
}