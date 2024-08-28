// repetir o pedido de senha enquanto a senha for errada

var senha = prompt("Senha: ");

while (senha != 2002) {
  window.alert("Senha invalida");
  senha = prompt("Senha: ");
}
window.alert("Acesso Permitido");
