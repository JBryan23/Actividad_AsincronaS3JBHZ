//Ejercicio 1:
//Utilizando los conocimientos de declaración e inicialización de arreglos, hacer lo siguiente:
//1.Declarar un arreglo sin tamaño que almacene números enteros o flotantes (según su elección).
//2.Pedir a través del teclado el tamaño del arreglo declarado en el punto 1. (cómo mínimo un tamaño de 5 posiciones).
//3.Utilizando las estructuras de bucle, con un ciclo for/while (el que UD considere),pedir el ingreso de cada uno de los valores del arreglo. utilizando algunas funciones
//como: Console.WriteLine(), Console.ReadLine(), Convert.ToInt32 y otras que ud considere necesarias.
//4. Imprimir cada uno de los valores del arreglo.


int number;
do { Console.WriteLine("Por favor ingrese el tamaño para almacenarlo, minimo 5 "); }
while (!int.TryParse(Console.ReadLine(), out number) || number < 5);
double[] a = new double[number];
for (int i = 0; i < a.Length; i++) { Console.WriteLine("Por favor ingrese el valor"); a[i] = double.Parse(Console.ReadLine());}
Console.WriteLine("Los valores ingresados son:  ");
foreach(int i in a) { Console.WriteLine($">{i}<"); }