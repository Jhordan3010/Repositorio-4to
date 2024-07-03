[[VLSM-IPv6]]

**4- Switching y Routing**
	**Métodos de acceso**
		Secure shel (ssh)
		-  Telnet
	**VLAN'S**
		**Definición de VLAN**
			Son redes virtuales creadas por software.
			Las VLAN son conexiones lógicas con otros dispositivos similares. La colocación de dispositivos en varios VLAN tiene las siguientes características: 
				- Proporciona segmentación de los diversos grupos de dispositivos en los mismos conmutadores
				- Proporcionar una organización mas manejable.
					- Difusiones, multidifusión y unidifusión se aíslan en la VLAN individual
					- Cada VLAN tendrá su propia gama única de direcciones IP
					- Dominios de difusión mas pequeños.
		**Beneficios de un diseño de VLAN**
			[[Beneficios de un diseño de VLAN.png]]
		**Tipos de VLAN(Cont.)**
			**VLAN DE DATOS**
				- Dedicado al trafico generado por el usuario(correo electrónico y trafico web)
			**VLAN NATIVA**
			**VLAN  DE VOZ**
				- Se requiere una VLAN separada por el trafico de voz requiere:
					- Ancho de banda asegurado
					- Alta prioridad de QoS
					- Capacidad para evitar la congestión
					- Retraso menos de 150 ms desde el origen hasta el destino
				- Toda la red debe estar diseñada para admitir voz
	**Configuración de VLANS**
		-Comandos de creación de VLAN


**Troncales VLAN**
Comandos de configuración de VLAN

| Tare                                                     | comando de IOS                          |
| -------------------------------------------------------- | --------------------------------------- |
| configuración global                                     | switch# configure terminal              |
| Ingrese al modo de configuración de interface            | interface interface-id                  |
| Habilitar el modo Trunk en un puerto                     | switchport mode trunk                   |
| Configurar la VLAN nativa en un puerto Trunk (opcional)  | switchport trunk native vlan vlan-id    |
| Permitir tráfico de VLANs específicas en un puerto Trunk | switchport trunk allowed vlan vlan-list |
| vuelvo al modo exec                                      | end                                     |
**Protocolo de enlace dinámico**
El protocolo de enlace troncal dinámico (DTP) es un protocolo propietario de Cisco
Las características de DTP son:
- Activado de forma predeterminada en switches Catalyst 2960 y 2950
- Dynamic-Auto es el valor predeterminado en los conmutadores 2960 y 2950

Dynamic auto: se convierte en una interfaz troncal si la interfaz vecina se configura en modo troncal o deseable
desirable: siempre es trocal por lo general 

**Switching y Routing**(Funcionamiento de Inter-VLAN Routing)
Se utiliz para segmentar las redes conmutadas de Capa 2 por diversas razones.
Inter-VLA routing es el proceso de reenviar el trafico de red de una VLAN a otra VLAN.
Hay tres opciones inter-VLAN routing:
- Enrutamiento entre vlan hereedada- esta es una solucion heredada
- Router-on-a stick
- Conmutador de nivel 3 con interfaces virtuales

### Modelo OSI Completo:

1. **Capa 1: Capa Física (Physical Layer)**
    - Define los medios físicos de transmisión de datos.
    - Ejemplos: cables, señales eléctricas, interfaces físicas.
2. **Capa 2: Capa de Enlace de Datos (Data Link Layer)**
    - Proporciona la transferencia de datos entre dispositivos en la misma red local.
    - Ejemplos: Ethernet, MAC addresses, switches de capa 2.
3. **Capa 3: Capa de Red (Network Layer)**
    - Se encarga del encaminamiento de los paquetes de datos entre redes diferentes.
    - Ejemplos de Protocolos: IP (Internet Protocol), ICMP (Internet Control Message Protocol), ARP (Address Resolution Protocol), OSPF (Open Shortest Path First).
4. **Capa 4: Capa de Transporte (Transport Layer)**
    - Proporciona una transferencia de datos fiable y controlada entre dispositivos.
    - Ejemplos: TCP (Transmission Control Protocol), UDP (User Datagram Protocol).
5. **Capa 5: Capa de Sesión (Session Layer)**
    - Gestiona las sesiones de comunicación entre aplicaciones.
    - Ejemplos: RPC (Remote Procedure Call), PPTP (Point-to-Point Tunneling Protocol).
6. **Capa 6: Capa de Presentación (Presentation Layer)**
    - Traduce, cifra y comprime los datos para la capa de aplicación.
    - Ejemplos: SSL/TLS (Secure Sockets Layer/Transport Layer Security), JPEG, ASCII.
7. **Capa 7: Capa de Aplicación (Application Layer)**
    - Proporciona servicios de red a las aplicaciones del usuario final.
    - Ejemplos: HTTP, FTP, SMTP, DNS.