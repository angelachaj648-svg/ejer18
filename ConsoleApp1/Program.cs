int opcion;
do
{
	Console.WriteLine("menu");
	Console.WriteLine("1 saludo");
	Console.WriteLine("2 numero aleatorio");
	Console.WriteLine("3 0 salir");
	opcion = int.Parse(Console.ReadLine());
	switch (opcion)
	{
		case 1:
			Console.WriteLine("Hola bienvenido");
			break;
		case 2:
			int numero = int.Parse(Console.ReadLine());
			Console.WriteLine("numero aleatorio:" + numero);
			break;
		case 3:
			Console.WriteLine("Saliendo del progrma ");
			break;
		default:
			Console.WriteLine("Opcion no valida ");
			break;
	}
	Console.WriteLine();
}while (opcion != 0);
