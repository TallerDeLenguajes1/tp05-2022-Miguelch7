// See https://aka.ms/new-console-template for more information
Console.WriteLine("========== Calculadora V1 ==========");

int ejecucion = 1, operacion;
double a, b = 0, c, d, resultado = 0;
string nombreOperacion = "";

do {
    do {
        Console.WriteLine("Elija una operación a realizar: (1: Sumar | 2: Restar | 3: Multiplicación | 4: División | 5: Valor Absoluto | 6: Cuadrado | 7: Raiz cuadrada | 8: seno | 9: Coseno | 10: Parte entera de un decimal)");
        operacion = Convert.ToInt32(Console.ReadLine());
    } while (operacion < 0 || operacion > 10);

    Console.WriteLine("Ingrese un número");
    a = Convert.ToDouble(Console.ReadLine());

    if (operacion < 5) {
        Console.WriteLine("Ingrese otro número");
        b = Convert.ToDouble(Console.ReadLine());
    };

    switch (operacion)
    {
        case 1:
            resultado = Sumar(a, b);
            nombreOperacion = "Suma";
            break;
        case 2:
            resultado = Restar(a, b);
            nombreOperacion = "Resta";
            break;
        case 3:
            resultado = Multiplicar(a, b);
            nombreOperacion = "Multiplicacion";
            break;
        case 4:
            resultado = Dividir(a, b);
            nombreOperacion = "División";
            break;
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

    if (operacion < 5) {
        Console.WriteLine($"El resultado de la { nombreOperacion } entre { a } y { b } es: { resultado }");
    } else {
        Console.WriteLine($"El resultado de el/la { nombreOperacion } de { a } es: { resultado }");
    };

    Console.WriteLine("Quiere seguir operando? (1: Si | 0: No)");
    ejecucion = Convert.ToInt32(Console.ReadLine());

} while (ejecucion == 1);

Console.WriteLine("Ingrese otro número");
c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese otro número");
d = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"El máximo entre { c } y { d } es: { Math.Max(c, d) } ");
Console.WriteLine($"El mínimo entre { c } y { d } es: { Math.Min(c, d) } ");

// Funciones
double Sumar(double a, double b) {
    return a + b;
};

double Restar(double a, double b) {
    return a - b;
};

double Multiplicar(double a, double b) {
    return a * b;
};

double Dividir(double a, double b) {

    if (b == 0) {
        Console.WriteLine("No se puede dividir por 0");
        return 0;
    };

    return a / b;
};
