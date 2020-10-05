using System;


namespace ExpendedoraProyectoG3
{
    class Cafe:Expendedora
    {
        public Cafe()
        {
            Temperatura = 80;
            Console.WriteLine("Bienvenido \n Elige tu café");
            MostrarTemperatura();
            
        }
    }
}
