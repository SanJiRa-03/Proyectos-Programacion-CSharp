# Sistema de Gestión de Pedidos - Restaurante (C#)

Sistema informático de consola desarrollado en C# para gestionar el proceso de solicitud, preparación y entrega de pedidos en un restaurante. Este proyecto es una demostración práctica de los fundamentos de la Programación Orientada a Objetos (POO).

## 📋 Características Principales

El sistema ofrece un menú interactivo con las siguientes opciones:
1. **Crear nuevo pedido:** Genera pedidos basados en tres tipos de menús predefinidos:
   - **Menú Estándar:** Bebida, principal, postre y hasta dos complementos opcionales.
   - **Menú Foddie:** Bebida, principal, complemento, segundo plato y postre.
   - **Menú Light:** Bebida, principal y un postre opcional.
2. **Visualizar pedidos:** Muestra el listado de pedidos filtrados por su estado, detallando los componentes incluidos y el cálculo del precio final polimórfico.
3. **Cambiar estado de pedido:** Transición lógica entre `En preparación` ➔ `En reparto` ➔ `Entregado`.

## 🛠️ Conceptos Técnicos Aplicados

- **Herencia:** Jerarquía de clases centralizada en una clase base `Menu`.
- **Polimorfismo:** Sobrescritura de métodos para el cálculo de precios y muestra de detalles dependiendo de la instancia del menú.
- **Composición:** Los objetos `Menu` están compuestos por instancias de clases derivadas de `Componente` (Bebidas, Platos, Postres).
- **Manejo de Listas:** Uso de `List<T>` para el almacenamiento en memoria de las comandas y los componentes de cada menú.

## 🚀 Ejecución

Clona el repositorio, abre la solución en Visual Studio (o VS Code) y ejecuta el proyecto de consola `Examen CE.sln`. Sigue las instrucciones numéricas en pantalla para operar el sistema.