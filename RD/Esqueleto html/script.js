function generarEntradasHosts() {
    const numeroSubredes = document.getElementById('numeroSubredes').value;
    const contenedorEntradasHosts = document.getElementById('contenedorEntradasHosts');
    
    // Limpiar entradas anteriores
    contenedorEntradasHosts.innerHTML = '';
    
    for (let i = 0; i < numeroSubredes; i++) {
        const formGroup = document.createElement('div');
        formGroup.className = 'form-group';
        
        const etiqueta = document.createElement('label');
        etiqueta.textContent = `Número de Hosts para Subred ${i + 1}:`;
        
        const entrada = document.createElement('input');
        entrada.type = 'number';
        entrada.name = `hosts${i + 1}`;
        entrada.placeholder = `Ingrese el número de hosts para la subred ${i + 1}`;
        entrada.required = true;
        
        formGroup.appendChild(etiqueta);
        formGroup.appendChild(entrada);
        contenedorEntradasHosts.appendChild(formGroup);
    }
}

function calcularSubredes() {
    const direccionRed = document.getElementById('direccionRed').value;
    const prefijoSubred = parseInt(document.getElementById('prefijoSubred').value);
    const numeroSubredes = parseInt(document.getElementById('numeroSubredes').value);
    const contenedorEntradasHosts = document.getElementById('contenedorEntradasHosts');
    
    let requisitosHosts = [];
    for (let i = 0; i < numeroSubredes; i++) {
        const entradaHost = contenedorEntradasHosts.querySelector(`input[name="hosts${i + 1}"]`);
        requisitosHosts.push(parseInt(entradaHost.value, 10));
    }

    // Convertir la dirección de red a un número entero
    const ipAEntero = (ip) => {
        return ip.split('.').reduce((ipInt, octeto) => (ipInt << 8) + parseInt(octeto, 10), 0) >>> 0;
    };

    // Convertir un número entero a una dirección IP
    const enteroAIp = (ipInt) => {
        return ((ipInt >>> 24) + '.' + (ipInt >> 16 & 255) + '.' + (ipInt >> 8 & 255) + '.' + (ipInt & 255));
    };

    // Obtener la dirección de red y máscara
    const [ipRed, prefijo] = direccionRed.split('/');
    const redEntero = ipAEntero(ipRed);
    const mascara = -1 << (32 - prefijoSubred);

    // Ordenar las subredes por tamaño (descendente)
    requisitosHosts.sort((a, b) => b - a);

    let subredes = [];
    let redActualEntero = redEntero;

    for (let hosts of requisitosHosts) {
        const tamañoRequerido = Math.pow(2, Math.ceil(Math.log2(hosts + 2))); // Número de direcciones incluyendo red y broadcast
        const mascaraSubred = 32 - Math.ceil(Math.log2(tamañoRequerido));
        const subred = {
            red: enteroAIp(redActualEntero),
            prefijo: mascaraSubred,
            primerHost: enteroAIp(redActualEntero + 1),
            ultimoHost: enteroAIp(redActualEntero + tamañoRequerido - 2),
            broadcast: enteroAIp(redActualEntero + tamañoRequerido - 1)
        };
        subredes.push(subred);
        redActualEntero += tamañoRequerido;
    }

    // Mostrar los resultados
    let resultadoHtml = '';
    subredes.forEach((subred, index) => {
        resultadoHtml += `
            <div class="subnet">
                <h3>Subred ${index + 1}</h3>
                <p><strong>Dirección de Subred:</strong> ${subred.red}/${subred.prefijo}</p>
                <p><strong>Rango de Hosts:</strong> ${subred.primerHost} - ${subred.ultimoHost}</p>
                <p><strong>Dirección de Broadcast:</strong> ${subred.broadcast}</p>
                <p><strong>Última IP Asignable:</strong> ${subred.ultimoHost}</p>
            </div>
        `;
    });

    document.getElementById('resultado').innerHTML = resultadoHtml;
}
