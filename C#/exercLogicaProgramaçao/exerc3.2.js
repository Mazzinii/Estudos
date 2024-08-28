//Exerc 3.2

// definindo var n = quantidade de numeros a serem lidos
var n = Number.parseInt(prompt("N:"));

//declarando demais var
var numeros = [];
var dentro = 0;
var fora = 0;

//adicionando numeros na lista
n = n - 1;
while (n >= 0) {
  let numero = Number.parseInt(prompt("Numero:"));
  numeros.push(numero);
  n--;
}

//percorer numeros
for (let i = 0; i < numeros.length; i++) {
  //iterar em um var a quantidade de vezes q o numero esta dentro dentro e fora do intervalor 10,20
  if (numeros[i] >= 10 && numeros[i] <= 20) {
    dentro += 1;
  } else {
    fora += 1;
  }
}
console.log(`${dentro} in ${fora} out`);
