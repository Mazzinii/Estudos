using System.Globalization;

class Banco{
    private double _saldoInicial;
    public int Conta { get; private set; }
    public string Nome { get; private set; }
    
 
    public Banco(double saldo, int conta, string nome){
        _saldoInicial = saldo;
        Conta = conta;
        Nome = nome;
    } 

    public void Deposito(double valor){
        _saldoInicial += valor; 
    }

    public void Saque(double valor){
        _saldoInicial = _saldoInicial - 5 - valor ;
    }

    public override string ToString(){
        return "Conta " + Conta + ", Titular: " + Nome + ", Saldo: $ " + _saldoInicial.ToString("F2", CultureInfo.InvariantCulture);
    }

}