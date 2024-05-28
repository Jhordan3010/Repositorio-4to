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
  **Ejemplos:**
  - 2001:db8;cafe. 1:0:0.01(0s iniciales omitidos) podrían representarse como 2001:db8:cafe:1::1
  **Nota:** los dos puntos dobles se pueden utilizar solamente una vez dentro de una direccione;  lo contrario habría mas de una dirección resultante posible.

UNICAST, MULTICAST, ANYCAST
	1. **Unicast**: Es un tipo de comunicación en redes donde un único origen envía datos a un único destino. Es el método más común de comunicación en internet, donde un dispositivo envía datos a otro dispositivo específico mediante su dirección IP única.(de uno a uno)
	2. Multicast: Es un método de comunicación en redes donde un único origen envía datos a múltiples destinos simultáneamente. En lugar de enviar copias separadas de los datos a cada destinatario, el origen envía una única copia que se distribuye a través de la red solo a aquellos destinatarios que están suscritos al grupo de multidifusión.(de uno a muchos)
	3. **Anycast**: Es un método de comunicación en redes donde un origen envía datos a la "mejor" ubicación disponible entre múltiples destinatarios que comparten la misma dirección de destino. La red determina automáticamente la ruta más eficiente para dirigir el tráfico al destinatario más cercano o disponible, lo que puede ayudar a mejorar la eficiencia y la disponibilidad de los servicios en línea.(difusión por proximidad)
	**Nota**:a diferencia de IPv4 no tiene una dirección broadcast. sin embargo   existe una dirección ipv6 de multicast de todos los nodos que brinda básicamente el mismo resultado.


**Longitud de prefijo IPv6**
  La longitud del prefijo se representa en notación de barra diagonal y se usa para indicar la porción de red de una dirección IPv6.
  La longitud de prefijo ir de 0 a 128. La longitud de prefijo ipv6 recomendada para LAN y la mayoría de los otros tipos de redes es /64.
  Por ejemplo, en la notación CIDR, una dirección IPv6 con un prefijo de longitud 64 se vería así: `2001:0db8:85a3:0000:0000:8a2e:0370:7334/64`.


**Estructura GUA de IPv6**
	Prefijo de enrutamiento global:
	   - El prefijo de enrutamiento global es la parte del prefijo, o red, de la dirección asignada por el proveedor.
	  ID de subred
	   - El campo id de subred es el área entre el prefijó de enrutamiento global.


**Configuración de una dirección Link-Local Unicast estática**
	Configura la LLA manualmente permite crear una dirección  

**Direccionamiento dinámico par GUA IPv6**
	**Mensajes RS y RA**
		Los dispositivos obtienen direcciones GUA dinámicamente a través de mensajes de Internet Control Message Prorocol version 6(ICMPv6)
		Los mensajes de solicitud de router (RS ) son enviados por dispositivos host para descubrir router IPv6.
		Los router envían mensajes de anuncio de router para información a lo host  sobre como obtener un gua Ipv6 y proporcionar util de red
		-EL RA puede proporcionar tres métodos para configurar un Gua  IPv6:
			- SLAAC
			- SLAAC con servidor DHCPv6 stateless
			- Stateful DHPv6(no SLAAC)
	**Proceso EUI-64**
		El IEEE define el identificador unico extendido o el proceso eui-64 modificando que realiza lo siguiente:
			- Un valor de 16 bits de fffe se inserta en el centro de la dirección MaAC Ethernet de 48 bits del cliente.
			- El 7° bit de la dirección MAC del cliente se invierte del binario 0 al 1.
**3.- Direccionamiento IPv6**
	**División de subredes **
		División en subredes mediante la ID de subred**
		Ipv6  se diseño teniendo en cuneta las subredes.
	**Ejemplo de Subneteo IPv6**
		[[Subneteo Ipv6.png]]
	**Asignación de subred IPv6**
		 La topología de ejemplo requiere cinco subredes una para cada LAN, así como para el enlace en serie entre R1 y R2.
		 Se asigna las cinco subredes
		 