# 🔭 09 - Catálogo de Astros en C#

Programa de consola desarrollado en **C#** para registrar y consultar cuerpos celestes. Cada tipo de astro comparte unos datos básicos y añade sus propias características, lo que lo convierte en un buen ejercicio de **herencia** y encapsulamiento. 🌌

## 🚀 Funcionalidades

* 🧭 **Menú por texto:** se elige el tipo de astro (estrellas, cometas o planetas) y después la acción: crear, mostrar, buscar o salir.
* ➕ **Crear astros:** el programa pide por consola los datos propios de cada tipo.
* 📋 **Mostrar el catálogo:** lista los astros registrados de cada tipo.
* 🔎 **Buscar por nombre:** localiza un astro concreto escribiendo su nombre.
* ⚠️ **Opciones no válidas:** el programa avisa cuando se escribe una opción que no existe.

## 🧱 Jerarquía de clases

| 🧩 Clase | 📖 Datos que guarda |
|---|---|
| `Astro` (base) | Nombre, diámetro y posición en el espacio (X, Y, Z). |
| 🌟 `Estrella` | Número de planetas que la orbitan y temperatura. |
| ☄️ `Cometa` | Año de descubrimiento, estrella que orbita y periodo orbital. |
| 🪐 `Planeta` | Periodo orbital, inclinación y si es habitable. |
| `Program.cs` | Menú, creación de objetos y búsqueda. |

## 🛠️ Tecnologías y conceptos

* 💻 **C#** y **.NET Framework**.
* 🧬 **Herencia:** las tres clases hijas reutilizan los datos de `Astro` mediante `: base`.
* 🔒 **Encapsulamiento:** atributos protegidos o privados que se consultan mediante propiedades.
* 📋 **Colecciones dinámicas** con `List<T>` para guardar los distintos tipos de astro.
* 🔢 **Distintos tipos de datos:** cadenas, enteros, decimales y booleanos.
* ⌨️ **Interacción por consola** con menús de texto.

## ▶️ Cómo ejecutar

1. Abre `CatalogoAstros.sln` con **Visual Studio**.
2. Compila y ejecuta con **F5**.
3. Escribe el tipo de astro (por ejemplo, `estrellas`) y, después, la acción que quieras realizar.

## 🔭 Alcance y mejoras posibles

Los astros se almacenan **solo en memoria** mientras el programa está abierto. Se podría ampliar con:

* 💾 Guardar y cargar el catálogo desde un fichero.
* 🔢 Validar que los valores numéricos sean correctos.
* 🗑️ Opciones para modificar o eliminar astros.

---
🎓 *Proyecto de práctica para aplicar herencia y encapsulamiento en C#.*
