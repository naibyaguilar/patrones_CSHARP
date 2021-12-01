using System;

namespace DecoratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos el componente central con tipo Icomponente 
            //para permitir la decoracion 
            IComponente miAuto = new CAuto("2018", "4 puertas", 200000);
            Console.WriteLine(miAuto);

            //si necesitamos hacer un metodo propio de cAuto
            //necesitamos hace ruso de un type cast
            ((CAuto)miAuto).Puertas(true);

            Console.WriteLine("------");

            //decoramos el audio con un sistema de sonido 
            miAuto = new CSistemaSonido(miAuto);
            //comprobamos la adiccion de las caracteristicas
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("------");

            miAuto = new CNitrogeno(miAuto);
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("------");

            //para usar algo propio del nitrogeno necesitamos un type cast
            ((CNitrogeno)miAuto).UsaN();
            Console.WriteLine("------");

            miAuto = new CSuspencion(miAuto);
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);
            Console.WriteLine("--------");

            //OJOOOOOOOOOOOOOOOOOO NO PODEMOS USAR METODOS ESPEFICICOS UNA VEZ QUE DECORAMOS  SOBRE ELLA
            //((CNitrogeno)miAuto).UsaN();
            ((CAuto)miAuto).Puertas(false);
            Console.ReadKey();
        }
    }
}
