# 🏬 08 - Tienda de Electrodomésticos en C# (Herencia)

Aplicación de consola desarrollada en **C#** para gestionar el catálogo de una tienda de electrodomésticos. Es una práctica pensada para aplicar la **herencia** y el **polimorfismo**: los datos comunes viven en una clase base y cada tipo de aparato añade sus propias características. 🧺

## 🚀 Funcionalidades

* ➕ **Introducir electrodomésticos:** se elige el tipo (lavadora, lavavajillas, nevera u horno) y se piden sus datos por consola.
* 📋 **Mostrar el catálogo:** lista todos los electrodomésticos con su información completa.
* 🚫 **Descatalogados:** muestra solo los productos que ya no se fabrican.
* 🔎 **Filtrar por marca:** busca todos los electrodomésticos de una marca determinada.
* ✅ **Validación de datos:** las respuestas de tipo sí/no y el año de fabricación se piden de nuevo hasta que son válidos.

## 📋 Menú del programa

1. Introducir un nuevo electrodoméstico.
2. Mostrar todos los electrodomésticos con su información.
3. Mostrar los electrodomésticos descatalogados.
4. Mostrar los electrodomésticos de una marca determinada.
5. Salir.

## 🧱 Jerarquía de clases

| 🧩 Clase | 🎯 Responsabilidad |
|---|---|
| `Electrodomestico` | Clase base con marca, modelo, eficiencia energética, año de fabricación y si se sigue fabricando. Define `MostrarInfo()` como método `virtual`. |
| `Lavadora` | Añade el número de programas de lavado y una comprobación para indicar si es inteligente. |
| `Lavavajillas` | Hereda los datos comunes y sobrescribe `MostrarInfo()` con sus características. |
| `Nevera` | Añade capacidad e inteligencia. |
| `Horno` | Añade autolimpiado y una comprobación de generación. |
| `Program.cs` | Menú de consola y lista `List<Electrodomestico>` con todos los productos. |

## 🛠️ Tecnologías y conceptos

* 💻 **C#** y **.NET Framework**.
* 🧬 **Herencia:** las cuatro clases hijas aprovechan el constructor y los atributos de la clase base.
* 🎭 **Polimorfismo:** cada objeto muestra su información de forma distinta aunque se recorra la misma lista.
* 🔒 **Encapsulamiento:** atributos protegidos o privados con métodos de acceso (`Get`/`Set`).
* 📋 **Colecciones dinámicas** con `List<T>`.
* ⌨️ **Entrada por consola** con menús y bucles de validación.

## ▶️ Cómo ejecutar

1. Abre `TiendaElectrodomesticosHerencia.sln` con **Visual Studio**.
2. Comprueba que el proyecto usa **.NET Framework**.
3. Compila y ejecuta con **F5**.
4. Sigue las instrucciones numéricas en pantalla para añadir y consultar productos.

## 🔭 Alcance y mejoras posibles

Los productos se guardan **solo en memoria** mientras el programa está abierto. Otras mejoras que se podrían añadir:

* 💾 Guardar y recuperar el catálogo desde un fichero de texto.
* 🔢 Controlar los casos en los que se escribe texto donde se espera un número.
* ✏️ Añadir opciones para modificar o eliminar productos.

---
🎓 *Proyecto de práctica para aplicar herencia, polimorfismo y colecciones en C#.*
