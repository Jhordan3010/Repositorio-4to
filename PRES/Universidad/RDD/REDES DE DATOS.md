[[VLSM-IPv6]]

**4- Switching y Routing**
	**Métodos de acceso**
		- Secure shel (ssh)
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