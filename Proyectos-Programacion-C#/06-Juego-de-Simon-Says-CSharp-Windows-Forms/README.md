# 🎮 06 - Simon Says (C# / Windows Forms)

Versión de escritorio del clásico juego de memoria **Simon Says**. En pantalla se ilumina una secuencia de cuatro colores (🔴 rojo, 🟡 amarillo, 🟢 verde y 🔵 azul) y el jugador debe repetirla pulsando los paneles en el mismo orden. Está desarrollado con **C#, Windows Forms y .NET Framework 4.8** como **práctica individual**, y la memoria del proyecto la redacté yo. 📝

## 🕹️ ¿Qué hace la aplicación?

* 🔐 **Inicia sesión** (`Form2`): lee `usuarios.txt` y comprueba que el usuario y la contraseña coinciden con alguno de los registros guardados.
* 🧾 **Registra cuentas nuevas** (`Form3`): comprueba que no queden campos vacíos y que las dos contraseñas sean iguales; después añade el usuario a `usuarios.txt`.
* 🎲 **Genera secuencias aleatorias:** cada ronda añade un color nuevo a una lista, la reproduce en orden y espera a que el jugador la repita.
* 💡 **Ilumina los paneles:** cada color tiene una imagen normal y otra iluminada que cambia con los eventos `Click`, `MouseDown` y `MouseUp`.
* ⭐ **Cuenta los puntos** de la partida y ofrece los botones *New Game* y *Exit*.

## 🗂️ Piezas del proyecto

| 📄 Archivo | 🎯 Qué contiene |
|---|---|
| `Program.cs` | Arranca la aplicación y muestra primero `Form2`. |
| `Form1.cs` | Pantalla del juego: paneles de colores, secuencias, respuestas y puntos. |
| `Form2.cs` | Pantalla de inicio de sesión. |
| `Form3.cs` | Pantalla de registro de usuarios. |
| `Usuarios.cs` | Clase con el nombre y la contraseña de cada usuario. |
| `Properties/Resources.resx` | Imágenes de los cuatro colores, en estado normal e iluminado. |
| `Memoria_Practica_3_Simon.pdf` | Memoria individual de la práctica. |
| `Presentacion_Simon_Says.pptx` | Presentación del proyecto. |
| `Texto_LinkedIn_Simon_Says.txt` | Texto de publicación para LinkedIn. |

## 🧠 Lo que se practica

* 🪟 **Windows Forms:** formularios, paneles, botones y etiquetas.
* 🖱️ **Eventos de ratón** para reaccionar a cada pulsación.
* 📋 **`List<int>`** para guardar la secuencia y **`Random`** para ampliarla.
* 💾 **Ficheros de texto** con `StreamReader`, `StreamWriter` y `File.Exists`.
* 🧩 **Varios formularios** que se reparten el login, el registro y el juego.
* 🔒 **Clase `Usuarios`** con atributos privados, constructor y métodos de acceso.

## 🚦 Cómo probarlo

1. Abre `Simon.sln` con **Visual Studio** en Windows.
2. Comprueba que el proyecto apunta a **.NET Framework 4.8**.
3. Crea el archivo `usuarios.txt` en la carpeta de ejecución (normalmente `Simon/bin/Debug/`) copiando `usuarios.txt.example`. Debe llamarse exactamente `usuarios.txt`.
4. Compila y ejecuta el proyecto **Simon**.
5. Entra con la cuenta que hayas dejado en el fichero o crea una nueva en **Nuevo usuario**.

📌 El fichero guarda un usuario por línea con el formato `usuario,contraseña`.

## 📎 Documentación incluida

Nota: La carpeta incluye la **memoria** que escribí para esta práctica.

---
🎓 *Práctica académica para trabajar C#, Windows Forms, eventos y ficheros de texto.*
