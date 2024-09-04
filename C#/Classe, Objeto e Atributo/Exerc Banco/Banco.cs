using System.Globalization;

class Banco{
    
    public double Saldo { get;private set;}
    public int Conta { get; private set; }
    public string Nome { get; set; }
    
    
    public Banco( int conta, string nome){
        Conta = conta;
        Nome = nome;
    } 

    public Banco( int conta, string nome, double depositoInicial): this(conta, nome){
        Deposito(depositoInicial);
    }

    public void Deposito(double valor){
        Saldo += valor; 
    }

    public void Saque(double valor){
        Saldo -= valor + 5 ;
    }

    public override string ToString(){
        return "Conta " + Conta + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }


}