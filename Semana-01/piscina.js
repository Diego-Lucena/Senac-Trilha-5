const raio = 3.5; 
const altura = 1.6; 

let areaBase = Math.PI * Math.pow(raio, 2);
let cubico = areaBase * altura;
let litros = cubico * 1000; 

console.log("O volume da piscina é: " + litros + " litros");