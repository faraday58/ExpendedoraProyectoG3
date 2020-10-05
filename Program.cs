using System;

namespace ExpendedoraProyectoG3
{
    class Program
    {
        static void Main()
        {
            //Implementacion de la clase
            //Una clase abstracta no se puede instanciar
            //Expendedora expendedora = new Expendedora(); ya no es posible porque Expendedora es Abstracta.

            Snack miPrimerExoendedora = new Snack(); //Para crear mi primer prototipo, el new es para indicar que se mandara a llamar el contructor
            Console.WriteLine("Ingrese la temperatura de la Expendedora");
            byte temperatura = byte.Parse(Console.ReadLine());
            for(int i=0; i < temperatura; i++)
            {
                miPrimerExoendedora.ElevarTemperatura();
            }
            miPrimerExoendedora.MostrarTemperatura();

            //Expendedora miSegundaExpendedora = new Expendedora();
            Cafe miCafe = new Cafe();
            Console.WriteLine("¿Desea entrar en modo mantenimiento (s/n) ");
            char selecccionM = char.Parse(Console.ReadLine());
            bool mantenimiento = false;
            if( selecccionM == 's'    )
            {
                mantenimiento = true;
            }
            else
            {
                mantenimiento = false;
            }
            Cafe cafeMantenimiento = new Cafe(mantenimiento);


        }
    }
}
