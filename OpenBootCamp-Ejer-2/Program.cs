// See https://aka.ms/new-console-template for more information
Console.Write("Introduce tu nombre: ");
string nombre = Console.ReadLine();
Console.Write("Introduce tus apellidos: ");
string apellidos = Console.ReadLine();
Console.Write("Introduce tu edad: ");
int edad = Convert.ToInt32(Console.ReadLine());
Console.Write("Cual es tu ciudad: ");
string ciudad = Console.ReadLine();
Console.Write("¿Sabes programar? si/no: ");
string sabeProgramar = Console.ReadLine();
Console.WriteLine("Hola " + nombre + " " + apellidos);
Console.WriteLine("Tienes " + edad + " años y vives en " + ciudad);
Console.WriteLine("Y además " + sabeProgramar + " sabes programar");

Console.WriteLine();
Console.WriteLine("+----------------------------------------------------------+");
Console.WriteLine();

int puertas = 5;
int ruedas = 4;
string marca = "Ford Fiesta";
int itvYear = 2022;

Console.WriteLine("El coche marca " + marca + ", tiene " + puertas + " puertas");
Console.WriteLine("También tiene: " + ruedas + " ruedas, y su última ITV fué en " + itvYear);

Console.WriteLine();
Console.WriteLine("+----------------------------------------------------------+");
Console.WriteLine();

double peso = 25.452d;
double largo = 12.45d;
string material = "madera";
string color = "caoba";

Console.WriteLine("La mesa pesa " + peso + " kilos y mide " + largo + " de largo");
Console.WriteLine("La mesa es de " + material + " y es de color " + color);

Console.WriteLine();
Console.WriteLine("+----------------------------------------------------------+");
Console.WriteLine();

int numero = 18;
char a = 'a';
bool seCumplenLasDos = numero == 18 && numero != 5;
bool seCumpleUnaDeLasDos = numero != 18 || numero == 18;

Console.WriteLine("El número " + numero + " es mayor o igual a 18 ", numero >= 18);
Console.WriteLine("El carácter " + a + " es a ", a == Convert.ToChar('a'));
Console.WriteLine("numero == 18 && numero != 5, se cumplen las dos condiciones ", seCumplenLasDos);
Console.WriteLine("numero != 18 || numero == 18, se cumple alguna codición ", seCumpleUnaDeLasDos);
Console.WriteLine("Porque numero != 18 es falso", numero != 18);
Console.WriteLine("Y numero == 18 es verdadero", numero == 18);
