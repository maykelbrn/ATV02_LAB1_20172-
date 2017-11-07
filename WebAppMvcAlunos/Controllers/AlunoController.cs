using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMvcAlunos.Controllers
{
    public class AlunoController : Controller
    {

        AlunoContext db = new AlunoContext();


        public ActionResult Index()
        {
            var alunos = db.Alunos.ToList();
            return View(alunos);
        }

        public ActionResult Sobre(int? id)
        {

            var aluno = db.Alunos.Find(id);
            return View(aluno);
        }

    }
}