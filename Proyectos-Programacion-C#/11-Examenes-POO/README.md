# Exámenes de POO en C#

Tres ejercicios planteados como examen en los que había que diseñar una jerarquía de clases, programar un menú de consola y trabajar con ficheros de texto. Cada carpeta tiene su propia solución (`.sln`).

## 📚 Biblioteca de Materiales

Gestión de los materiales de una biblioteca: libros, revistas y periódicos.

* **Clase abstracta `Material`** con métodos abstractos que implementan `Libro`, `Revista` y `Periodico`.
* **Polimorfismo:** cada tipo escribe y muestra su información a su manera.
* **Ficheros:** el programa crea los materiales, los guarda en un fichero de texto y los vuelve a leer.

## 🎸 Tienda de Instrumentos

Tienda de guitarras y pianos con servicio de **alquiler**.

* **Jerarquía:** `Instrumentos` como clase base de `Guitarras` y `Pianos`.
* **Alquiler** de instrumentos por número de serie y listado de los instrumentos alquilados con su ubicación (latitud y longitud).
* **Control de errores** con `try/catch` y validación del número de serie.

## 🏃 Deportistas

Registro de deportistas según su disciplina.

* **Jerarquía:** `Deportista` como clase base de `Atletismo`, `Ciclismo` y `Natación`, cada una con sus datos específicos (por ejemplo, la velocidad del atleta).
* **Listas por disciplina** y consulta de la información.
* **Ficheros:** lectura y escritura del registro en un fichero de texto.

## 🛠️ Tecnologías aplicadas

* Lenguaje C# (.NET Framework)
* Herencia, clases abstractas, polimorfismo y encapsulamiento
* Colecciones dinámicas (`List<T>`)
* Entrada/Salida y manejo de ficheros (`System.IO`)
* Gestión de errores con `try/catch`

## ▶️ Ejecución

Entra en la carpeta del ejercicio, abre su `.sln` con Visual Studio y pulsa **F5**.
