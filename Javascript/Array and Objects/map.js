// 1.1 Dobrar os números
const numeros = [1, 2, 3, 4, 5];

const doubleNumbers = numeros.map((number) => number * 2);
console.log(doubleNumbers);

// 1.2 Converter para strings
const numbers = [10, 20, 30];

const numToString = numbers.map((number) => number.toString());
console.log(numToString);

// Objetos

// 2.1 Extrair nomes de usuários
const usuarios = [
  { nome: "Ana", idade: 25 },
  { nome: "João", idade: 30 },
  { nome: "Maria", idade: 22 },
];

const nameUsers = usuarios.map((usuario) => usuario.nome);
console.log(nameUsers);

// 2.2 Adicionar propriedade "ativo: true"
const produtos = [
  { nome: "Notebook", preco: 2500 },
  { nome: "Mouse", preco: 50 },
  { nome: "Teclado", preco: 120 },
];

const newProducts = produtos.map((produto) => ({ ...produto, ativo: true }));

console.log(newProducts);

// 3.1 Aplicar 10% de desconto
const precos = [100, 200, 300, 150];

const newPrice = precos.map((preco) => preco * 0.9);

console.log(newPrice);

// 3.2 Converter Celsius para Fahrenheit
const temperaturasC = [0, 20, 30, 40];

const temperatureF = temperaturasC.map((temperatura) => temperatura * 1.8 + 32);

console.log(temperatureF);

// 4.1 Primeira letra de cada nome
const nomes = ["ana", "joão", "maria", "carlos"];

const firstLetter = nomes.map((nome) => nome[0]);

console.log(firstLetter);

// 4.2 Criar elementos HTML
const itens = ["Maçã", "Banana", "Laranja"];

const html = itens.map((item) => `<p>${item}<p>`);

console.log(html);

// Terminar daqui para baixo
// 5.1 Transformação condicional (dobrar pares, triplicar ímpares)
const numerosMix = [1, 2, 3, 4, 5, 6];

const operation = numerosMix.map((numero) =>
  numero % 2 ? numero * 2 : numero * 3
);

console.log(operation);

// 5.2 Usando índice do array
const frutas = ["maçã", "banana", "laranja", "uva"];

// 5.3 Trabalhando com arrays aninhados
const pessoas = [
  { nome: "Ana", habilidades: ["JS", "CSS", "HTML"] },
  { nome: "João", habilidades: ["Python", "SQL", "Java"] },
];
