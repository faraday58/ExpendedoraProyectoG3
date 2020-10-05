using System; 
using System.Threading; //Para que se limpien los mensajes en la pantalla negra

namespace ExpendedoraProyectoG3
{
    abstract class Expendedora
    {
        #region Atributos o campos 
        //La variables que tendra nuestra clase (Siempre tienen que tener un valor por default)
     private string marca;
     private ushort cantProductos;
     private float precio;


    internal byte temperatura;
        public virtual byte Temperatura { 
            get => temperatura;
            set
            {
                if (value < 14 ||  value > 20) 
                {
                    temperatura = 14;
                }else
                {
                    temperatura = value;
                }
                
            }
        }

        public virtual string Marca { get => marca; set => marca = value; }
        public virtual ushort CantProductos { get => cantProductos; set => cantProductos = value; }
        public virtual float Precio { get => precio; set => precio = value; }
        #endregion

        #region Constructor
        public Expendedora() //Lo que hara nuestra clase
        {
           

        }
        #endregion

        #region Metodos
        public virtual void Saludar() //Es como una funcion
        {
            Console.WriteLine("Bienvenido");
        }

        public virtual void ElevarTemperatura()
        {
            Temperatura++;
        }
        public virtual void MostrarTemperatura()
        {
            Console.WriteLine("Temperatura: {0} ", Temperatura);
        }
        public virtual void tiempoDespliegue() //Limpiara la pantalla
        {
            Thread.Sleep(3000); //Espera 3 segundo a que haga el otro proceso
            Console.Clear();
        }

        public virtual string MostrarCodigoProducto() //es string porque va a pedir variables 
        {
            Console.WriteLine("1A: Takis \n2B: Chips");
            Console.WriteLine("Ingrede el codigo del producto a elegir: ");
            string codigo = Console.ReadLine();
            return codigo; //

        }

        public virtual void MostrarPrecio(string codigo) //Para que entre la variable codigo 
        {
            switch(codigo)
            {
                case "1A":
                    Console.WriteLine("Precio: ${0}", Precio);
                    break;

                case "2B":
                    Console.WriteLine("Precio: ${0}", Precio+5);
                    break;
            }
        }

        #endregion 


    }
}

