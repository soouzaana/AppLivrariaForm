using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLivrariaForm.Models
{
    public class Livro
    {
        //atributos
        public int Id { get; set; }
        public int IdGenero { get; set; }
        public string Titulo { get; set; }
        public string Classificacao { get; set; }
        public int ISBN { get; set; }
        public int Ano { get; set; }
    }
}
