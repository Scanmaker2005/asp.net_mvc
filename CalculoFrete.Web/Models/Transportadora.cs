using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Security;
using CalculoFrete.Web.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalculoFrete.Web.Models
{
    public class Transportadora
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Nome")]
        [StringLength(100, ErrorMessage = "O email não pode ultrapassar o limite de 100 caracteres")]
        public string nome { get; set; }
    }
}