# 🎬 10 - Gestor de Contenidos en C# (películas, series y podcasts)

Plataforma de consola, a modo de catálogo de streaming, desarrollada en **C#**, donde los usuarios se registran, inician sesión y gestionan **películas, series y podcasts**. Es un proyecto realizado **en equipo** 🤝, con persistencia de datos en ficheros de texto.

## 🚀 Funcionalidades

* 🔐 **Usuarios:** registro de nuevos usuarios e inicio de sesión.
* ➕ **Añadir contenido:** películas, series o podcasts con sus datos (título, plataforma, descripción, género, enlace y calificación por edades).
* 🔎 **Buscar** un contenido por su título.
* 📋 **Mostrar** todos los contenidos o solo los de un tipo.
* 👍 **Likes:** dar «me gusta» a un contenido y consultar el más valorado.
* 💾 **Persistencia:** usuarios y contenidos se guardan en ficheros de texto y se recuperan al volver a abrir el programa.

## 📋 Menú del programa

1. Añadir nuevo contenido.
2. Buscar contenido por su título.
3. Mostrar todos los contenidos (películas, series y podcasts).
4. Mostrar todos los contenidos de un tipo.
5. Mostrar el contenido con mayor número de likes.
6. Valorar un contenido (dar like).
7. Cerrar sesión.

## 🧱 Estructura del proyecto

| 🧩 Clase | 🎯 Responsabilidad |
|---|---|
| `Contenido` (base) | Título, plataforma, descripción, género, enlace, calificación y likes. Métodos `virtual` para mostrar y exportar. |
| 🎥 `Pelicula` | Añade director, distribuidora, año de estreno y duración. |
| 📺 `Serie` | Añade número de temporadas, estado (en emisión o finalizada) y una lista de episodios. |
| 🎙️ `Podcast` | Añade tipo, fecha de caducidad y su lista de episodios. |
| `Episodio` | Título, temporada y número de episodio. |
| `Usuario` | Nombre y contraseña de cada usuario. |
| `Catalogo` | Gestiona la lista de contenidos y usuarios, el login, la lectura y la escritura de ficheros. |
| `Program.cs` | Menús y flujo principal del programa. |

## 🛠️ Tecnologías y conceptos

* 💻 **C#** y **.NET Framework**.
* 🧬 **Herencia y polimorfismo:** `Pelicula`, `Serie` y `Podcast` heredan de `Contenido` y sobrescriben sus métodos.
* 🧩 **Composición:** series y podcasts contienen listas de `Episodio`.
* 🗂️ **Separación de responsabilidades:** la clase `Catalogo` concentra la lógica y `Program` solo gestiona los menús.
* 💾 **Ficheros:** lectura y escritura con `FileStream` y `StreamWriter`.
* 🛡️ **Gestión de errores** y comprobaciones de datos (título repetido, edad válida…).
* 🤝 **Trabajo en equipo.**

## ▶️ Cómo ejecutar

1. Abre `GestorDeContenidos.sln` con **Visual Studio**.
2. Compila y ejecuta con **F5**.
3. Regístrate como nuevo usuario e inicia sesión.
4. Los ficheros de datos se crean solos en el directorio de ejecución la primera vez.

## 🔭 Mejoras posibles

* 🔑 Guardar las contraseñas de forma segura (ahora se guardan en texto plano, algo aceptable solo en un ejercicio académico).
* 🖥️ Crear una interfaz gráfica en lugar de la consola.
* 🔢 Más controles sobre entradas no numéricas.

---
🎓 *Proyecto en equipo para practicar herencia, composición y persistencia en ficheros con C#.*
