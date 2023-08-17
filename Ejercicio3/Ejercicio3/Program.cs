//Ejercicio 3:
//1.Declarar un arreglo de 10 posiciones con los valores de Perro, Casa, Cebra, Tortuga, Burro, Mar, Dedo, Tasa, Nube, Sol
//2. Utilizar una estructura de bucle para mostrar el arreglo con sus posiciones inicializadas.
//3. Utilizar la función Sort para ordenar el arreglo.
//4. Imprimir el arreglo de manera ordenada

Console.WriteLine("Palabras no ordenadas");
string[] palabras = new string[10] { "Perro", "Casa", "Cebra", "Tortuga", "Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol" };
for (int p= 0; p < palabras.Length; p++)
{
    Console.WriteLine($"Posicion {p+1}-> { palabras[p]}") ;
}
Console.WriteLine();
System.Array.Sort(palabras);
Console.WriteLine("Palabras ordenadas: ");
foreach (var b in palabras) { Console.WriteLine(b); }
Console.WriteLine("\n");
