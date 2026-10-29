# Catálogo de Astros en C#

Programa de consola para registrar y consultar cuerpos celestes. Cada tipo de astro comparte unos datos básicos y añade sus propias características, lo que lo convierte en un buen ejercicio de **herencia**.

## 🚀 Características

* **Clase base `Astro`:** nombre, diámetro y posición en el espacio (X, Y, Z).
* **Clases especializadas:**
  * 🌟 `Estrella`: número de planetas que la orbitan y temperatura.
  * ☄️ `Cometa`: año de descubrimiento, estrella que orbita y periodo orbital.
  * 🪐 `Planeta`: periodo orbital, inclinación y si es habitable.
* **Menú por texto:** se elige el tipo de astro (estrellas, cometas o planetas) y después crear, mostrar, buscar por nombre o salir.
* **Propiedades y encapsulamiento:** los datos de cada clase se protegen y se consultan mediante propiedades.

## 🛠️ Tecnologías aplicadas

* Lenguaje C# (.NET Framework)
* Herencia (`: base`) y encapsulamiento
* Colecciones dinámicas (`List<T>`)
* Aplicación de consola con menús de texto

## ▶️ Ejecución

Abre `CatalogoAstros.sln` con Visual Studio y pulsa **F5**.
