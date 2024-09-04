using System;

/// <summary>
/// Clase que representa una tarea en la lista de tareas.
/// Contiene una descripción, una fecha límite opcional y un estado de completada.
/// </summary>
public class Tarea
{
    // Propiedad que almacena la descripción de la tarea.
    public string Descripcion { get; set; }
    
    // Propiedad que almacena la fecha límite de la tarea (opcional).
    public DateTime? FechaLimite { get; set; }
    
    // Propiedad que indica si la tarea está completada o no.
    public bool Completada { get; set; }

    /// <summary>
    /// Constructor para inicializar una tarea con su descripción y una fecha límite opcional.
    /// </summary>
    /// <param name="descripcion">Descripción de la tarea.</param>
    /// <param name="fechaLimite">Fecha límite opcional.</param>
    public Tarea(string descripcion, DateTime? fechaLimite = null)
    {
        Descripcion = descripcion;
        FechaLimite = fechaLimite;
        Completada = false; // Inicialmente, la tarea no está completada.
    }

    /// <summary>
    /// Método que muestra la información de la tarea.
    /// </summary>
    public void MostrarTarea()
    {
        string estado = Completada ? "Completada" : "Pendiente";
        string fechaLimiteTexto = FechaLimite.HasValue ? FechaLimite.Value.ToShortDateString() : "Sin fecha límite";
        Console.WriteLine($"Descripción: {Descripcion}, Fecha Límite: {fechaLimiteTexto}, Estado: {estado}");
    }
}
