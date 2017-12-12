using CalculoFrete.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using CalculoFrete.Web.Core;

namespace CalculoFrete.Web.Controllers
{
    public class UsuarioController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            if (Request.IsAuthenticated)
                return this.LogOff();

            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Usuario login, string returnUrl)
        {
            if (!ModelState.IsValid)
                return View(login);

            if(Usuario.login(login.email, login.senha, login.LembrarMe))
            {
                if (Url.IsLocalUrl(returnUrl))
                    return Redirect(returnUrl);
                else
                   return RedirectToAction("Index", "Home");
            }
            else
                ModelState.AddModelError("", "Login inválido.");

            return View(login);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            Usuario.logout();
            return RedirectToAction("Index", "Home");
        }
    }
}