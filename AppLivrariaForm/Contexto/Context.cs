using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLivrariaForm.Models;

namespace AppLivrariaForm.Contexto
{
   public class Context
   {   
        public static List<Genero> ListaGeneros = new List<Genero>();
        public static List<Livro> ListaLivros = new List<Livro>();
        public static List<Autor> ListaAutores = new List<Autor>();
   }
}
