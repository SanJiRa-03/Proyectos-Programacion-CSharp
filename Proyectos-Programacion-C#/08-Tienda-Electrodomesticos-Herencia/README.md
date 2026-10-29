# Tienda de Electrodomésticos en C# (Herencia)

Sistema de consola para gestionar el catálogo de una tienda de electrodomésticos. Es una práctica pensada para aplicar la **herencia** y el **polimorfismo**: los datos comunes viven en una clase base y cada tipo de aparato añade lo suyo.

## 🚀 Características

* **Jerarquía de clases:** una clase base `Electrodomestico` (marca, modelo, eficiencia energética, año y si sigue fabricándose) de la que heredan `Lavadora`, `Lavavajillas`, `Nevera` y `Horno`.
* **Polimorfismo:** el método `MostrarInfo()` es `virtual` y cada clase hija lo sobrescribe para enseñar sus datos específicos (programas de lavado, capacidad, autolimpiado…).
* **Menú interactivo:** introducir un electrodoméstico nuevo, mostrar todos, mostrar solo los descatalogados y filtrar por marca.
* **Validación de datos:** las respuestas de tipo sí/no y el año de fabricación se piden de nuevo hasta que son válidos.

## 📋 Menú del programa

1. Introducir un nuevo electrodoméstico (lavadora, lavavajillas, nevera u horno).
2. Mostrar todos los electrodomésticos con su información.
3. Mostrar los electrodomésticos descatalogados.
4. Mostrar los electrodomésticos de una marca determinada.
5. Salir.

## 🛠️ Tecnologías aplicadas

* Lenguaje C# (.NET Framework)
* Herencia, polimorfismo y encapsulamiento
* Colecciones dinámicas (`List<T>`)
* Aplicación de consola con menús

## ▶️ Ejecución

Abre `TiendaElectrodomesticosHerencia.sln` con Visual Studio y pulsa **F5**.
