// See https://aka.ms/new-console-template for more information
Console.WriteLine("========== Calculadora V1 ==========");

int ejecucion = 1, operacion;
double a, b, c, resultado = 0;
string nombreOperacion = "";

Console.WriteLine("Ingrese un número");
a = Convert.ToDouble(Console.ReadLine());

do {
    do {
        Console.WriteLine("Elija una operación a realizar: (5: Valor Absoluto | 6: Cuadrado | 7: Raiz cuadrada | 8: seno | 9: Coseno | 10: Parte entera de un decimal)");
        operacion = Convert.ToInt32(Console.ReadLine());
    } while (operacion < 0 && operacion > 10);

    switch (operacion)
    {
        case 5:
            resultado = Math.Abs(a);
            nombreOperacion = "Valor Absoluto";
            break;
        case 6:
            resultado = Math.Pow(a, 2);
            nombreOperacion = "Cuadrado";
            break;
        case 7:
            resultado = Math.Sqrt(a);
            nombreOperacion = "Raíz cuadrada";
            break;
        case 8:
            resultado = Math.Sin(a);
            nombreOperacion = "Seno";
            break;
        case 9:
            resultado = Math.Cos(a);
            nombreOperacion = "Coseno";
            break;
        case 10:
            resultado = Convert.ToInt32(a);
            nombreOperacion = "Parte entera";
            break;
        default:
            break;
    };

    Console.WriteLine($"El resultado de el/la { nombreOperacion } de { a } es: { resultado }");

    Console.WriteLine("Quiere seguir operando? (1: Si | 0: No)");
    ejecucion = Convert.ToInt32(Console.ReadLine());

} while (ejecucion == 1);

Console.WriteLine("Ingrese otro número");
b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese otro número");
c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"El máximo entre { b } y { c } es: { Math.Max(b, c) } ");
Console.WriteLine($"El mínimo entre { b } y { c } es: { Math.Min(b, c) } ");