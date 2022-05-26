# Trabajo Práctico N°5

## ¿String es un tipo por valor o un tipo por referencia?

Los objetos de cadena son inmutables: no se pueden cambiar después de crearlos. Todos los métodos String y operadores de C# que parecen modificar una cadena en realidad devuelven los resultados en un nuevo objeto de cadena. En el siguiente ejemplo, cuando el contenido de s1 y s2 se concatena para formar una sola cadena, las dos cadenas originales no se modifican. El operador += crea una nueva cadena que contiene el contenido combinado. Este nuevo objeto se asigna a la variable s1 y el objeto original que se asignó a s1 se libera para la recolección de elementos no utilizados porque ninguna otra variable contiene una referencia a él.

~~~C#
Copiar
string s1 = "A string is more ";
string s2 = "than the sum of its chars.";

// Concatenate s1 and s2. This actually creates a new
// string object and stores it in s1, releasing the
// reference to the original object.
s1 += s2;

System.Console.WriteLine(s1);
// Output: A string is more than the sum of its chars.
~~~

Dado que una "modificación" de cadena es en realidad una creación de cadena, debe tener cuidado al crear referencias a las cadenas. Si crea una referencia a una cadena y después "modifica" la cadena original, la referencia seguirá apuntando al objeto original en lugar de al objeto nuevo creado al modificarse la cadena. El código siguiente muestra este comportamiento:

~~~C#
Copiar
string str1 = "Hello ";
string str2 = str1;
str1 += "World";

System.Console.WriteLine(str2);
//Output: Hello
~~~

## ¿Qué secuencias de escape tiene el tipo string?

| Secuencia de escape | Nombre de carácter |
| :---- | :---- |
| \\' | Comilla simple |
| \\" | Comilla doble |
| \\\ | Barra diagonal inversa |
| \0 | Null |
| \a | Alerta |
| \b | Retroceso |
| \f | Avance de página |
| \n | Nueva línea |
| \r | Retorno de carro |
| \t | Tabulación horizontal |
| \v | Tabulación vertical |


## ¿Qué sucede cuanto utiliza el carácter @ y $ antes de una cadena de texto?

El carácter especial $ identifica un literal de cadena como una cadena interpolada. Una cadena interpolada es un literal de cadena que puede contener expresiones de interpolación. Cuando una cadena interpolada se resuelve en una cadena de resultado, los elementos con expresiones de interpolación se reemplazan por las representaciones de cadena de los resultados de la expresión. Esta característica está disponible a partir de C# 6.

La interpolación de cadenas proporciona una sintaxis más legible y conveniente de dar formato a las cadenas. Es más fácil de leer que el formato compuesto de cadenas. Compare el ejemplo siguiente donde se usan ambas características para producir el mismo resultado:

~~~C#
string name = "Mark";
var date = DateTime.Now;

// Composite formatting:
Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
// String interpolation:
Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
// Both calls produce the same output that is similar to:
// Hello, Mark! Today is Wednesday, it's 19:40 now.
~~~

El carácter especial @ actúa como un identificador textual. Se puede usar de estas formas:

1. Para habilitar el uso de palabras clave de C# como identificadores. El carácter @ actúa como prefijo de un elemento de código que el compilador debe interpretar como un identificador en lugar de como una palabra clave de C#. En el ejemplo siguiente se usa el carácter @ para definir un identificador denominado for que se usa en un bucle for.

~~~C#
string[] @for = { "John", "James", "Joan", "Jamie" };
for (int ctr = 0; ctr < @for.Length; ctr++)
{
    Console.WriteLine($"Here is your gift, {@for[ctr]}!");
}
// The example displays the following output:
//     Here is your gift, John!
//     Here is your gift, James!
//     Here is your gift, Joan!
//     Here is your gift, Jamie!
~~~

2. Para indicar que un literal de cadena se debe interpretar literalmente. El carácter @ de esta instancia define un @.

~~~C#
string s1 = "He said, \"This is the last \u0063hance\x0021\"";
string s2 = @"He said, ""This is the last \u0063hance\x0021""";

Console.WriteLine(s1);
Console.WriteLine(s2);
// The example displays the following output:
//     He said, "This is the last chance!"
//     He said, "This is the last \u0063hance\x0021"
~~~

3. Para permitir que el compilador distinga entre los atributos en caso de conflicto de nomenclatura.

~~~C#
using System;

[AttributeUsage(AttributeTargets.Class)]
public class Info : Attribute
{
    private string information;

    public Info(string info)
    {
        information = info;
    }
}

[AttributeUsage(AttributeTargets.Method)]
public class InfoAttribute : Attribute
{
    private string information;

    public InfoAttribute(string info)
    {
        information = info;
    }
}

[Info("A simple executable.")] // Generates compiler error CS1614. Ambiguous Info and InfoAttribute.
// Prepend '@' to select 'Info' ([@Info("A simple executable.")]). Specify the full name 'InfoAttribute' to select it.
public class Example
{
    [InfoAttribute("The entry point.")]
    public static void Main()
    {
    }
}
~~~