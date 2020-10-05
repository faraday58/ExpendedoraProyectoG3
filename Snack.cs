using System;


namespace ExpendedoraProyectoG3
{
    class Snack : Expendedora
    {
        public Snack()
        {
            Marca = "AMS";
            Temperatura = 14;
            CantProductos = 430;
            Precio = 5;

            Saludar();
            tiempoDespliegue();
            Console.WriteLine("Marca: {0}", Marca);
            tiempoDespliegue();
            Console.WriteLine("Temperatura: {0}", Temperatura);
            tiempoDespliegue();
            string codigo = MostrarCodigoProducto(); //Para asignarle una variable a la funcion (en este caso es una variable local)
            tiempoDespliegue();
            MostrarPrecio(codigo); //Para mandar la variable a la funcion
            tiempoDespliegue();
        }


    }
}
