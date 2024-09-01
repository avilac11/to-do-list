namespace todo_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Definicion de variables y objetos.
            TaskManager taskManager = new TaskManager();
            bool exit = false;

            /// Bucle de menu.
            while (!exit) {
                Console.WriteLine("\nMenú de Opciones:");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Listar tareas");
                Console.WriteLine("3. Marcar tarea como completada");
                Console.WriteLine("4. Eliminar tarea");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                try {
                    switch (opcion) {
                        case "1":
                            AddTask(taskManager);
                            break;
                        case "2":
                            taskManager.ListTasks();
                            break;
                        case "3":
                            CompleteTask(taskManager);
                            break;
                        case "4":
                            DeleteTask(taskManager);
                            break;
                        case "5":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                } catch (Exception ex) {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        /// Mensaje y opciones de escritura para agregar una tarea.
        static void AddTask(TaskManager taskManager)
        {
            Console.Write("Ingrese la descripción de la tarea: ");
            string descripcion = Console.ReadLine();

            Console.Write("Ingrese la fecha límite (formato YYYY-MM-DD) o deje en blanco para omitir: ");
            string fechaLimiteInput = Console.ReadLine();

            try {
                taskManager.AddTask(descripcion, fechaLimiteInput);
                Console.WriteLine("Tarea agregada exitosamente.");
            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        /// Mensaje y opciones de escritura para completar una tarea.
        static void CompleteTask(TaskManager taskManager)
        {
            Console.Write("Ingrese el número de la tarea a completar: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber)) {
                taskManager.CompleteTask(taskNumber);
                Console.WriteLine("Tarea completada exitosamente.");
            } else {
                Console.WriteLine("Número de tarea inválido.");
            }
        }

        /// Mensaje y opciones de escritura para eliminar una tarea.
        static void DeleteTask(TaskManager taskManager)
        {
            Console.Write("Ingrese el número de la tarea a eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber)) {
                taskManager.DeleteTask(taskNumber);
                Console.WriteLine("Tarea eliminada exitosamente.");
            } else {
                Console.WriteLine("Número de tarea inválido.");
            }
        }
    }
}
