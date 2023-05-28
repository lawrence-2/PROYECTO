namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                //Menu de opciones 
                Console.Clear();
                Console.WriteLine("----MENU del restaurante----");
                Console.WriteLine("----EL INGE----");
                Console.WriteLine("1-) DESAYUNOS 1");
                Console.WriteLine("2-) COMIDAS 2");
                Console.WriteLine("3-) BEBIDAS 3");
                Console.WriteLine("4-) OPCION DE SALIR 4");
                Console.WriteLine("ELIGA UNA OPCION");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("HAS ELEGIDO EL DESAYUNO 1");
                        Console.WriteLine("presiona cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("HAS ELEGIDO COMIDA 2");
                        Console.WriteLine("presiona cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("HAS ELEGIDO BEBIDAS 3");
                        Console.WriteLine("presiona cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Esta seguro que desea salir?");
                        Console.WriteLine("si/no");
                        string deside = Console.ReadLine();
                        if (deside == "si")
                        {
                            continuar = false;
                        }
                        break;
                    default:
                        Console.WriteLine("ERROR, VOLVER A INTENTAR, EROR . :");
                        break;