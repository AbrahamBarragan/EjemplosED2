//string nombre = "  ";
//Console.WriteLine(nombre.Length);

//if(string.IsNullOrWhiteSpace(nombre))
//{
//    Console.WriteLine("string vacio");
//}
//else
//{
//    Console.WriteLine(nombre);
//}

//int numero = 9;
//string numeroConCeros = "99";
//numeroConCeros = numeroConCeros.PadLeft(3, '$');
//Console.WriteLine(numeroConCeros);


string nombre = "Abraham";
string apellido = "Barragan";
int edad = 19;

//string nombreYedad = nombre + "|" + apellido + "|" + edad;
//Console.WriteLine(nombreYedad);

//string nombreYedad = string.Format("{0}|{1}|{2}", nombre, apellido, edad);
//Console.WriteLine(nombreYedad);

//Es mas eficiente
//string nombreYedad = $"{nombre}|{apellido}|{edad}";
//Console.WriteLine(nombreYedad);

//concat

//string numeroString = "5 R";
//int numeroInt = Convert.ToInt32(numeroString);

//int numeroInt = int.Parse(, numeroString);
//Console.WriteLine(numeroInt);

//string numeroString = "5 ";
//int numeroInt = 0;
//bool pudo = int.TryParse(numeroString, out numeroInt);
//Console.WriteLine(pudo);

string cadena = "Hola Mundo";
Console.WriteLine(cadena.IndexOf(" "));