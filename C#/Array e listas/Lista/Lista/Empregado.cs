class Empregado {
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Salario { get; private set; }

    public Empregado(int id, string nome,  double salario){ 
        Id = id;
        Salario = salario;
        Nome = nome;
    }

    public void Aumento(double porcentagem){
        Salario = Salario + (Salario * (porcentagem / 100)); 
    }

    public override string ToString() {
        return Id + ", " + Nome + ", " + Salario;
    }

}