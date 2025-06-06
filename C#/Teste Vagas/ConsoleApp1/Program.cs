using System.Text.Json;
using ConsoleApp1.Models;

Console.WriteLine("digite o texto json");
var json = """
    {
      "pedido_id": 1,
      "produtos": [
        {"produto_id": "PS5", "dimensoes": {"altura": 40, "largura": 10, "comprimento": 25}},
        {"produto_id": "Volante", "dimensoes": {"altura": 40, "largura": 30, "comprimento": 30}}
      ]
    }
    """;




var products = pedidosModel.Desserializar(json);

Console.WriteLine(products.volumeTotal());




