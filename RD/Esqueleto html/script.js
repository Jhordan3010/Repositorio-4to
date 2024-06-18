function generarEntradasSubredes() {
    const numeroSubredes = document.getElementById('numeroSubredes').value;
    const contenedorEntradasSubredes = document.getElementById('contenedorEntradasSubredes');
    
    // Limpiar entradas anteriores
    contenedorEntradasSubredes.innerHTML = '';
    
    for (let i = 0; i < numeroSubredes; i++) {
        const formGroup = document.createElement('div');
        formGroup.className = 'form-group';
        
        // Entrada para el nombre de la subred
        const labelNombre = document.createElement('label');
        labelNombre.textContent = `Nombre de la Subred ${i + 1}:`;
        
        const inputNombre = document.createElement('input');
        inputNombre.type = 'text';
        inputNombre.id = `nombreSubred${i + 1}`;
        inputNombre.placeholder = `Ingrese el nombre de la subred ${i + 1}`;
        inputNombre.required = true;
        
        // Entrada para el número de hosts
        const labelHosts = document.createElement('label');
        labelHosts.textContent = `Número de Hosts para Subred ${i + 1}:`;
        
        const inputHosts = document.createElement('input');
        inputHosts.type = 'number';
        inputHosts.id = `hostsSubred${i + 1}`;
        inputHosts.placeholder = `Ingrese el número de hosts para la subred ${i + 1}`;
        inputHosts.required = true;
        
        // Añadir las entradas al formulario
        formGroup.appendChild(labelNombre);
        formGroup.appendChild(inputNombre);
        formGroup.appendChild(labelHosts);
        formGroup.appendChild(inputHosts);
        contenedorEntradasSubredes.appendChild(formGroup);
    }
}

function calcularSubredes() {
    const direccionRed = document.getElementById('direccionRed').value;
    const prefijoSubred = parseInt(document.getElementById('prefijoSubred').value);
    const numeroSubredes = parseInt(document.getElementById('numeroSubredes').value);
    const contenedorEntradasSubredes = document.getElementById('contenedorEntradasSubredes');
    
    let subredesInfo = [];
    for (let i = 0; i < numeroSubredes; i++) {
        const inputNombre = document.getElementById(`nombreSubred${i + 1}`);
        const inputHosts = document.getElementById(`hostsSubred${i + 1}`);
        subredesInfo.push({
            nombre: inputNombre.value,
            hosts: parseInt(inputHosts.value, 10)
        });
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
    subredesInfo.sort((a, b) => b.hosts - a.hosts);

    let subredes = [];
    let redActualEntero = redEntero;

    for (let subredInfo of subredesInfo) {
        const tamañoRequerido = Math.pow(2, Math.ceil(Math.log2(subredInfo.hosts + 2))); // Número de direcciones incluyendo red y broadcast
        const mascaraSubred = 32 - Math.ceil(Math.log2(tamañoRequerido));
        const subred = {
            nombre: subredInfo.nombre,
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
                <h3>${subred.nombre} (Subred ${index + 1})</h3>
                <p><strong>Dirección de Subred:</strong> ${subred.red}/${subred.prefijo}</p>
                <p><strong>Rango de Hosts:</strong> ${subred.primerHost} - ${subred.ultimoHost}</p>
                <p><strong>Dirección de Broadcast:</strong> ${subred.broadcast}</p>
            </div>
        `;
    });

    document.getElementById('resultado').innerHTML = resultadoHtml;
}
