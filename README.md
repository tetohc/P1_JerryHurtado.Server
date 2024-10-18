# REST-UNED-Servidor

## Descripción
Proyecto del curso Programación Avanzada de la UNED, servidor para la empresa REST-UNED. Desarrollado en .NET 7, implementa un sistema cliente/servidor para la gestión centralizada de pedidos de platos en restaurantes. Este proyecto utiliza inyección de dependencias, el patrón Modelo-Vista-Presentador (MVP) y Windows Forms para la interfaz de usuario del administrador. La información se almacena en una base de datos SQL Server. La solución permite al administrador gestionar las funcionalidades de restaurantes, clientes, categorías de platos, platos, platos por restaurante y extras, comunicándose con las aplicaciones cliente a través del protocolo TCP.

## Características del Proyecto
- **Desarrollo Orientado a Objetos**: Uso de POO para estructurar las clases de objetos.
- **Manejo de Excepciones**: Implementación de manejo de excepciones para evitar cierres inesperados y mostrar mensajes apropiados al usuario.
- **Validaciones de Entrada**: Verificación de las reglas de validación. 
- **Colecciones Genéricas**: Utilización de listas genéricas (`List<>`) para manejar y consultar datos.
- **Interfaz de Usuario**: Desarrollada con formularios GUI utilizando Windows Forms.
- **Base de Datos**: Almacenamiento y consultas realizadas en una base de datos SQL Server con seguridad integrada de Windows.
- **Sockets**: Utiliza sockets en la dirección 127.0.0.1 y el puerto 14100 para escuchar solicitudes.
- **Subprocesamiento Múltiple**: Implementa un servidor que escucha y responde a solicitudes de múltiples clientes TCP de forma simultánea utilizando subprocesamiento múltiple.

## Tecnologías Utilizadas
- **Lenguaje de Programación**: C#
- **Framework**: .NET 7
- **Patrón de Diseño**: Modelo-Vista-Presentador (MVP)
- **Inyección de Dependencias**
- **ORM**: Entity Framework Core
- **Interfaz de Usuario**: Windows Forms
