# 🎮 06 - Simon Says (C# / Windows Forms)

Aplicación de escritorio inspirada en el juego de memoria **Simon Says**. El jugador observa una secuencia de cuatro colores (🔴 rojo, 🟡 amarillo, 🟢 verde y 🔵 azul) y trata de repetirla. El proyecto está desarrollado en **C# con Windows Forms y .NET Framework 4.8**. Es una **práctica individual** y la memoria del proyecto fue redactada por mí. 📝

## 🚀 Funcionalidades implementadas

* 🔐 **Pantalla de inicio de sesión (`Form2`):** lee `usuarios.txt` y compara el usuario y la contraseña introducidos con los registros almacenados.
* 🧾 **Registro de usuarios (`Form3`):** valida que los campos estén completos y que las dos contraseñas coincidan; después lee los registros existentes y escribe la lista actualizada en `usuarios.txt`.
* 🕹️ **Juego (`Form1`):** cuatro paneles de color con imágenes en estado normal e iluminado, botón *New Game*, botón *Exit* y etiqueta de puntos.
* 🎲 **Secuencias aleatorias:** `Random` elige un valor que se añade a una `List<int>`; el formulario reproduce los elementos en orden y el usuario responde haciendo clic en los colores.
* 🖱️ **Eventos gráficos:** los eventos `Click`, `MouseDown` y `MouseUp` controlan la selección de los colores y el cambio de imagen.
* 🖼️ **Recursos visuales:** las imágenes de los cuatro colores se guardan en los recursos del proyecto.

## 🗂️ Estructura del proyecto

| 📄 Archivo / clase | 🎯 Responsabilidad |
|---|---|
| `Program.cs` | Punto de entrada; inicia la aplicación mostrando `Form2`. |
| `Form1.cs` | Interfaz y lógica de la partida, secuencias, entrada de colores y puntos. |
| `Form2.cs` | Inicio de sesión y lectura de usuarios desde `usuarios.txt`. |
| `Form3.cs` | Registro de usuarios, validación de campos y escritura del fichero. |
| `Usuarios.cs` | Modelo de usuario con nombre y contraseña, constructor y métodos de acceso. |
| `Properties/Resources.resx` | Recursos gráficos utilizados por los botones de colores. |
| `Memoria_Practica_3_Simon.pdf` | Memoria de esta práctica individual, redactada por mí para documentar el proyecto. |
| `Presentacion_Simon_Says.pptx` | Presentación del proyecto y su implementación. |
| `Texto_LinkedIn_Simon_Says.txt` | Propuesta de publicación para LinkedIn. |

## 🛠️ Tecnologías y conceptos

* 💻 **C#** y **.NET Framework 4.8**.
* 🪟 **Windows Forms**, controles gráficos y eventos de usuario.
* 📋 `List<int>` para almacenar la secuencia y `Random` para generar nuevos elementos.
* 💾 `StreamReader`, `StreamWriter` y `File.Exists` para persistencia local en texto.
* 🧩 Separación básica en formularios para login, registro y juego.
* 🔒 Constructores, atributos privados y métodos de acceso en la clase `Usuarios`.

## ▶️ Cómo ejecutar

1. Abre `Simon.sln` con **Visual Studio** en Windows.
2. Comprueba que el proyecto utiliza **.NET Framework 4.8**.
3. Crea el fichero `usuarios.txt` en el directorio de trabajo de la aplicación (normalmente `Simon/bin/Debug/`) a partir de `usuarios.txt.example`. Asegúrate de que se llama exactamente `usuarios.txt`.
4. Compila y ejecuta el proyecto **Simon**.
5. Inicia sesión con la cuenta de prueba que hayas configurado en el fichero, o crea una nueva mediante **Nuevo usuario**.

📌 El fichero usa una línea por usuario, con el formato `usuario,contraseña`. La aplicación actual espera encontrar el archivo en su directorio de trabajo. Si falta durante el inicio de sesión, el código de `Form2` no controla todavía esa situación.

## ⚠️ Limitaciones conocidas y mejoras posibles

La documentación describe el comportamiento que se encuentra en el código incluido. Hay varios aspectos que convendría revisar antes de considerar la aplicación terminada:

* 🔢 **Comprobación de secuencia:** `Random.Next(0, 4)` genera valores de 0 a 3, mientras que los nombres de los botones se convierten a valores de 1 a 4. Además, `Verificar_Secuencia` compara con `>=` en lugar de exigir una coincidencia exacta. Esto puede aceptar colores incorrectos y hace que la correspondencia necesite corregirse.
* 🧵 **Actualización de la interfaz:** la secuencia se reproduce en un `Thread` que actualiza directamente controles de Windows Forms; sería preferible utilizar un mecanismo compatible con el hilo de interfaz, por ejemplo `Timer` o `async/await` con pausas adecuadas.
* 🏁 **Puntuación y fin de partida:** la actualización de puntos y el reinicio de la lista pueden mejorarse para que el flujo del juego sea más claro y consistente.
* 🔑 **Credenciales:** las contraseñas se guardan en texto plano. Es adecuado solo como ejercicio académico; una aplicación real debería usar almacenamiento seguro de credenciales.
* 👤 **Validación de cuentas:** no se comprueba si el nombre de usuario ya existe y el login no trata explícitamente el caso de fichero ausente o líneas mal formadas.

## 📚 Documentación incluida

La carpeta contiene la **memoria** que redacté individualmente para esta práctica, una **presentación** actualizada que explica las clases, el flujo y las limitaciones detectadas, y un **texto de ejemplo** para difundir el proyecto en LinkedIn.

---
🎓 *Proyecto académico realizado para practicar C#, Windows Forms, eventos y lectura/escritura de ficheros.*
