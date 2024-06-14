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