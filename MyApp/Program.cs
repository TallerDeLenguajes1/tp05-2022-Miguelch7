// See https://aka.ms/new-console-template for more information
Console.WriteLine("========== Ejercicio 1 ==========");
Console.WriteLine("Ingrese un número: ");

int numero = Convert.ToInt32(Console.ReadLine());

int numeroInvertido = 0, ultimoDigito = 0;

while (numero > 0 && numero != 0) {
    ultimoDigito = numero % 10;
    numero = numero / 10;
    numeroInvertido = numeroInvertido * 10 + ultimoDigito;
};

Console.WriteLine($"El número invertido es: {numeroInvertido}");
