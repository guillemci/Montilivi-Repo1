const missatge = document.getElementById("missatge");
const color = document.getElementById("color");
const mida = document.getElementById("mida");
const posicio = document.getElementById("posicio");
const fons = document.getElementById("fons");
const boto = document.getElementById("boto");
const fotoPostal = document.getElementById("fotoPostal");
const postaltext = document.getElementById("postaltext");

boto.onclick = function () {
    // text
    postaltext.innerText = missatge.value;
    // color
    postaltext.style.color = color.value;
    // mida
    postaltext.style.fontSize = mida.value + "px";
    // posicio
    postaltext.style.top = posicio.value;
    // fons
    fotoPostal.src = fons.value;
};