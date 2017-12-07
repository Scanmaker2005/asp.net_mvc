using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleEstoque.Web.Models
{
    public class Pessoa
    {
        [Key]
        public int codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}