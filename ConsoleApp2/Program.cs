// calcular el área, el perímetro de cuadrado, circulo, triangulo y rectangulo

public class AreasPerimetros
{
    static void Main(string[] args)
    {
        double ladoCuadrado, baseRectangulo, alturaRectangulo, lado1, lado2, lado3, alturaTriangulo, radio;
        Console.Write("Ingrese lado el cuadrado");
        ladoCuadrado = double.Parse(Console.ReadLine());
        Console.Write("Ingrese base del rectangulo");
        baseRectangulo = double.Parse(Console.ReadLine());
        Console.Write("Ingrese altura del rectangulo");
        alturaRectangulo = double.Parse(Console.ReadLine());
        Console.Write("Ingrese lado 1 del triangulo");
        lado1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese lado 2 del triangulo");
        lado2 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese lado 3 del triangulo");
        lado3 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese altura del triangulo");
        alturaTriangulo = double.Parse(Console.ReadLine());
        Console.Write("Ingrese radio del cirulo");
        radio = double.Parse(Console.ReadLine());

        double perimetroCuadrado = ladoCuadrado * 4;
        double areaCuadrado = 2 * ladoCuadrado;
        double perimetroRectangulo = 2 * baseRectangulo + 2 * alturaRectangulo; 
        double areaRectangulo = baseRectangulo * alturaRectangulo;
        double areaTriangulo = (lado1 * alturaTriangulo) / 2;
        double perimetroTriangulo = lado1 + lado2 + lado3;
        double perimetroCirculo = 2 * Math.PI * radio;
        double areaCirculo = Math.PI * Math.Pow(radio, 2);

        Console.WriteLine($" El area del cuadrado es: {areaCuadrado}");
        Console.WriteLine($"El perimetro del cuadrado es: {perimetroCuadrado}");

        Console.WriteLine($" El area del rectangulo es: {areaRectangulo}");
        Console.WriteLine($"El perimetro del rectangulo es: {perimetroRectangulo}");

        Console.WriteLine($" El area del triangulo es: {areaTriangulo}");
        Console.WriteLine($"El perimetro del triangulo es: {perimetroTriangulo}");

        Console.WriteLine($" El area de la circunferencia es: {areaCirculo}");
        Console.WriteLine($"El perimetro del circunferencia es: {perimetroCirculo}");

       
       





    }
}