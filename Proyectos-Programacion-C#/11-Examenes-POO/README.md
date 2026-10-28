# 11 · Exámenes de POO

Tres ejercicios planteados como examen. En todos hay que diseñar una jerarquía de clases, ofrecer un menú de consola y guardar y leer la información en ficheros de texto.

| Carpeta | De qué va | Contenidos |
|---|---|---|
| [Biblioteca-de-Materiales](Biblioteca-de-Materiales) | Gestión de materiales de una biblioteca: libros, revistas y periódicos. | Clase abstracta `Material` con métodos abstractos (`WriteInfo`, `GetInfo`) implementados en `Libro`, `Revista` y `Periodico`; lectura y escritura de ficheros. |
| [Tienda-de-Instrumentos](Tienda-de-Instrumentos) | Tienda de guitarras y pianos con **alquiler** por número de serie. | Herencia (`Instrumentos` → `Guitarras`, `Pianos`), `virtual`/`override`, listado de instrumentos alquilados, `try/catch`. |
| [Deportistas](Deportistas) | Registro de deportistas de atletismo, ciclismo y natación. | Herencia (`Deportista` → `Atletismo`, `Ciclismo`, `Natación`), datos específicos por deporte y persistencia en fichero. |

**Conceptos comunes:** herencia, abstracción, polimorfismo, encapsulación, `List<T>`, ficheros (`StreamReader`/`StreamWriter`) y control de errores.

Cada carpeta contiene su propio `.sln`.
