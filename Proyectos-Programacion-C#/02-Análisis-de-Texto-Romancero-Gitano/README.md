# Sistema de Análisis de Texto y Procesamiento de Ficheros en C#

Este proyecto implementa una herramienta interactiva de lectura, análisis estadístico y persistencia de métricas sobre obras literarias en texto plano (`.txt`), aplicando procesamiento de cadenas, manipulación de colecciones y gestión de archivos en C#.

## 🚀 Características

* **Análisis Estadístico y Métricas:** Conteo automatizado de palabras totales, detección de palabras únicas y cálculo preciso de ocurrencias de términos clave y signos de puntuación.
* **Sanitización y Limpieza de Datos:** Normalización de cadenas mediante conversión a minúsculas (`ToLower`), división sintáctica (`Split`) y depuración de caracteres adyacentes (`Trim`).
* **Tratamiento Dinámico de Datos:** Uso de colecciones (`List<T>`) y consultas LINQ (`Distinct`) para el filtrado eficiente de duplicados y optimización del rendimiento en memoria.
* **Persistencia y Control de Errores:** Exportación automatizada de reportes estadísticos a ficheros de salida (`StreamWriter`), con gestión robusta de excepciones (`try-catch`) y liberación segura de recursos mediante la instrucción `using`.

## 🛠️ Tecnologías aplicadas

* Lenguaje C# (.NET)
* Procesamiento de cadenas y expresiones avanzadas de texto
* Consultas LINQ y colecciones dinámicas (`System.Linq`, `System.Collections.Generic`)
* Entrada/Salida y manejo de flujos de ficheros (`System.IO.StreamReader` / `System.IO.StreamWriter`)