# 🎬 10 - Gestor de Contenidos en C# (películas, series y podcasts)

Catálogo de consola en **C#** que se comporta como una pequeña plataforma de streaming: cada persona crea su cuenta, entra y gestiona **películas, series y podcasts**. Es un **proyecto en equipo** 🤝 que guarda sus datos en ficheros de texto.

## 🍿 Idea del proyecto

Hay un catálogo común donde cualquier usuario registrado puede añadir contenidos, buscarlos, filtrarlos por tipo y darles «me gusta». El programa también sabe cuál es el contenido más valorado. Al cerrar, todo se escribe en disco, y al volver a abrir se recupera.

## 👥 Cuentas y contenidos

* 🔐 **Cuentas:** registro de usuarios nuevos e inicio de sesión.
* 🎞️ **Contenido:** título, plataforma, descripción, género, enlace, calificación por edades y número de likes.
* 🎥 **Películas:** añaden director, distribuidora, año de estreno y duración.
* 📺 **Series:** añaden número de temporadas, estado (en emisión o finalizada) y su lista de episodios.
* 🎙️ **Podcasts:** añaden tipo, fecha de caducidad y su lista de episodios.

## 🧭 Menú principal

| 🔢 | 📖 Acción |
|---|---|
| 1 | Añadir contenido nuevo. |
| 2 | Buscar por título. |
| 3 | Mostrar todos los contenidos. |
| 4 | Mostrar los de un tipo. |
| 5 | Ver el contenido con más likes. |
| 6 | Dar like a un contenido. |
| 7 | Cerrar sesión. |

## 🗺️ Mapa de clases

* **`Contenido`**: clase base con los datos comunes y métodos `virtual` para mostrar y exportar.
* **`Pelicula`**, **`Serie`** y **`Podcast`**: heredan de `Contenido` y sobrescriben esos métodos.
* **`Episodio`**: título, temporada y número de episodio.
* **`Usuario`**: nombre y contraseña.
* **`Catalogo`**: lista de contenidos y de usuarios, login y lectura/escritura de ficheros.
* **`Program.cs`**: menús y flujo principal.

## 📁 Datos guardados

Los usuarios y los contenidos se escriben en dos ficheros de texto, `Usuarios.txt` y `Contenidos.txt`, que se crean junto al ejecutable la primera vez que se usa el programa.

## 🧪 Qué se ha practicado

* 🧬 **Herencia y polimorfismo** con tres tipos de contenido.
* 🧩 **Composición:** series y podcasts contienen episodios.
* 🗂️ **Separación de responsabilidades** entre el catálogo y el menú.
* 💾 **Ficheros** con `FileStream` y `StreamWriter`.
* 🛡️ **Comprobaciones de datos:** título repetido, edad válida y tipo de contenido.
* 🤝 **Trabajo en equipo.**

## ⚙️ Cómo abrirlo

1. Abre `GestorDeContenidos.sln` con **Visual Studio**.
2. Compila y ejecuta con **F5**.
3. Crea un usuario nuevo, inicia sesión y empieza a añadir contenidos.

---
🎓 *Proyecto en equipo sobre herencia, composición y persistencia de datos en C#.*
