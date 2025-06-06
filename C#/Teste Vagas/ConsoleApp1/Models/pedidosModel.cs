using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class pedidosModel
    {
        public int PedidoId { get; set; }
        public List<productModel> Produtos { get; set; }


        public static pedidosModel Desserializar(string json)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            return JsonSerializer.Deserialize<pedidosModel>(json, options);
        }


        public int volumeTotal()
        {
            int total = 0;

            foreach (var produto in Produtos)
            {
                total += produto.volume();
            }

            return total;
        }
    }
}
