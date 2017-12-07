using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace ControleEstoque.Web.Models
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
        [StringLength(20, ErrorMessage = "A senha não pode ultrapassar o limite de 20 caracteres")]
        public string senha { get; set; }
        
        [Display(Name = "Senha:")]
        [StringLength(150)]
        public string nome { get; set; }


        public static bool login(string email, String senha, bool lembrar)
        {
            Contexto db = new Contexto();
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