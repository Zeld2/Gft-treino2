namespace exer2
{
    public class Triangulo
    {
        public double Lado1 { get; set; }

        public double Lado2 { get; set; }

        public double Lado3 { get; set; }

        public Triangulo(double lado1, double lado2, double lado3)
        {
            if (Validate(lado1, lado2, lado3))
            {
                this.Lado1 = lado1;
                this.Lado2 = lado2;
                this.Lado3 = lado3;
            }
            else throw new Exception("Não é um triângulo");
        }


        public static bool Validate(double lado1, double lado2, double lado3)
        {
            if (lado1 > Math.Abs(lado2 - lado3) && lado1 < lado2 + lado3) return true;
            if (lado2 > Math.Abs(lado1 - lado3) && lado2 < lado1 + lado3) return true;
            if (lado3 > Math.Abs(lado2 - lado1) && lado3 < lado2 + lado1) return true;
            return false;
        }

        public void Tipo(Triangulo triangulo)
        {
            if (triangulo.Lado1 == triangulo.Lado2 && triangulo.Lado1 == triangulo.Lado3)
            {
                System.Console.WriteLine("Equilátero");
                return;
            }
            if (triangulo.Lado1 == triangulo.Lado2 || triangulo.Lado1 == triangulo.Lado3 || triangulo.Lado2 == triangulo.Lado3)
            {
                System.Console.WriteLine("Isóceles");
                return;
            }
            if (triangulo.Lado1 != triangulo.Lado2 && triangulo.Lado1 != triangulo.Lado3 && triangulo.Lado2 != triangulo.Lado3)
            {
                System.Console.WriteLine("Escaleno");
                return;
            }
            System.Console.WriteLine("Não é triângulo");
        }
    }

}
