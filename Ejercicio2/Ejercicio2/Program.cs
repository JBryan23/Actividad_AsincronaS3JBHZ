//Ejercicio 2:
//Utilizando los conocimientos de declaración e inicialización de arreglos, hacer lo siguiente:
//1.Declarar un arreglo con el tamaño de su nombre completo (nombres y apellidos, como mínimo 1 nombre y 1 apellido) e inicializarlo con sus valores respectivos
//(nombres y apellidos).
//2.Imprimir cada uno de los valores de sus posiciones.
//3. Almacenar la longitud o tamaño del arreglo en una variable.
//4. Imprimir el tamaño del arreglo y sus respectivos valores

String[] MiNombreCompleto = { "Josue", "Bryan", "Hernandez", "Zelaya" };
Console.WriteLine("VALORES");
foreach (var arreglo  in MiNombreCompleto) { Console.WriteLine(arreglo); }
int Tamaño_Arreglo = MiNombreCompleto.Length;
Console.WriteLine($"El tamaño de arreglo: {Tamaño_Arreglo}");
Console.WriteLine("El tamaño de arreglo junto sus valores");
for (int i = 0; i < Tamaño_Arreglo; i++) { Console.WriteLine($"Su posicion es {i + 1}->{MiNombreCompleto[i]}"); }