//Ejercicio 5:
//1.Declarar un arreglo con los valores 4, 10, 45, -67, -7, 25, 89, 64
//2. imprimir el arreglo en ese orden
//3. Utilizar la función Reverse e imprimir el arreglo.
//4. Utilizar la función Sort e imprimir el archivo

int[] valores_inicial = { 4, 10, 45, -67, -7, 25, 89, 64 };
Console.WriteLine("Valores incial sin arreglos:");
foreach (var i in valores_inicial)
    Console.WriteLine(i);
Console.WriteLine();

System.Array.Reverse(valores_inicial);
Console.WriteLine("Valores con Reverse:");
foreach (var Numero_reversa in valores_inicial)
    Console.WriteLine(Numero_reversa);
Console.WriteLine();


System.Array.Sort(valores_inicial, 0, valores_inicial.Length);
Console.WriteLine("Valores con sort:");
foreach (var Numero_Ordenado in valores_inicial) { Console.WriteLine(Numero_Ordenado); }
Console.WriteLine();
