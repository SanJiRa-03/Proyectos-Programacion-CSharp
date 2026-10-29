# 🔭 09 - Catálogo de Astros en C#

Programa de consola en **C#** con el que se registran y consultan cuerpos celestes. Todos los astros tienen un nombre, un tamaño y una posición; después cada tipo suma sus propios datos. Es un ejercicio de **herencia** y **encapsulamiento** con un tema distinto a los de tiendas y bibliotecas. 🌌

## 🌠 ¿En qué consiste?

El usuario elige primero el tipo de astro escribiendo `estrellas`, `cometas` o `planetas`. A continuación indica qué quiere hacer: **crear**, **mostrar**, **buscar** o **salir**. Si crea un astro, el programa le pide por teclado los datos que corresponden a ese tipo. Si escribe algo que no existe, le avisa y vuelve a preguntar.

## 🪐 Tipos de astro

| 🧩 Clase | 📖 Datos propios |
|---|---|
| **`Astro`** (base) | Nombre, diámetro y posición (X, Y, Z). |
| 🌟 **`Estrella`** | Número de planetas que la orbitan y temperatura. |
| ☄️ **`Cometa`** | Año de descubrimiento, estrella que orbita y periodo orbital. |
| 🪐 **`Planeta`** | Periodo orbital, inclinación y si es habitable. |

`Program.cs` contiene el menú, crea los objetos y realiza la búsqueda por nombre.

## 🧠 Conceptos trabajados

* 🧬 **Herencia:** `Estrella`, `Cometa` y `Planeta` reutilizan los datos de `Astro` gracias a `: base`.
* 🔒 **Encapsulamiento:** los atributos son protegidos o privados y se leen mediante propiedades.
* 📋 **`List<T>`** para guardar los astros de cada tipo.
* 🔢 **Tipos de datos variados:** texto, enteros, decimales y booleanos.
* ⌨️ **Menú de texto** con entrada por teclado.

## 🚀 Puesta en marcha

1. Abre `CatalogoAstros.sln` con **Visual Studio**.
2. Compila y ejecuta con **F5**.
3. Escribe un tipo de astro y después la acción que quieras realizar. Los astros permanecen en memoria mientras el programa está abierto.

---
🎓 *Práctica de herencia y propiedades en C# con un catálogo astronómico.*
