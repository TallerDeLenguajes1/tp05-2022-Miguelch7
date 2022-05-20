// See https://aka.ms/new-console-template for more information
Console.WriteLine("========== Calculadora V1 ==========");

int ejecucion = 1, operacion, a, b, resultado = 0;
string nombreOperacion = "";

do {
    do {
        Console.WriteLine("Elija una operación a realizar: (1: Sumar | 2: Restar | 3: Multiplicación | 4: División)");
        operacion = Convert.ToInt32(Console.ReadLine());
    } while (operacion < 0 && operacion > 5);

    Console.WriteLine("Ingrese un número");
    a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese otro número");
    b = Convert.ToInt32(Console.ReadLine());

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
        default:
            break;
    };

    Console.WriteLine($"El resultado de la { nombreOperacion } entre { a } y { b } es: { resultado }");

    Console.WriteLine("Quiere seguir operando? (1: Si | 0: No)");
    ejecucion = Convert.ToInt32(Console.ReadLine());

} while (ejecucion == 1);

// Funciones
int Sumar(int a, int b) {
    return a + b;
};

int Restar(int a, int b) {
    return a - b;
};

int Multiplicar(int a, int b) {
    return a * b;
};

int Dividir(int a, int b) {

    if (b == 0) {
        Console.WriteLine("No se puede dividir por 0");
        return 0;
    };

    return a / b;
};