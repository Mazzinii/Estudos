
//definindo numero max do array
int numeroQuartos = 10;

// instaciando classe em um vetor 
Estudante[] vect = new Estudante[numeroQuartos];

//pegando a quantidade de quartos a ser alugado 
System.Console.WriteLine("Qauntos quarrtos serão alugados");
int qntd = int.Parse(Console.ReadLine());

//iterando sobre a quantidade de quartos e pegando nome, email e quarto
for (int i = 1; i <= qntd; i++){
    System.Console.WriteLine("Aluguel #" + i);
    System.Console.WriteLine("Nome:");
    string nome = Console.ReadLine();
    System.Console.WriteLine("Email:");
    string email = Console.ReadLine();
    System.Console.WriteLine("Quartos:");
    int quarto = int.Parse(Console.ReadLine());
    
    //adiconando nome, email no quarto escolhido 
    vect[quarto] = new Estudante(nome,email);
}
//iterando o vetor 
for(int i = 0; i < numeroQuartos; i++){
    //verificando os indices que não são nulos 
    if(vect[i] != null){
        //mostrando os quartos ocupados 
        System.Console.WriteLine("Quartos ocupados" + vect[i]);
    }
}


