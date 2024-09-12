
System.Console.WriteLine("Informe o numero de linhas:");
int linhas = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o numero de colunas:");
int colunas = int.Parse(Console.ReadLine());

int[,] matriz = new int[linhas,colunas];

for(int i = 0; i < linhas;i++ ){
    string[] vet = Console.ReadLine().Split(' ');
    for(int j = 0; j < colunas; j++){
        matriz[i,j] = int.Parse(vet[j]);
    }

}

System.Console.WriteLine("Insira o numero que deseja saber a posição ");
int pesquisa = int.Parse(Console.ReadLine());

int esquerda = 0;
int direita = 0;
int acima = 0;
int abaixo = 0 ;

for(int i = 0; i < linhas; i++){

    for(int j = 0; j < colunas; j++){

        if (matriz[i,j] == pesquisa ){
            
            System.Console.WriteLine($"Position:{i},{j}");

            if( j > 0){
               esquerda = matriz[i,j - 1];
               System.Console.WriteLine("Esquerda:" + esquerda); 
            }if( j < (colunas - 1) ){
                direita = matriz[i,j + 1];
                System.Console.WriteLine("Direita:" + direita);
            }
            if( i > 0 ){
                acima = matriz[i -1,j];
                System.Console.WriteLine("Acima:" + acima);
            }
            if( i < (linhas - 1)){
                abaixo =matriz[i + 1,j];
                System.Console.WriteLine("Abaixo:" + abaixo);
            }         
        }      
    }
}
    

