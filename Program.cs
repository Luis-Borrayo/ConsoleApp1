namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Lista Doble:");
            ListaDoble listaDoble = new ListaDoble();
            listaDoble.Agregar(1);
            listaDoble.Agregar(2);
            listaDoble.Agregar(3);
            listaDoble.ImprimirHaciaAdelante();
            listaDoble.ImprimirHaciaAtras();
            listaDoble.Modificar(2, 5);
            listaDoble.Eliminar(1);
            listaDoble.ImprimirHaciaAdelante();

            Console.WriteLine("\nLista Circular:");
            ListaCircular listaCircular = new ListaCircular();
            listaCircular.Agregar(1);
            listaCircular.Agregar(2);
            listaCircular.Agregar(3);
            listaCircular.Imprimir();
            listaCircular.Modificar(2, 5);
            listaCircular.Eliminar(1);
            listaCircular.Imprimir();
        }

    }
}
