const passwordField = document.getElementById('Password');
const errorRequisitos = document.getElementById('errorRequisitos');
const caracteresEspeciales = ['!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '{', '}', '[', ']', '|', ':', ';', '"', '<', '>', ',', '.', '?', '/', '`', '~'];

function ContraseñaBien() {
    const largo = document.getElementById('largo');
    const mayus = document.getElementById('mayus');
    const especial = document.getElementById('especial');


    const longitud = passwordField.value.length >= 8;
    const mayuscula = passwordField.value !== passwordField.value.toLowerCase();
    const contieneEspecial = contieneLetraEspecial(passwordField.value, caracteresEspeciales);


    if (longitud) {
        largo.textContent = '✔ Más de 8 caracteres';
        largo.style.color = 'green';
    } else {
        largo.textContent = '✖ Más de 8 caracteres';
        largo.style.color = 'red';
    }
    if (mayuscula) {
        mayus.textContent = '✔ Mínimo 1 letra mayúscula';
        mayus.style.color = 'green';
    } else {
        mayus.textContent = '✖ Mínimo 1 letra mayúscula';
        mayus.style.color = 'red';
    }
    if (contieneEspecial) {
        especial.textContent = '✔ Mínimo 1 caracter especial';
        especial.style.color = 'green';
    } else {
        especial.textContent = '✖ Mínimo 1 caracter especial';
        especial.style.color = 'red';
    }


    errorRequisitos.style.display = 'none';
}

function contieneLetraEspecial(contraseña, caracteresEspeciales) {
    for (let caracter of caracteresEspeciales) {
        if (contraseña.includes(caracter)) {
            return true;
        }
    }
    return false;
}

function validarFormulario() {
    const longitud = passwordField.value.length >= 8;
    const mayuscula = passwordField.value !== passwordField.value.toLowerCase();
    const contieneEspecial = contieneLetraEspecial(passwordField.value, caracteresEspeciales);


    if (!(longitud && mayuscula && contieneEspecial)) {
        errorRequisitos.style.display = 'block';
        return false;
    }

    return true;
}