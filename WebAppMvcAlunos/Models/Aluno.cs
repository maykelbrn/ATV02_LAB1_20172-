using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppMvcAlunos.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Email obrigatório")]
        public string Email { get; set; }
    }
}