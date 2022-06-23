namespace exer4
{
    public class Pessoa
    {
        static int codigo = 0;
        public int Codigo { get; set; }

        public string NumeroTelefone { get; set; } 

        public int Idade { get; set; }
        

        public Pessoa(string telefone, int idade)
        {
            this.NumeroTelefone = telefone;
            this.Idade = idade;
            codigo ++;
            this.Codigo = codigo;
        }
    }
}