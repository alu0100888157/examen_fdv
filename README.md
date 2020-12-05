# examen_fdv
Examen_FDV
En este examen podemos ver:

Jugador, Enemigo1, Enemigo2 y Gatete son los personajes de este juego quitando al jugador que es controlado por nosotros el resto se mueve de derecha a izquierda.

Mojon1, Mojon2 y Mojon3 son una forma de ganar una vida, hasta que el jugador no se haya acercado a los 3 no ganará dicha vida.

Los scripts, tenemos desde sencillos como el CameraFollow que sigue al jugador mientras se mueve y el Mojones.cs que hace que cuando el jugador se acerque al collider del mojón correspondiente, salte un trigger que le suma +1 a una variable, si esa variable llega a 3, se le incrementa la vida al jugador.

GateteMovement.cs realiza el movimiento del gatito y también cuando el jugador hace contacto con el collider, le sube el nivel de poder en 1.

Lo mismo pasa con los enemigos, pero en vez de subirle el poder le quita una vida y le deja el poder a 0, también estos tienen un método de spawn hecho por pooling de objetos y cada 20 segundos spawnean en su posición inicial.

(El Game.cs lo estaba realizando en el examen para arreglar algunos problemas del pooling, pero no me dio tiempo a acabarlo y dejé todo en la versión anterior)
Por último, el PlayerMovement.cs se encarga de realizar el movimiento y las animaciones correspondientes y sumarle una vida cuando llegue a 3 mojones.


PD: los vídeos y gifs del juego los iré subiendo esta tarde, perdone la tardanza.
