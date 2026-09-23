# Sistema de Gestión de Puerto y Embarcaciones en C#

Este proyecto implementa un sistema interactivo de gestión, control de cargas y persistencia de flotas marítimas aplicando Programación Orientada a Objetos (POO) avanzada y estructuras de datos dinámicas en C#.

## 🚀 Características

* **Modelado POO Avanzado:** Jerarquía de clases con una clase base abstracta (`Barcos`) y clases especializadas (*Pesquero, Congelador, Transporte, Contenedores*) para representar las diferentes embarcaciones.
* **Polimorfismo Dinámico:** Sobrescritura de métodos para el cálculo autónomo del peso total de carga según el tipo de barco y sus áreas de almacenamiento.
* **Gestión de Puerto:** Administración centralizada a través de la clase `Puerto` mediante colecciones dinámicas (`List<T>`), permitiendo alta, baja, filtrado por tipo de mercancía y recálculo de tonelaje en tiempo real.
* **Persistencia de Datos:** Exportación y sincronización del estado de la flota en ficheros de texto plano para mantener la consistencia del almacenamiento secundario.

## 🛠️ Tecnologías aplicadas

* Lenguaje C# (.NET)
* Paradigma Orientado a Objetos (Herencia, Polimorfismo, Encapsulamiento)
* Colecciones dinámicas (`System.Collections.Generic`)
* Entrada/Salida y manejo de ficheros (`System.IO`)