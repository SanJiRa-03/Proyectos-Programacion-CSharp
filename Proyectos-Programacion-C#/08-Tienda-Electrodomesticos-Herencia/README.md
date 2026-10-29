# 🏬 08 - Tienda de Electrodomésticos en C# (Herencia)

Aplicación de consola en **C#** que lleva el catálogo de una tienda de electrodomésticos. Lavadoras, lavavajillas, neveras y hornos comparten una base común y cada uno añade lo que lo distingue, así que la práctica gira en torno a la **herencia** y el **polimorfismo**. 🧺

## 🛍️ ¿Cómo funciona?

Al arrancar aparece un menú numérico. Desde él se da de alta un aparato eligiendo su tipo y respondiendo a las preguntas que el programa va haciendo (marca, modelo, eficiencia energética, año de fabricación y si se sigue fabricando). Todos los productos se guardan en una lista y se pueden consultar de varias formas.

* ✅ El año de fabricación y las respuestas de tipo sí/no se vuelven a pedir hasta que son válidos.
* 🚫 Los productos que ya no se fabrican se pueden listar aparte, como «descatalogados».
* 🔎 Se pueden recuperar todos los aparatos de una misma marca.

## 🎛️ Opciones del menú

| 🔢 Opción | 📖 Qué hace |
|---|---|
| 1 | Añadir un electrodoméstico nuevo. |
| 2 | Mostrar todos con su información. |
| 3 | Mostrar los descatalogados. |
| 4 | Mostrar los de una marca. |
| 5 | Salir. |

## 🧬 Árbol de clases

* **`Electrodomestico`** (clase base): marca, modelo, eficiencia, año y estado de fabricación. Su método `MostrarInfo()` es `virtual`.
* 🧼 **`Lavadora`**: añade el número de programas de lavado y comprueba si es inteligente.
* 🍽️ **`Lavavajillas`**: aprovecha los datos comunes y muestra los suyos.
* ❄️ **`Nevera`**: añade capacidad e inteligencia.
* 🔥 **`Horno`**: añade autolimpiado y una comprobación de generación.
* **`Program.cs`**: menú de consola y lista `List<Electrodomestico>` con todos los productos.

## 🧰 Herramientas empleadas

* 💻 **C#** sobre **.NET Framework**.
* 🧬 **Herencia:** las clases hijas llaman al constructor de la base.
* 🎭 **Polimorfismo:** una misma lista guarda objetos de cuatro tipos y cada uno se muestra a su manera.
* 🔒 **Encapsulamiento** con atributos protegidos y métodos `Get`/`Set`.
* 📋 **`List<T>`** como colección principal.
* ⌨️ **Menús y bucles** para leer los datos por teclado.

## 🏁 Para arrancarlo

1. Abre `TiendaElectrodomesticosHerencia.sln` en **Visual Studio**.
2. Compila y pulsa **F5**.
3. Elige una opción escribiendo su número. Los productos se mantienen en memoria hasta que se cierra el programa.

---
🎓 *Práctica de herencia y polimorfismo aplicada a un catálogo de electrodomésticos.*
