Console.WriteLine("Palabras no ordenadas");
string[] palabras = new string[10] { "Perro", "Casa", "Cebra", "Tortuga", "Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol" };
for (int p = 0; p < palabras.Length; p++)
{
    Console.WriteLine($"Posicion {p + 1}-> {palabras[p]}");
}
Console.WriteLine();
System.Array.Sort(palabras);
Console.WriteLine("Palabras ordenadas: ");
foreach (var b in palabras) { Console.WriteLine(b); }
Console.WriteLine("\n");


//Ejercicio 4:
//Utilizando el ejemplo del ejercicio anterior hacer lo siguiente.
//1. Utilizar la función BinarySearch para encontrar la posición de las palabras Sol, Dedo y Casa
//2. Imprimir cada una de las posiciones donde se encontraron las palabras.


Console.WriteLine("BinarySearch");
String[] Palabras_De_Buscar = { "Sol", "Dedo", "Casa" };
foreach (String buscar in  Palabras_De_Buscar) { int La_Posicion = Array.BinarySearch(palabras, buscar); 
if (La_Posicion >= 0) { Console.WriteLine($"La palabra {buscar} se encuentra en la posicion {La_Posicion}"); }}