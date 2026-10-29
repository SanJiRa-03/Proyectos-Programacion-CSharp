# Gestor de Contenidos en C# (película, series y podcasts)

Plataforma de consola, a modo de catálogo de streaming, donde los usuarios se registran, inician sesión y gestionan **películas, series y podcasts**. Proyecto realizado **en equipo**.

## 🚀 Características

* **Usuarios:** registro de nuevos usuarios e inicio de sesión.
* **Jerarquía de contenidos:** una clase base `Contenido` de la que heredan `Pelicula`, `Serie` y `Podcast`, con métodos `virtual`/`override` para mostrar y exportar cada tipo.
* **Composición:** una `Serie` contiene una lista de `Episodio`; un `Podcast` también agrupa los suyos.
* **Catálogo:** la clase `Catalogo` centraliza la gestión de los contenidos y la separa del menú.
* **Persistencia de datos:** usuarios y contenidos se guardan en ficheros de texto y se recuperan al volver a abrir el programa.

## 📋 Menú del programa

1. Añadir nuevo contenido (película, serie o podcast).
2. Buscar un contenido por su título.
3. Mostrar todos los contenidos.
4. Mostrar los contenidos de un tipo.
5. Mostrar el contenido con más likes.
6. Valorar un contenido (dar like).
7. Cerrar sesión.

## 🛠️ Tecnologías aplicadas

* Lenguaje C# (.NET Framework)
* Herencia, polimorfismo, composición y encapsulamiento
* Colecciones dinámicas (`List<T>`)
* Entrada/Salida y manejo de ficheros (`System.IO`)
* Gestión de errores con `try/catch`
* Trabajo en equipo

## ▶️ Ejecución

Abre `GestorDeContenidos.sln` con Visual Studio y pulsa **F5**. Los ficheros de datos se crean solos junto al ejecutable.
