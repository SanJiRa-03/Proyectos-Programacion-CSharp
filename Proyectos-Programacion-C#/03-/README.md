# Sistema de Procesamiento y Depuración de Sensores en C#

Este proyecto implementa un módulo interactivo para la ingesta, validación estructural, filtrado de datos corruptos y persistencia de lecturas de sensores IoT en C#.

## 🚀 Características

* **Validación de Datos en Tiempo Real:** Inspección y parseo de estructuras delimitadas (formato CSV/Semicolon) comprobando la integridad de parámetros por registro.
* **Control y Contabilidad de Errores:** Detección automática de líneas corruptas o incompletas con registro en tiempo real sin interrupción del flujo del programa.
* **Encapsulamiento Orientado a Objetos:** Separación de responsabilidades mediante la clase `ProcesadorSenales`, aislando la lógica de negocio del flujo principal de consola.
* **Gestión Segura de Archivos (E/S):** Uso de `System.IO.File` para la lectura/escritura optimizada de conjuntos de datos y captura de excepciones en el acceso a almacenamiento.

## 🛠️ Tecnologías aplicadas

* Lenguaje C# (.NET)
* Entrada/Salida y manipulación de ficheros (`System.IO`)
* Colecciones dinámicas y tipado fuerte (`List<string>`)
* Tratamiento de excepciones y validación de sintaxis (`Try-Catch`, `String.Split`)