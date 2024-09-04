using System;

class Program
{
    static void Main(string[] args)
    {
        GestionTareas gestionTareas = new GestionTareas();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Listar tareas");
            Console.WriteLine("3. Marcar tarea como completada");
            Console.WriteLine("4. Eliminar tarea");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    gestionTareas.AgregarTarea();
                    break;
                case "2":
                    gestionTareas.ListarTareas();
                    break;
                case "3":
                    gestionTareas.MarcarTareaCompletada();
                    break;
                case "4":
                    gestionTareas.EliminarTarea();
                    break;
                case "5":
                    continuar = false;
                    Console.WriteLine("Gracias por usar la aplicación.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }
}
