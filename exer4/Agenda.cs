namespace exer4
{
    public class Agenda
    {
        public List<Pessoa> Pessoas { get; set; }

        public Agenda()
        {
          this.Pessoas = new List<Pessoa>();   
        }
        
        public void Inserir(Pessoa Pessoa)
        {
            Pessoas.Add(Pessoa);
        }
        public void Remover(Pessoa Pessoa)
        {
            Pessoas.Remove(Pessoa);
        }
        public void Editar(Pessoa Pessoa)
        {
            System.Console.WriteLine("Novo telefone: ");
            Pessoa.NumeroTelefone = Console.ReadLine();
            System.Console.WriteLine("Nova idade: ");
            Pessoa.Idade = Int32.Parse(Console.ReadLine());
        }
        
    }
}