using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CepApi.Models
{
    internal class CepModel
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string? Complemento { get; set; }
        public string? Unidade { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }

        public CepModel()
        {
        }

        public CepModel(string cep, string logradouro, string? complemento, string? unidade, string bairro, string localidade)
        {
            Cep = cep;
            Logradouro = logradouro;
            Complemento = complemento;
            Unidade = unidade;
            Bairro = bairro;
            Localidade = localidade;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine($"Cep: {Cep}");
            sb.AppendLine($"Logradouro: {Logradouro}");
            sb.AppendLine($"Complemento: {Complemento}");
            sb.AppendLine($"Unidade: {Unidade}");
            sb.AppendLine($"Bairro: {Bairro}");
            sb.AppendLine($"Localidade: {Localidade}");
            return sb.ToString();


        }


    }
}
