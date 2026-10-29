# 🛒 07 - Sistema de Gestión de Ventas en C# (Windows Forms)

Aplicación de escritorio desarrollada en **C# con Windows Forms** como práctica de gestión de productos mediante una interfaz gráfica. Permite introducir información de productos en una tabla, seleccionar registros para consultar sus datos, modificar campos y eliminar filas. 🖥️

> 📌 **Estado actual:** el código compartido implementa una gestión básica de productos **en memoria**. Aunque el proyecto se denomina *Sistema de Gestión de Ventas*, en esta versión no se registran ventas ni se calculan importes de compra.

## 🚀 Funcionalidades

* ➕ **Añadir productos:** introduce los datos mediante los campos de texto y los incorpora al `DataGridView`.
* 🔍 **Consultar productos:** al seleccionar una celda de una fila, sus valores se cargan en los campos del formulario.
* ✏️ **Editar productos:** permite modificar los valores del registro seleccionado mediante el botón **Guardar**.
* 🗑️ **Eliminar productos:** elimina la fila seleccionada.
* 🪟 **Interfaz gráfica:** utiliza controles de Windows Forms, como `TextBox`, `Button`, `Label` y `DataGridView`.

## 🧾 Datos de los productos

La interfaz recoge los siguientes campos:

| 🏷️ Campo | 📖 Descripción |
|---|---|
| 🔢 Número de producto | Campo de texto destinado al número o identificador introducido por el usuario. |
| 📊 Código de barras | Código que identifica el producto. |
| 📦 Denominación | Nombre o descripción del producto. |
| 💶 Precio | Precio introducido para el producto. |
| 📥 Stock | Cantidad disponible indicada para el producto. |

La aplicación también genera un **contador incremental** para las filas añadidas. En el código actual, los encabezados de la tabla y el orden en que se incorporan los valores no coinciden completamente; conviene revisar las columnas para que cada dato aparezca bajo el encabezado correcto.

## 🛠️ Tecnologías y conceptos utilizados

* 💻 **C#** como lenguaje de programación.
* 🪟 **Windows Forms** para construir la interfaz de escritorio.
* 📋 **DataGridView** para mostrar y editar los registros en forma de tabla.
* 🖱️ **Eventos** para gestionar los clics de los botones y la selección de filas.
* 🧩 **Métodos** para separar operaciones, como `limpiar()`, `btnAgregar_Click`, `btnGuardar_Click` y `btnEliminar_Click`.
* 🗃️ **Colección de filas** del `DataGridView` para administrar los datos mostrados durante la ejecución.

## 🗂️ Organización del código

| 📄 Archivo | 🎯 Responsabilidad |
|---|---|
| `Program.cs` | Configura la aplicación Windows Forms y abre `Form1`. |
| `Form1.cs` | Contiene la lógica para añadir, seleccionar, editar y eliminar productos, así como para limpiar los campos del formulario. |
| `Form1.Designer.cs` | Contiene la definición y configuración de los controles gráficos creados con el diseñador de Visual Studio. |

## ▶️ Ejecución

1. Abre la solución del proyecto en **Visual Studio**.
2. Comprueba que el proyecto tenga configurado **Windows Forms** y que los recursos referenciados existan.
3. Compila la solución.
4. Ejecuta la aplicación y utiliza los campos del formulario para añadir productos. Selecciona una fila para cargar sus datos y poder editarla o eliminarla.

## 🔭 Alcance y mejoras posibles

En el código proporcionado, los registros se guardan únicamente en el `DataGridView` **mientras la aplicación está abierta**. No se implementa lectura ni escritura de productos en archivos o bases de datos, aunque aparece `using System.IO` en los imports.

Otras mejoras que se podrían añadir en futuras versiones:

* ✅ Validar que los campos obligatorios no estén vacíos.
* 🔢 Comprobar que el precio y el stock sean valores numéricos válidos y que el stock no sea negativo.
* 🧱 Corregir los encabezados y el orden de las columnas de la tabla.
* 🛡️ Gestionar de forma segura la selección antes de editar o eliminar una fila.
* 💾 Guardar y recuperar productos al cerrar y volver a abrir la aplicación.
* 💰 Incorporar operaciones propias de ventas, como unidades vendidas, cálculo de totales y actualización automática del stock, si ese es el objetivo final del proyecto.

---
🎓 *Proyecto de práctica centrado en la creación de una interfaz de escritorio con C# y Windows Forms para gestionar un listado de productos.*
