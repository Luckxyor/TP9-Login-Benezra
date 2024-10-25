function ContraseñaBien() {
    const contra = document.getElementById('Contraseña');
    const caracteresEspeciales = [ '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '{', '}', '[', ']', '|', ':', ';', '"', '<', '>', ',', '.', '?', '/', '`', '~'];
    const longitud=contra.value.length>=8;
    const mayuscula=contra.value!==(contra.value.toLowerCase());
    const contieneEspecial = contieneLetraEspecial(contra.value, caracteresEspeciales);
    
    const largo = document.getElementById('largo');
    const mayus = document.getElementById('mayus');
    const especial = document.getElementById('especial');

    if(longitud){
        largo.textContent='✔ Más de 8 caracteres'
        largo.style.color='green';
    }
    else{
        largo.textContent='✖ Más de 8 caracteres'
        largo.style.color='red';
    }
    if(mayuscula){
        mayus.textContent='✔ Mínimo 1 letra mayúscula'
        mayus.style.color='green';
    }
    else{
        mayus.textContent='✖ Mínimo 1 letra mayúscula'
        mayus.style.color='red';
    }
    if(contieneEspecial){
        especial.textContent='✔ Mínimo 1 caracter especial'
        especial.style.color='green';
    }
    else{
        especial.textContent='✖ Mínimo 1 caracter especial'
        especial.style.color='red';
    }
}

function contieneLetraEspecial(contraseña, caracteresEspeciales){
    for (let caracter of caracteresEspeciales){
        if (contraseña.includes(caracter)){
            return true;
        }
    }
    return false;
}