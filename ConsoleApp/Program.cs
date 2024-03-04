double lado = 5;
double altura = 10;
double perimetro = Application.Paralelogramo.Perimetro(lado);
double area = Application.Paralelogramo.Area(lado);
double volumen = Application.Cuadrilatero.Volumen(area, altura);

Console.WriteLine($"El perímetro de la base de un Cuadrilatero de {lado}cm por lado es {perimetro}cm");
Console.WriteLine($"El área de la base de un Cuadrilatero de {lado}cm por lado es {area}cm2");
Console.WriteLine($"El volumen un Cuadrilatero con un área de la base de {area}cm2 y {altura}cm de altura es {volumen}cm3");


