# 🛒 07 - Sistema de Gestión de Ventas en C# (Windows Forms)

Aplicación de escritorio desarrollada en **C# con Windows Forms** para gestionar un listado de productos desde una interfaz gráfica. Los datos se introducen en una tabla, se pueden consultar al seleccionar una fila, modificarse y eliminarse. 🖥️

> 📌 **Alcance de esta versión:** es una gestión básica de productos que trabaja **en memoria** mientras la aplicación está abierta. Aunque el proyecto se llama *Sistema de Gestión de Ventas*, esta versión no registra ventas ni calcula importes de compra.

## 🚀 Funcionalidades

* ➕ **Añadir:** los datos escritos en los campos de texto se incorporan como una fila nueva del `DataGridView`.
* 🔍 **Consultar:** al pulsar una fila, sus valores aparecen de nuevo en el formulario.
* ✏️ **Editar:** se cambian los valores y el botón **Guardar** actualiza la fila seleccionada.
* 🗑️ **Eliminar:** borra la fila que esté seleccionada.
* 🔢 **Contador:** la aplicación numera automáticamente las filas que se van añadiendo.

## 🧾 Campos de cada producto

| 🏷️ Campo | 📖 Qué recoge |
|---|---|
| 🔢 Número de producto | Número o identificador escrito por el usuario. |
| 📊 Código de barras | Código con el que se identifica el producto. |
| 📦 Denominación | Nombre o descripción del producto. |
| 💶 Precio | Precio indicado para el producto. |
| 📥 Stock | Unidades disponibles. |

## 🛠️ Tecnologías y conceptos

* 💻 **C#** como lenguaje.
* 🪟 **Windows Forms** para la interfaz de escritorio, con `TextBox`, `Button`, `Label` y `DataGridView`.
* 📋 **DataGridView** para mostrar los registros en forma de tabla.
* 🖱️ **Eventos** de botones y de selección de filas.
* 🧩 **Métodos separados** para cada operación: `limpiar()`, `btnAgregar_Click`, `btnGuardar_Click` y `btnEliminar_Click`.
* 🗃️ **Colección de filas** del `DataGridView` como almacén de los datos durante la ejecución.

## 🗂️ Cómo está organizado

| 📄 Archivo | 🎯 Función |
|---|---|
| `Program.cs` | Configura la aplicación Windows Forms y abre `Form1`. |
| `Form1.cs` | Lógica de añadir, seleccionar, editar y eliminar productos, y de limpiar los campos. |
| `Form1.Designer.cs` | Definición de los controles gráficos creados con el diseñador de Visual Studio. |

## ▶️ Cómo ejecutarlo

1. Abre la solución en **Visual Studio**.
2. Comprueba que el proyecto está configurado como aplicación de **Windows Forms**.
3. Compila la solución.
4. Ejecuta la aplicación, rellena los campos y añade productos. Pulsa una fila para cargar sus datos y editarla o eliminarla.

---
🎓 *Práctica para crear una interfaz de escritorio con C# y Windows Forms que gestione una lista de productos.*
