# 📝 11 - Exámenes de POO en C#

Tres ejercicios que se plantearon como **examen** de Programación Orientada a Objetos. En cada uno el enunciado pedía montar una jerarquía de clases y hacer que el programa funcionara de principio a fin. Cada carpeta tiene su propia solución de Visual Studio (`.sln`). ⏱️

## 📚 Biblioteca de Materiales

**Reto:** representar el fondo de una biblioteca con tres tipos de material.

* 🧱 `Material` es una **clase abstracta** con dos métodos abstractos, `WriteInfo` y `GetInfo`.
* 📖 `Libro`, `Revista` y `Periodico` los implementan cada uno a su manera.
* 📥 El programa crea dos materiales de cada tipo con constructores parametrizados y los guarda en una lista.
* 💾 Escribe la lista en un fichero de texto y la vuelve a leer para mostrarla.

## 🎸 Tienda de Instrumentos

**Reto:** controlar el stock y el alquiler de una tienda de música.

* 🧬 `Instrumentos` reúne marca, modelo, número de serie, ubicación y estado de alquiler; `Guitarras` y `Pianos` añaden lo suyo.
* 🔑 Un instrumento se alquila indicando su **número de serie**.
* 📍 Se puede listar lo que está alquilado junto a su **latitud y longitud**.
* 🛡️ Un número de serie inexistente se detecta y se avisa al usuario.

## 🏃 Deportistas

**Reto:** registrar atletas, ciclistas y nadadores en una misma aplicación.

* 🧬 `Deportista` es la base de `Atletismo`, `Ciclismo` y `Natación`; por ejemplo, el atleta guarda su velocidad en km/h.
* 📋 Además de la lista general, hay una lista por disciplina.
* 💾 El registro se lee y se escribe en un fichero de texto.

## 🧾 Comparativa

| 📁 Examen | 🧩 Jerarquía | 🎯 Lo más importante |
|---|---|---|
| Biblioteca de Materiales | `Material` → `Libro`, `Revista`, `Periodico` | Clases y métodos abstractos |
| Tienda de Instrumentos | `Instrumentos` → `Guitarras`, `Pianos` | Alquiler y ubicación |
| Deportistas | `Deportista` → `Atletismo`, `Ciclismo`, `Natación` | Listas por disciplina |

## 🔧 Conceptos que cubren

* 🧬 Herencia, polimorfismo y encapsulamiento.
* 🧱 Clases y métodos abstractos.
* 📋 `List<T>` como colección.
* 💾 Lectura y escritura de ficheros con `StreamReader` y `StreamWriter`.
* 🛡️ Control de errores con `try/catch`.

## ▶️ Cómo abrirlos

1. Entra en la carpeta del examen que quieras revisar.
2. Abre su `.sln` con **Visual Studio**.
3. Compila y ejecuta con **F5**.

---
🎓 *Exámenes resueltos para consolidar la programación orientada a objetos en C#.*
