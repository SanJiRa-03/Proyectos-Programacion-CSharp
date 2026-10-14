# Hundir la Flota — Batalla Naval en C#

Proyecto de consola desarrollado en C# con **.NET Framework 4.8**. Permite jugar a Hundir la Flota en un tablero de **12 × 12**, ya sea contra el ordenador o contra otra persona. La flota se configura antes de comenzar y la partida avanza por turnos.

## 🎮 Funcionalidades

El menú principal presenta estas opciones:

1. **Cargar una partida anterior:** muestra las partidas guardadas en `previousgames.txt`. La opción está disponible en el menú, pero la restauración completa del tablero y la continuación de la partida aún no están implementadas.
2. **Jugar contra el ordenador:** el jugador configura su flota y juega contra el oponente controlado por el programa.
3. **Jugar a dos jugadores:** dos personas configuran sus barcos y juegan por turnos.
4. **Consultar el ranking:** muestra resultados de partidas finalizadas con el nombre del ganador y el número de movimientos.
5. **Salir:** termina el programa.

### Tablero y flota

- Tablero de **12 × 12** casillas.
- Cuatro barcos de distintos tamaños:
  - **Patrullera (`P`)**: 2 casillas.
  - **Submarino (`S`)**: 3 casillas.
  - **Destructor (`D`)**: 4 casillas.
  - **Portaaviones (`A`)**: 5 casillas.
- La colocación utiliza una coordenada inicial y una dirección: `u` (arriba), `d` (abajo), `l` (izquierda) o `r` (derecha).
- Los disparos distinguen entre agua e impacto. Un barco se considera hundido cuando sus impactos alcanzan su tamaño.
- El proyecto incluye código comentado relativo a la representación de islas, pero las islas no están activas en la versión incluida. Tampoco hay una mecánica de cargas o zonas explosivas implementada en el código actual.

## 🧱 Diseño orientado a objetos

- **Abstracción:** `Ship` y `Player` reúnen el comportamiento común de barcos y jugadores.
- **Herencia:** `PatrolBoat`, `Submarine`, `Destructor` y `AircraftCarriers` derivan de `Ship`; `Player1`, `Player2` y `PlayerUI` derivan de `Player`.
- **Polimorfismo:** las clases concretas especializan el comportamiento de los barcos y las modalidades de jugador.
- **Encapsulación:** el estado de los barcos y de los jugadores se consulta y modifica mediante métodos.
- **Colecciones:** listas y matrices permiten gestionar los barcos, los tableros, los disparos y los resultados.
- **Persistencia:** `Players` guarda datos de partidas en `previousgames.txt` y `Rankings` lee y escribe resultados en `rankings.txt`.

## 🗂️ Clases principales

| Clase | Responsabilidad |
|---|---|
| `Program` | Menú principal y navegación entre opciones. |
| `Game` | Flujo de la partida, turnos, disparos, condición de victoria y guardado al salir. |
| `BoardGame` | Representación del tablero, colocación de barcos, respuesta a disparos y comprobación de derrota. |
| `Ship` | Clase abstracta con el estado común de los barcos y la lógica para comprobar si están hundidos. |
| `PatrolBoat`, `Submarine`, `Destructor`, `AircraftCarriers` | Tipos de barco y tamaños de la flota. |
| `Player` | Clase abstracta base para los jugadores. |
| `Player1`, `Player2`, `PlayerUI` | Clases que gestionan la configuración y el comportamiento de los jugadores. |
| `Players` | Agrupa los jugadores, sus tableros y los datos de las partidas guardadas. |
| `Rankings` | Lectura, escritura y visualización de resultados de partidas finalizadas. |
| `Coordenadas` | Coordenada inicial y dirección de colocación de un barco. |

## 🚀 Ejecución

1. Abre `Practica2.sln` en Visual Studio desde la carpeta `Practica2_`.
2. Comprueba que el proyecto utiliza **.NET Framework 4.8**.
3. Compila la solución y ejecuta el proyecto `Practica2`.
4. Sigue las instrucciones de la consola para elegir el modo, colocar los barcos y jugar.

Los ficheros `previousgames.txt` y `rankings.txt` se utilizan para almacenar datos de partidas y resultados. Se encuentran en la carpeta del proyecto y se accede a ellos mediante rutas relativas.

## 📌 Controles

- **Direcciones de colocación:** `u` (arriba), `d` (abajo), `l` (izquierda), `r` (derecha).
- **Durante una partida:** `s` para disparar y `e` para guardar la información de la partida y salir.
- Las coordenadas `X` e `Y` se introducen como valores del 1 al 12.

## ⚠️ Estado conocido

La opción de guardar datos de una partida en curso está presente, pero **la carga y reanudación completa de una partida todavía está pendiente**: `PlaySelectedGame` lee información guardada, pero el código que reconstruye el tablero y reinicia el bucle de juego está comentado. Asimismo, la comprobación de disparos repetidos no gestiona correctamente todos los casos de disparos al agua. Las islas y las zonas explosivas tampoco forman parte de las mecánicas activas de esta versión.
