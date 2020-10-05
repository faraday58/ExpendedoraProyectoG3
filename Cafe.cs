using System;
using System.Management.Instrumentation;

namespace ExpendedoraProyectoG3
{
    class Cafe:Expendedora
    {
        public override byte Temperatura {
            get => base.Temperatura;
            set
            {
                if( value < 60 || value > 80   )
                {
                    temperatura = 60;
                }
                else
                {
                    temperatura = value;
                }                
            }
        }


        public Cafe()
        {
            Temperatura = 80;
            Console.WriteLine("Bienvenido \n Elige tu café");
            MostrarTemperatura();
            string codigo=MostrarCodigoProducto();
            MostrarPrecio(codigo);
            tiempoDespliegue();

        }
        public Cafe(bool mantenimiento)
        {
            
            if (mantenimiento)
            {
                tiempoDespliegue();
                Console.WriteLine("Marca {0}", Marca);
                tiempoDespliegue();
                Console.WriteLine(" Modo Mantenimiento ");
                tiempoDespliegue();
            }
            else
            {
                tiempoDespliegue();
                Console.WriteLine("Marca {0}", Marca);
                tiempoDespliegue();
                Console.WriteLine("Saliendo del modo Mantenimiento");
                tiempoDespliegue();
            }

        }

        public override void MostrarPrecio(string codigo)
        {
            switch(codigo)
            {
                case "3B":
                    Console.WriteLine("Precio: {0} ", Precio + 6);
                    break;
                case "4C":
                    Console.WriteLine("Precio: {0}", Precio +7 );
                    break;
            }
        }
        public override string MostrarCodigoProducto()
        {
            Console.WriteLine("3B: Negro \n 4C: Vainilla ");
            Console.WriteLine("Ingrese el código: ");
            string codigo = Console.ReadLine();

            return codigo;
        }
    }
}
