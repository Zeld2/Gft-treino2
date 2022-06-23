using static exer1.TelefoneEncriptado;

System.Console.WriteLine("Insira a entrada:");
string expressao = Console.ReadLine();

string convertido = Conversor(expressao);

System.Console.WriteLine(convertido);