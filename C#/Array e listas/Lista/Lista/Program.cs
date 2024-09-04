
using System.Globalization;

//instanciando uma lista com a classe empregado
List<Empregado> listaEmpregados = new List<Empregado>(); 

//obtendo dado de quantos empregados são
System.Console.WriteLine("How many employees will be registered");
int funcionarios = int.Parse(Console.ReadLine());

//iterando sobre o numero de empregados para adicionar os campos necessários
for (int i = 1 ; i <= funcionarios; i++){
    Console.WriteLine("#" + i);
    System.Console.WriteLine("Id:");
    int id = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Name");
    string nome = Console.ReadLine();
    System.Console.WriteLine("Salary");
    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
    listaEmpregados.Add(new Empregado(id, nome,  salario));
}

//obtendo o id que vai ser aplicado o aumento 
System.Console.WriteLine("Enter the employee id that will have salary increase: ");
int aumento = int.Parse(Console.ReadLine());

//verificando se o id esta na lista 
int filtro = listaEmpregados.FindIndex(x => x.Id == aumento);

//caso o id esteja na lista, fazer o aumento 
if (filtro >= 0){
    System.Console.WriteLine("Enter the percentage");
    double porcentagem = double.Parse(Console.ReadLine());
    listaEmpregados[filtro].Aumento(porcentagem);
}else{
    //caso nao informar mensagem  
    System.Console.WriteLine("This id not exist");
}

// mostrando os dados dos empregados
System.Console.WriteLine("Update list of employees:");

//percorrendo a lista para exibir todos os dados dos empregados que foram adicionados 
foreach (Empregado item in listaEmpregados)
{
    System.Console.WriteLine(item);
}
