Problemas de IPv4-Necesidad de IPv6.
- IPv4 se esta quedando sin direcciones. IPv6 es sucesor de IPv4. IPv6 tiene un espacio de direcciones de 128 bits mucho mas grande.
- El desarrollo de IPv6 también incluyo correcciones para limitaciones IPv4 y otras mejoras.
- Con una población que accede a internet cada vez mayor un espacio de direcciones IPv4 limitado, los problemas d e NAT y la Internet de todo, llegó el momento de comenzar la transición hacia IPv6.
Coexistencia  de IPv4 e IPv6
- Dual stack: los dispositivos ejecutan pilas de protocolos 
- Tunneling: 
- Translation: 
IPv6 formatos de direcciones IPv6
- Las direcciones ipv6 tiene  128 bits de longitud y están escritas en hexadecimal.
- las direcciones ipv6 no distingue entre mayúsculas y minúsculas y pueden escribirse en minúsculas p en mayúsculas
- el formato preferido para escribir una IPV6 es x:x:x:x:x:x:x:x, donde cada x consta de cuatro valores hexadecimales.
Regla 1- omitir el cero inicial
 Las primeras reglas ayudan a reducir la notación de las direcciones ipv6 es omitir los 0s (ceros iniciales).
 ejemplos:
 - 01ab se puede representar como 1ab
 - 09f0 se puede representar como 9f0
 - 0a00 se puede representar como a00
 - 00ab se puede representar como ab
 
 Regla 2-Dos puntos
  Los dos puntos dobles(::) pueden remplazar cualquier cadena única y continua de uno o mas segmentos de 16 bits que estén compuestas solo por ceros.
Ejemplos:
- 2001:db8;cafe. 1:0:0.01(0s iniciales omitidos) podrían representarse como 2001:db8:cafe:1::1
Nota: los dos puntos dobles se pueden utilizar solamente una vez dentro de una direccione;  lo contrario habría mas de una dirección resultante posible.


UNICAST, MULTICAST, ANYCAST

1. **Unicast**: Es un tipo de comunicación en redes donde un único origen envía datos a un único destino. Es el método más común de comunicación en internet, donde un dispositivo envía datos a otro dispositivo específico mediante su dirección IP única.(de uno a uno)
    
2. **Multicast**: Es un método de comunicación en redes donde un único origen envía datos a múltiples destinos simultáneamente. En lugar de enviar copias separadas de los datos a cada destinatario, el origen envía una única copia que se distribuye a través de la red solo a aquellos destinatarios que están suscritos al grupo de multidifusión.(de uno a muchos)
    
3. **Anycast**: Es un método de comunicación en redes donde un origen envía datos a la "mejor" ubicación disponible entre múltiples destinatarios que comparten la misma dirección de destino. La red determina automáticamente la ruta más eficiente para dirigir el tráfico al destinatario más cercano o disponible, lo que puede ayudar a mejorar la eficiencia y la disponibilidad de los servicios en línea.(difusión por proximidad)

Notas: a diferencia de IPv4 no tiene una dirección broadcast. sin embargo existe una dirección ipv6 de multicast de todos los nodos que brinda básicamente el mismo resultado.

Longitud de prefijo IPv6

