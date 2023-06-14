# Examen Multijugador

**El examen consiste en crear un juego muy simple con características multijugador con lo que se demuestre que se han adquirido los conociemientos de la asignatura.**

Tendremos un plano vacío, cuando se conecte un jugador, aparecerá en una de las cuatro esquinas del plano.

Cada jugador se podrá mover por el plano con WASD o las flechas del teclado.

Al inicio, los jugadores serán aleatoriamente de color blanco o negro.

Cuando un jugador pulse la tecla espacio, todos los otros jugadores cambiarán de color (de blanco a negro y de negro a blanco) (cambiarán todos menos quien pulsa el espacio).

La tecla para cambiar de color se podrá pulsar un máximo de 3 veces y tendrán que pasar 3 segundos desde que pulsamos una vez hasta que podemos pulsar la siguiente.

Los jugadores negros se podrán comer a los blancos. (Si se produce una colisión, el jugador blanco desaparecerá, el negro continuará la partida)

El servidor llevará una cuenta de cuantos asesinatos lleva cada jugador y aumentará en un 0.15% la velocidad por cada asesinato.

Cuando un jugador muere, lo cambiaremos a una escena diferente llamada GameOver.

## Configuración (1.5)

Configurar `NetworkManager`

Crear UI para lanzar Server / Client


## Básico (1.5)

Conseguir que al tener una instancia Server activa, al conectar un cliente éste aparezca en una esquina vacía.

Hacer que solo se mueva el jugador al que le corresponde.

Sincronizar el movimiento de los jugadores en todos los clientes.

## Network Variables (2)

Demostrar que se entiende cómo y en qué situaciones utilizar 'Network Variables'

```c#
// Inicializar
NetworkVariable<int> lives = new NEtworkVarible<int>(value: 3, NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner)

// Actualizar
lives.Value = x;

// Recibir cambios
lives.onValueChanged += OnLivesChanged;

void OnLivesChanged(int oldValue, int newValue)
{
	//...
}
```

## RPCs (2)

Demostrar que se entiende cómo y en qué situaciones utilizar métodos RPC.


```c#
// Básico
[ServerRpc]
void Immortal_ServerRpc()
{
	Immortal_ClientRpc();
}

[ClientRpc]
void Immortal_ClientRpc()
{
	// ...	
}

// Avanzado
[ServerRpc]
CreateShield_ServerRpc(ServerRpcParams parameters = default)
{
	// ...
}
```

## Otros (2)

Modificar la velocidad desde el servidor.

El jugador local tendrá un puntero encima de color rojo para distinguirlo del resto.

El servidor aceptará un máximo de 4 jugadores, uno por esquina.

## Avanzado (1)

Destrucción de los jugadores sin errores.

Cambio de escena cuando un jugador muere.

> El script `ClientNetworkTransform` está en Assets/Scripts/ClientNetworkTransform.cs