function ContraseñaBien() {
    const contra = document.getElementById('Contraseña');
    const caracteresEspeciales = [ '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '{', '}', '[', ']', '|', ':', ';', '"', '<', '>', ',', '.', '?', '/', '`', '~'];
    const longitud=contra.value.length>=8;
    const especial=contra.value!==(contra.value.toLowerCase());
    const contieneEspecial = contieneLetraEspecial(contra.value, caracteresEspeciales);
    const texto = document.getElementById('textoMostrado');
    texto.textContent = contra.value;

    if(longitud && especial && contieneEspecial){
        texto.style.color="green";
    }
    else{
        texto.style.color="red";
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

const signUpButton = document.getElementById('signUp');
const signInButton = document.getElementById('signIn');
const container = document.getElementById('container');

signUpButton.addEventListener('click', () =>
    container.classList.add('right-panel-active')
);

signInButton.addEventListener('click', () =>
    container.classList.remove('right-panel-active')
);