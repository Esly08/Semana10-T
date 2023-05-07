namespace EjerTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control de temperatura");
            Console.WriteLine("Ingrese la cantidaad de días a registrar");
            int dias = int.Parse(Console.ReadLine());

            //Creación del arreglo
            double[] temperaturaDias = new double[dias];

            for (int i = 0; i < temperaturaDias.Length; i++)
            {
                Console.WriteLine("Ingrese la temperatura del día" + (i + 1) + "; "); //Se le suma 1 para que no muestre el 0 en la consola.
                double dato = double.Parse(Console.ReadLine()); //pide el dato
                temperaturaDias[i] = dato;
            }

            //Mostrar todos los datos ingresados
            for (int i = 0; i < temperaturaDias.Length; i++)
            {
                Console.WriteLine("Día " + (i + 1) + ": " + temperaturaDias[i] + " °C ");
            }

            //Obtener la mayor y menor temperatura dada
            double mayor = temperaturaDias[0];
            int diaMayor = 0;

            for (int i = 0; i < temperaturaDias.Length; i++)
            {
                if (temperaturaDias[i] > mayor)
                {
                    mayor = temperaturaDias[i];
                    diaMayor = i;
                }
            }

            Console.WriteLine("El día con mayor temperatura fue: Día " + (diaMayor + 1) + "con" + mayor + " °C ");

            double menor = temperaturaDias[0];
            double diaMenor = 0;

            for (int i = 0; i < temperaturaDias.Length; i++)
            {
                if (temperaturaDias[i] > menor)
                {
                    menor = temperaturaDias[i];
                    diaMenor = i;
                }
            }

            Console.WriteLine("El día con mayor temperatura fue: Día " + (diaMenor + 1) + "con" + menor + " °C ");

            //Promedio de todas las temperaturas
            double sumaTemperaturas = 0;

            for (int i = 0; i < temperaturaDias.Length; i++)
            {
                sumaTemperaturas += temperaturaDias[i];
            }

            double promedioTemperatura = sumaTemperaturas / temperaturaDias.Length;
            Console.WriteLine("El promedio es: " + promedioTemperatura + " °C ");

            //Conversión de grados a Fahrenheit
            Console.WriteLine("Desea convertir los grados a Fahrenheit? si/no");
            

           
        
        }
    }
}