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
    public class Usuario
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Informe o email")]
        [Display(Name = "Email:")]
        [EmailAddress]
        [StringLength(300, ErrorMessage = "O email não pode ultrapassar o limite de 300 caracteres")]
        public string email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha:")]
        [StringLength(100, ErrorMessage = "A senha não pode ultrapassar o limite de 100 caracteres")]
        public string senha { get; set; }
        
        [Display(Name = "Senha:")]
        [StringLength(150)]
        public string nome { get; set; }

        [NotMapped]
        [Display(Name = "Lembrar-Me:")]
        public bool LembrarMe { get; set; }

        public static bool login(string email, String senha, bool lembrar)
        {
            senha = Crypt.MD5(senha);

            Context db = new Context();
            if (db.Usuarios.Where(m => m.email == email).Where(m => m.senha == senha).ToList().Count() > 0)
            {
                FormsAuthentication.SetAuthCookie(email, lembrar);
                return true;
            }
            return false;
        }

        public static void logout()
        {
            FormsAuthentication.SignOut();
        }

    }
}