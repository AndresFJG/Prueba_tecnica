using System;
using System.Collections.Generic;

/// <summary>
/// Clase que gestiona las operaciones relacionadas con la lista de tareas.
/// </summary>
public class GestionTareas
{
    // Lista que almacena todas las tareas.
    private List<Tarea> listaTareas;

    public GestionTareas()
    {
        listaTareas = new List<Tarea>(); // Inicializa la lista de tareas vacía.
    }

    /// <summary>
    /// Método para agregar una nueva tarea a la lista.
    /// </summary>
    public void AgregarTarea()
    {
        Console.Write("Ingrese la descripción de la tarea: ");
        string descripcion = Console.ReadLine();

        Console.Write("¿Desea ingresar una fecha límite? (s/n): ");
        string respuesta = Console.ReadLine().ToLower();

        DateTime? fechaLimite = null;
        if (respuesta == "s")
        {
            Console.Write("Ingrese la fecha límite (dd/mm/yyyy): ");
            try
            {
                fechaLimite = DateTime.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Fecha no válida. La tarea será creada sin fecha límite.");
            }
        }

        Tarea nuevaTarea = new Tarea(descripcion, fechaLimite);
        listaTareas.Add(nuevaTarea);
        Console.WriteLine("Tarea agregada con éxito.");
    }

    /// <summary>
    /// Método para listar todas las tareas.
    /// </summary>
    public void ListarTareas()
    {
        if (listaTareas.Count == 0)
        {
            Console.WriteLine("No hay tareas registradas.");
        }
        else
        {
            Console.WriteLine("Lista de tareas:");
            for (int i = 0; i < listaTareas.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                listaTareas[i].MostrarTarea();
            }
        }
    }

    /// <summary>
    /// Método para marcar una tarea como completada.
    /// </summary>
    public void MarcarTareaCompletada()
    {
        ListarTareas();
        if (listaTareas.Count > 0)
        {
            Console.Write("Ingrese el número de la tarea a marcar como completada: ");
            try
            {
                int indice = int.Parse(Console.ReadLine()) - 1;
                if (indice >= 0 && indice < listaTareas.Count)
                {
                    listaTareas[indice].Completada = true;
                    Console.WriteLine("Tarea marcada como completada.");
                }
                else
                {
                    Console.WriteLine("Número de tarea no válido.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
    }

    /// <summary>
    /// Método para eliminar una tarea de la lista.
    /// </summary>
    public void EliminarTarea()
    {
        ListarTareas();
        if (listaTareas.Count > 0)
        {
            Console.Write("Ingrese el número de la tarea a eliminar: ");
            try
            {
                int indice = int.Parse(Console.ReadLine()) - 1;
                if (indice >= 0 && indice < listaTareas.Count)
                {
                    listaTareas.RemoveAt(indice);
                    Console.WriteLine("Tarea eliminada con éxito.");
                }
                else
                {
                    Console.WriteLine("Número de tarea no válido.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
    }
}
