using System.Globalization;

double a, b, c, triangulo,circulo,trapezio,quadrado,retangulo;

string[] valores = Console.ReadLine().Split(' ');

a = double.Parse(valores[0], CultureInfo.InvariantCulture);
b = double.Parse(valores[1], CultureInfo.InvariantCulture);
c = double.Parse(valores[2], CultureInfo.InvariantCulture);

triangulo = a * c / 2.0;
circulo = 3.14159 * c * c;
trapezio = (a + b) / 2.0 * c;
quadrado = b * b;
retangulo = a * b;

Console.WriteLine("TRIANGULO = " + triangulo.ToString("N3"), CultureInfo.InvariantCulture);
Console.WriteLine("TRIANGULO = " + circulo.ToString("N3"), CultureInfo.InvariantCulture);
Console.WriteLine("TRIANGULO = " + trapezio.ToString("N3"), CultureInfo.InvariantCulture);
Console.WriteLine("TRIANGULO = " + quadrado.ToString("N3"), CultureInfo.InvariantCulture);
Console.WriteLine("TRIANGULO = " + retangulo.ToString("N3"), CultureInfo.InvariantCulture);