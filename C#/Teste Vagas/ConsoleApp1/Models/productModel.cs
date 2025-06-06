using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class productModel
    {
        public string produto_id { get; set; }
        public dimensionModel dimensoes { get; set; }


        public int volume()
        {
            return dimensoes.altura * dimensoes.largura * dimensoes.comprimento;
        }

    }
}
