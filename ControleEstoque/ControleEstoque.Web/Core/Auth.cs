using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using ControleEstoque.Web.Models;

namespace ControleEstoque.Web.Core
{
    public class Auth
    {
        private Contexto db = new Contexto();
        public static object User { get; set; } = null;

        

    }
}