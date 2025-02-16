using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLivrariaForm.Models
{
    public class Autor
    {
        public int IdAutor { get; set; }
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public string GenerosAutor { get; set; }
        public DateTime Nascimento { get; set; }
    }
}
