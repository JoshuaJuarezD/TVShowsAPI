# TV Show API
## Descripción
Este proyecto es una  Web API para administrar una lista de programas de televisión. El API permite gestionar los recursos en cada aspecto del CRUD. La API está construida utilizando .NET 8 y sigue diversas prácticas recomendadas y patrones de diseño, tales como CQRS, Repositorio y SOLID. Además, se ha documentado con Swagger y se ha utilizado Entity Framework en memoria, según las especificaciones.

## Características
### Patrón CQRS (Command Query Responsibility Segregation): 
- Separa las operaciones de lectura y escritura para mejorar la escalabilidad y el rendimiento.
- Escalabilidad: Permite escalar las operaciones de lectura y escritura de forma independiente.
- Separación de Responsabilidades: Mejora la claridad y el mantenimiento del código al separar las preocupaciones.

### Patrón Repositorio: 
- Aísla la lógica de acceso a datos, facilitando el mantenimiento y la prueba del código.
- Abstracción del Acceso a Datos: Facilita el cambio de la fuente de datos sin afectar otras partes del código.
- Pruebas Unitarias: Hace que el código sea más fácil de probar mediante la inyección de dependencias.

### Mapeo DTOs (Data Transfer Objects): 
- Transfiere datos entre capas de la aplicación de manera eficiente y segura.
- Seguridad: Evita la exposición de entidades de dominio directamente a través de la API.
- Flexibilidad: Facilita la adaptación de la interfaz de la API sin cambiar las entidades de dominio.

### Entity Framework en Memoria: 
- Proporciona una base de datos en memoria para pruebas rápidas y efectivas, sin necesidad de una base de datos persistente.
- Abstraccion:EF Core proporciona una capa de abstracción sobre las diferentes bases de datos
- LINQ (Language Integrated Query): Permite escribir consultas a la base de datos utilizando una sintaxis familiar de C#, lo que mejora la legibilidad y mantenibilidad del código.

### Swagger: 
- Documentación interactiva y auto-generada de la API, facilitando su uso y pruebas.
- Documentación Clara: Proporciona una interfaz visual y navegable para entender y probar los endpoints de la API.
- Auto-generado: Facilita la generación y mantenimiento de la documentación conforme se actualiza la API.

### Principios SOLID: 
- Implementación siguiendo principios de diseño de software para asegurar un código mantenible, escalable y fácil de entender.
- Single Responsibility Principle: Cada clase tiene una única responsabilidad, facilitando su mantenimiento.
- Open/Closed Principle: El código está abierto a la extensión pero cerrado a la modificación, lo que mejora la estabilidad.
- Liskov Substitution Principle: Las clases derivadas pueden sustituir a sus clases base sin afectar la funcionalidad del sistema.
- Interface Segregation Principle: Se crean interfaces específicas para cada tipo de cliente, evitando la implementación de métodos innecesarios.
- Dependency Inversion Principle: El código depende de abstracciones y no de implementaciones concretas, facilitando la inyección de dependencias y las pruebas.

### Inyección de Dependencias:
- Mejora la flexibilidad y mantenibilidad del código mediante la inyección de dependencias.
- Facilita la configuración de dependencias en tiempo de ejecución.

### Convenciones de Nomenclatura:
- Sigue convenciones estándar de nomenclatura para mejorar la coherencia y legibilidad del código.
- Asegura que el código sea fácil de entender y mantener.

### MediatR:
- Implementa el patrón Mediator para reducir el acoplamiento entre componentes.
- Facilita la coordinación de las solicitudes y la lógica de negocios.

### AutoMapper:
- Simplifica el mapeo entre objetos DTO y entidades de dominio.
- Reduce el código repetitivo y mejora la mantenibilidad del código.


## Instalación
### Prerrequisitos
- .NET 8 SDK: Asegúrate de tener instalado el SDK de .NET 8 en tu máquina. Puedes descargarlo desde el  in [sitio oficial de .NET.](#https://dotnet.microsoft.com/es-es/download/dotnet/8.0) 

### Pasos para la Instalación
- Clonar el Repositorio:
> git clone https://github.com/JoshuaJuarezD/TVShowsAPI.git
> cd tv-show-api
- Restaurar Paquetes NuGet:
> dotnet restore
- Construir el Proyecto:
>dotnet build
- Ejecutar la Aplicación:
> dotnet run
