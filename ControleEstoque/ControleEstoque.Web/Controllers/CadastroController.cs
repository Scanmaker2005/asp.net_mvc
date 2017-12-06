using ControleEstoque.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class CadastroController : Controller
    {
        private static List<GrupoProdutoModel> _ListaGrupoProduto = new List<GrupoProdutoModel>()
        {
            new GrupoProdutoModel() { Id = 1, Nome = "Livros", Ativo = true },
            new GrupoProdutoModel() { Id = 2, Nome = "Mouses", Ativo = true },
            new GrupoProdutoModel() { Id = 3, Nome = "Monitores", Ativo = false }
        };

        [Authorize]
        public ActionResult GrupoProduto()
        {
            return View(_ListaGrupoProduto);
        }

        [HttpPost]
        [Authorize]
        public ActionResult RecuperarGrupoProduto(int id)
        {
            return Json(_ListaGrupoProduto.Find(x => x.Id == id));
        }

        [HttpPost]
        [Authorize]
        public ActionResult ExcluirGrupoProduto(int id)
        {
            var ret = false;

            var registroBD = _ListaGrupoProduto.Find(x => x.Id == id);
            if (registroBD != null)
            {
                _ListaGrupoProduto.Remove(registroBD);
                ret = true;
            }

            return Json(ret);
        }

        [HttpPost]
        [Authorize]
        public ActionResult SalvarGrupoProduto(GrupoProdutoModel model)
        {
            var registroBD = _ListaGrupoProduto.Find(x => x.Id == model.Id);

            if (registroBD == null)
            {
                registroBD = model;
                registroBD.Id = _ListaGrupoProduto.Max(x => x.Id) + 1;
                _ListaGrupoProduto.Add(registroBD);
            }
            else
            {
                registroBD.Nome = model.Nome;
                registroBD.Ativo = model.Ativo;
            }

            return Json(registroBD);
        }

        [Authorize]
        public ActionResult MarcaProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult LocalProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult UnidadeMedida()
        {
            return View();
        }

        [Authorize]
        public ActionResult Produto()
        {
            return View();
        }

        [Authorize]
        public ActionResult Pais()
        {
            return View();
        }

        [Authorize]
        public ActionResult Estado()
        {
            return View();
        }

        [Authorize]
        public ActionResult Cidade()
        {
            return View();
        }

        [Authorize]
        public ActionResult Fornecedor()
        {
            return View();
        }

        [Authorize]
        public ActionResult PerfilUsuario()
        {
            return View();
        }

        [Authorize]
        public ActionResult Usuario()
        {
            return View();
        }
    }
}