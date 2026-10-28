# 08 · Tienda de electrodomésticos (herencia)

## ¿De qué va la práctica?
Una tienda de electrodomésticos de consola. El usuario va introduciendo productos (lavadoras, lavavajillas, neveras y hornos) y el programa los guarda en una lista para consultarlos después.

## ¿Qué incluye?
- Introducir un nuevo electrodoméstico eligiendo su tipo.
- Mostrar todos los electrodomésticos con su información.
- Mostrar los electrodomésticos **descatalogados**.
- Filtrar los electrodomésticos por **marca**.
- Cada tipo tiene sus propias características (por ejemplo, carga de la lavadora, capacidad de la nevera o autolimpiado del horno).

## Contenidos que se practican
- **Herencia**: la clase base `Electrodomestico` reúne los datos comunes y `Lavadora`, `Lavavajillas`, `Nevera` y `Horno` heredan de ella.
- **Polimorfismo**: `MostrarInfo()` es `virtual` y cada clase hija lo sobrescribe (`override`).
- **Encapsulación**: atributos privados con constructores y propiedades.
- **Colecciones**: `List<Electrodomestico>` con recorridos, búsquedas y filtros.
- **Menús de consola** y validación de entradas.

## Ejecutar
Abrir `TiendaElectrodomesticosHerencia.sln` en Visual Studio y pulsar F5.
