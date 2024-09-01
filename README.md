# todo_list Application

## Descripción

Este es un programa de consola en C# para gestionar una lista de tareas (to-do list). Permite al usuario agregar tareas con una descripción y una fecha límite opcional, listar todas las tareas, marcar tareas como completadas y eliminar tareas.

## Requisitos

- .NET Framework 4.8 o superior
- Compilador de C# compatible

## Instalación
1. Clona este repositorio:
   git clone https://github.com/avilac11/to-do-list.git
2. Navega hacia el diractorio de tu proyecto:
   cd tu_repositorio
3. Compila el proyecto usando el compilador de C#:
    csc /out:ToDoList.exe Program.cs TaskItem.cs TaskManager.cs

## Uso
1. Ejecuta la aplicacion:
    todo_list.exe
2. Sigue las instrucciones en pantalla para interactuar con el menú de opciones:
    Agregar tarea: Introduce una descripción para la tarea y una fecha límite opcional (formato YYYY-MM-DD).
    Listar tareas: Muestra todas las tareas actuales en la lista.
    Marcar tarea como completada: Ingresa el número de la tarea que deseas marcar como completada.
    Eliminar tarea: Ingresa el número de la tarea que deseas eliminar.
    Salir: Cierra el programa.

## Estructura del proyecto
todo list
├─ .vs
│  ├─ ProjectEvaluation
│  │  ├─ todo list.metadata.v8.bin
│  │  ├─ todo list.projects.v8.bin
│  │  └─ todo list.strings.v8.bin
│  └─ todo list
│     ├─ DesignTimeBuild
│     │  └─ .dtbcache.v2
│     ├─ FileContentIndex
│     │  ├─ 4368e31c-b99a-43f8-be0e-76a0ab1d14b0.vsidx
│     │  ├─ 4c3a000e-1da2-4027-a55f-01e7c765f1fe.vsidx
│     │  └─ 6ae698cb-bef4-43da-ac48-cc28e8b32652.vsidx
│     └─ v17
│        ├─ .futdcache.v2
│        ├─ .suo
│        └─ DocumentLayout.json
├─ todo list
│  ├─ bin
│  │  └─ Debug
│  │     └─ net8.0
│  │        ├─ todo list.deps.json
│  │        ├─ todo list.dll
│  │        ├─ todo list.exe
│  │        ├─ todo list.pdb
│  │        └─ todo list.runtimeconfig.json
│  ├─ obj
│  │  ├─ Debug
│  │  │  └─ net8.0
│  │  │     ├─ .NETCoreApp,Version=v8.0.AssemblyAttributes.cs
│  │  │     ├─ apphost.exe
│  │  │     ├─ ref
│  │  │     │  └─ todo list.dll
│  │  │     ├─ refint
│  │  │     │  └─ todo list.dll
│  │  │     ├─ todo list.AssemblyInfo.cs
│  │  │     ├─ todo list.AssemblyInfoInputs.cache
│  │  │     ├─ todo list.assets.cache
│  │  │     ├─ todo list.csproj.BuildWithSkipAnalyzers
│  │  │     ├─ todo list.csproj.CoreCompileInputs.cache
│  │  │     ├─ todo list.csproj.FileListAbsolute.txt
│  │  │     ├─ todo list.dll
│  │  │     ├─ todo list.GeneratedMSBuildEditorConfig.editorconfig
│  │  │     ├─ todo list.genruntimeconfig.cache
│  │  │     ├─ todo list.GlobalUsings.g.cs
│  │  │     └─ todo list.pdb
│  │  ├─ project.assets.json
│  │  ├─ project.nuget.cache
│  │  ├─ todo list.csproj.nuget.dgspec.json
│  │  ├─ todo list.csproj.nuget.g.props
│  │  └─ todo list.csproj.nuget.g.targets
│  ├─ Program.cs
│  ├─ TaskItem.cs
│  ├─ TaskManager.cs
│  └─ todo list.csproj
└─ todo list.sln
