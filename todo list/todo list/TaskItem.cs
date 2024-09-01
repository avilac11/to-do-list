using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo_list
{
    internal class TaskItem
    {
        /// Definicion de variables
        public string Descripcion { get; private set; }
        public DateTime? fechaLimite { get; private set; }
        public bool Completada { get; private set; }
       
        /// Constructor de la clase y agregar descripcion a la tarea.
        public TaskItem(string Descripcion, string fechaLimiteInput = null)
        {
            if (string.IsNullOrWhiteSpace(Descripcion))
                throw new ArgumentException("La descripción de la tarea no puede estar vacía.");

            this.Descripcion = Descripcion;
            this.fechaLimite = ValidarFecha(fechaLimiteInput);
            this.Completada = false;
        }

        /// Agregar y validar fecha limitea la tarea.
        private DateTime? ValidarFecha(string fechaLimiteInput)
        {
            if (string.IsNullOrWhiteSpace(fechaLimiteInput)) {
                return null;
            } else if (DateTime.TryParseExact(fechaLimiteInput, "yyyy-MM-dd", null, DateTimeStyles.None, out DateTime parsedDate)) {
                if (parsedDate.Year >= 2024 && parsedDate.Year <= 2100)  {
                    return parsedDate;
                } else {
                    throw new ArgumentException("El año debe estar entre 2024 y 2100.");
                }
            } else {
                throw new ArgumentException("Fecha inválida. Asegúrese de usar el formato YYYY-MM-DD y que la fecha sea correcta.");
            }
        }

        /// Marca la tarea como completada.
        public void MarkAsCompleted()
        {
            Completada = true;
        }

        /// Definir estado de la tarea como pendiente o completada.
        public override string ToString()
        {
            string fechaLimiteText = fechaLimite.HasValue ? $"Fecha Límite: {fechaLimite.Value.ToShortDateString()}" : "Sin Fecha Límite";
            string status = Completada ? "Completada" : "Pendiente";
            return $"{Descripcion} - {fechaLimiteText} - Estado: {status}";
        }
    }
}