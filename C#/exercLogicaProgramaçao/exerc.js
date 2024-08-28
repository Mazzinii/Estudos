//Exerc 1.1
function calcProduto(cod, qnt, preço, cod2, qnt2, preço2) {
  let total1 = qnt * preço;
  let total2 = qnt2 * preço2;
  let totalProduto = total1 + total2;
  return console.log("VALOR A PAGAR: R$" + totalProduto.toFixed(2));
}
calcProduto(13, 2, 15.3, 161, 4, 5.2);

//Exerc 1.2

function area(raio) {
  let area = 3.14159 * raio ** 2;
  return console.log("A: " + area.toFixed(4));
}
area(150.0);

//Exerc 2.1

function preços(cod, qnt) {
  let total = 0;

  if (cod == 1) {
    total = qnt * 4.0;
  } else if (cod == 2) {
    total = qnt * 4.5;
  } else if (cod == 3) {
    total = qnt * 5;
  } else if (cod == 4) {
    total = qnt * 2.0;
  } else if (cod == 5) {
    total = qnt * 1.5;
  }
  return console.log("Total: R$ " + total.toFixed(2));
}

preços(2, 3);

//Exerc 2.2

function bascara(a, b, c) {
  if (a == 0) {
    return console.log("Impossível calcular");
  } else {
    let delta = b ** 2 - 4 * a * c;
    if (delta < 0) {
      return console.log("Impossível calcular");
    } else {
      let raiz = Math.sqrt(delta);
      let x1 = (-b + raiz) / (2 * a);
      let x2 = (-b - raiz) / (2 * a);
      return console.log(`X1: ${x1.toFixed(5)} X2: ${x2.toFixed(5)}`);
    }
  }
}

bascara(10.0, 3.0, 5.0);
