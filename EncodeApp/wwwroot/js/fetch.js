const select = document.querySelector('#select');
select.addEventListener('change', cargarPaises);

function cargarPaises(){
    fetch('Paises.json')
        .then(paises => paises.json())
        .then(paises => paises.forEach(pais => {
                const opcion = document.createElement('option');
                opcion.innerHTML = `<option value="${pais.Code}"> ${pais.Name} </option>`;
                select.appendChild(opcion);
            })
        )
}
cargarPaises();