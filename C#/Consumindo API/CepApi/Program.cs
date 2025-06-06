using CepApi.Services;


CepService service = new CepService();

Console.WriteLine("Digite o seu Cep");
string cep = Console.ReadLine();

cep += "/json";

await service.TaskAsync(cep);
