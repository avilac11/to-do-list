using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo_list
{
    internal class TaskManager
    { 
        /// Lista para las tareas.
        private List<TaskItem> tasks;

        /// Constructor de la lista de tareas.
        public TaskManager()
        {
            tasks = new List<TaskItem>();
        }

        /// Agrega una nueva tarea a la lista.
        public void AddTask(string Descripcion, string fechaLimiteInput = null)
        {
            TaskItem newTask = new TaskItem(Descripcion, fechaLimiteInput);
            tasks.Add(newTask);
        }

        /// Listar todas las tareas en la consola.
        public void ListTasks()
        {
            /// Contador de tareas agregadas.
            if (tasks.Count == 0) {
                Console.WriteLine("No hay tareas registradas.");
                return;
            }

            for (int i = 0; i < tasks.Count; i++) {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        /// Validar número de tareas y marca una tarea como completada.
        public void CompleteTask(int taskNumber)
        {
            if (taskNumber < 1 || taskNumber > tasks.Count) {
                throw new ArgumentOutOfRangeException(nameof(taskNumber), "Número de tarea inválido.");
            }

            tasks[taskNumber - 1].MarkAsCompleted();
        }

        /// Validar número de tareas y elimina una tarea de la lista.
        public void DeleteTask(int taskNumber)
        {
            if (taskNumber < 1 || taskNumber > tasks.Count) {
                throw new ArgumentOutOfRangeException(nameof(taskNumber), "Número de tarea inválido.");
            }

            tasks.RemoveAt(taskNumber - 1);
        }
    }
}
