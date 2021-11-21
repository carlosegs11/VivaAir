******** PRUEBA DESARROLLADOR .NET *********
En esta prueba se hizo un aplicativo web llamado FlightComponent2 el cual permite la consulta de los vuelos disponibles a través de la WebApi de VivaAir.
En el proyecto se creó una carpeta llamada "SQL Server" donde se dejaron todos los scripts de la base de datos.

PRUEBAS UNITARIAS:  Se creó un proyecto de pruebas unitarias, pero se me acabó el tiempo y no lo pude implementar.  Estas pruebas se podrían hacer con Mocks creando objetos temporales y definiendo sus comportamientos para hacer las pruebas.

ARQUITECTURA DE DISEÑO: El proyecto tiene una arquitectura de diseño MVC y N-Capas que permite desacoplar cada una de las responsabilidades: Aplicativo Web, Capa de datos (2 proveedores ADO.net y EntityFramework), Capa de Modelo, Capa de Servicios y Capa de Negocio.

PROGRAMACIÓN ORIENTADA A OBJETOS: Se aplicó la creación de Clases con sus atributos y métodos, herencia, herencia multiple (soporta mediante intefaces), polimorfismo en la sobreescritura del metodo string.

FRONT-END: Para el front se utilizó HTML, css, html helpers, bootstrap, jquery y javascript.

VERSIONAMIENTO DE CODIGO: Se utilizó GIT y GITHUB para el versionamiento.

BASE DE DATOS: Se utilizó la base de datos SQL SERVER y procedimientos almacenados para ADO.Net.

CONTROL DE EXCEPCIONES:  Se aplicó el try y catch en los controladores.  Quedó pendiente el uso del Finally pero sirve para que siempre tome este flujo por ejemplo al momento de presentarse una excepción se podría cerrar la conexión a una base de datos.

LOGGING EN APLICACION.  Existe la librería log4net para llevar esta trazabilidad.  Para este caso particular se creó una clase personalizada para manejar el logging.

INYECCIÓN DE DEPENDENCIAS:  Se aplico la inyección de dependencias al momento de consumir la WebAPI para poder utilizar diferentes proveedores (VivaAir y Avianca), al momento de consultar el código IATA y al momento de Guardar la reserva (ADO.Net y Entity Framework).

GIT ADVANCED: Se hizo un commit inicial con todo el proyecto, una rama nueva para desarrolladores (dev) con un mensaje de CARGANDO y un pull request para este archivo README.txt

NOMENCLATURA DE CODIGO: Se utilizo la nomenclatura sugerida REFERENCIA C#

PRINCIPIOS SOLID:  En el proyecto se utilizaron 3 principios SOLID: 1. Single Responsability Principle (SRP) - 4. Interface Segregation Principe (ISP) - 5. Dependency Inversion Principle (DIP).

PUBLICACIÓN APLICATIVO

El codigo fuente quedó en un repositorio de acceso público en github: https://github.com/carlosegs11/VivaAir
También quedó publicado en la siguiente URL: https://pruebasweb.indumapps.com/
