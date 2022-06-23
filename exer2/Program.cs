using exer2;

Console.WriteLine("Insira o triângulo:");

double lado1 = Double.Parse(Console.ReadLine());
double lado2 = Double.Parse(Console.ReadLine());
double lado3 = Double.Parse(Console.ReadLine());;

Triangulo triangulo = new Triangulo(lado1, lado2, lado3);

triangulo.Tipo(triangulo);


