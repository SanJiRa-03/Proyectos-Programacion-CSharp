# 🧪 12 - Ejercicios de Práctica en C#

Trece programas de consola, pequeños y de temática variada, que sirvieron para entrenar los fundamentos de la Programación Orientada a Objetos. Cada ejercicio parte de una clase base, crea varias clases hijas y ofrece un menú para manejar una lista. Cada carpeta tiene su propia solución (`.sln`). 💪

## 🐾 Seres vivos y vehículos

* 🐶 **Animales:** `Animal` con `Perro`, `Gato` y `Pajaro`, que se comportan de forma distinta ante la misma orden.
* 🚗 **Vehiculos:** `Vehiculo` con `Moto`, `Coche` y `Autobus`; se busca y se borra por marca.
* 🚙 **Concesionaria-de-Vehiculos** *(con enunciado)*: `Vehículo` es abstracta, `Auto` y `Camioneta` la extienden y la concesionaria guarda una lista de vehículos.

## 📖 Lectura y publicaciones

* 📚 **Biblioteca-de-Archivos** *(con enunciado)*: `Archivo` abstracta con `Libro` y `Revista`; permite buscar por título o autor y sacar estadísticas.
* 🗂️ **Biblioteca-de-Materiales:** `Material` con `Libro`, `Revista` y `Periodico`, guardados y leídos desde un fichero.
* 📰 **Publicaciones:** `Publicacion` con `Libro` y `Revista`; búsqueda por título.

## 🛒 Comercios y colecciones

* 🧺 **Electrodomesticos:** lavadoras, lavavajillas, neveras y hornos que se guardan y se leen de un fichero.
* 🏬 **Tienda-de-Electrodomesticos:** otra versión de la tienda, con clases en plural y búsqueda por marca.
* 🎹 **Tienda-de-Instrumentos:** guitarras y pianos que se pueden alquilar, gestionados por una clase `Tienda`.
* 🍎 **Fruteria:** cesta de productos con registro e inicio de sesión; se busca y se elimina por identificador.
* 📱 **Electronic-Mark:** móviles, relojes inteligentes y memorias USB asociados a un propietario (por DNI) y a una ubicación.

## 🍳 Registros sencillos

* 🥘 **Recetas:** `Receta` con `Tortilla`, `Gazpacho` y `Ensaladilla`; se pueden buscar y eliminar.
* 🏅 **Registro-de-Deportistas:** alta, búsqueda y baja de deportistas por nombre.

## 📌 Qué trabaja cada grupo

| 🧱 Grupo | 🎯 Protagonistas |
|---|---|
| Seres vivos y vehículos | Herencia, polimorfismo, abstracción y composición |
| Lectura y publicaciones | Clases abstractas, búsquedas y estadísticas |
| Comercios y colecciones | Jerarquías de varios tipos, usuarios y alquileres |
| Registros sencillos | Altas, búsquedas y bajas sobre listas |

## 🛠️ Tecnologías y conceptos

* 💻 **C#** y **.NET Framework**.
* 🧬 **Herencia**, **clases abstractas**, **polimorfismo**, **composición** y **encapsulamiento**.
* 📋 **`List<T>`** como colección principal.
* 💾 **Ficheros de texto** con `StreamReader` y `StreamWriter` en los ejercicios que los usan.
* 🛡️ **`try/catch`** para controlar errores.
* ⌨️ **Menús de consola** con altas, búsquedas, bajas y listados.

## ▶️ Cómo abrirlos

1. Entra en la carpeta del ejercicio.
2. Abre su `.sln` con **Visual Studio**.
3. Compila y ejecuta con **F5**.

---
🎓 *Ejercicios cortos para afianzar la programación orientada a objetos en C#.*
