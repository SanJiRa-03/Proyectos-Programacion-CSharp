# 10 · Gestor de contenidos

## ¿De qué va la práctica?
Una plataforma de consola, a modo de catálogo de streaming, para gestionar **películas, series y podcasts**. Cada usuario se registra, inicia sesión y puede consultar y valorar los contenidos. Proyecto realizado **en equipo**.

## ¿Qué incluye?
- **Registro e inicio de sesión** de usuarios.
- Añadir nuevo contenido (película, serie o podcast).
- Buscar un contenido por su título.
- Mostrar todos los contenidos o solo los de un tipo.
- Mostrar el contenido con **más likes** y dar like a un contenido.
- **Persistencia en ficheros de texto**: los usuarios y contenidos se guardan y se recuperan al volver a abrir el programa.

## Contenidos que se practican
- **Herencia y polimorfismo**: `Contenido` como clase base de `Pelicula`, `Serie` y `Podcast`, con métodos `virtual`/`override` para mostrar y exportar los datos.
- **Composición**: una `Serie` contiene sus `Episodio`.
- **Clases de gestión**: `Catalogo` y `Usuario` separan la lógica de los datos.
- **Ficheros** con `StreamReader` y `StreamWriter`.
- **Gestión de errores** con `try/catch` y trabajo colaborativo en equipo.

## Ejecutar
Abrir `GestorDeContenidos.sln` en Visual Studio y pulsar F5. Los ficheros `Usuarios.txt` y `Contenidos.txt` se crean solos junto al ejecutable.
