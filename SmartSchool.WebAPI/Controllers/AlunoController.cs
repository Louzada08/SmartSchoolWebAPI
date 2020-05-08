using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno(){
                Id = 1,
                Nome = "Anderson",
                Sobrenome = "Louzada",
                Telefone = "984309740"
            },
           new Aluno(){
                Id = 2,
                Nome = "Vilma",
                Sobrenome = "Louzada",
                Telefone = "987209745"
            },           
            new Aluno(){
                Id = 3,
                Nome = "Aline",
                Sobrenome = "Louzada",
                Telefone = "98205582"
            },           
            new Aluno(){
                Id = 4,
                Nome = "Amanda",
                Sobrenome = "Louzada",
                Telefone = "984722727"
            },           
            new Aluno(){
                Id = 5,
                Nome = "Alana",
                Sobrenome = "Louzada",
                Telefone = "984301020"
            },
        };
        public AlunoController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        //api/aluno/id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if(aluno == null) return BadRequest("Aluno não encontrado!");
            return Ok(aluno);
        }

        //api/aluno/nome
        [HttpGet("byname")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && 
                a.Sobrenome.Contains(sobrenome));
            if(aluno == null) return BadRequest("Aluno não encontrado!");
            return Ok(aluno);
        }

        //api/aluno
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        //api/aluno/id
        [HttpPut("{id}")]
        public IActionResult Post(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        //api/aluno/id
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        //api/aluno/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Aluno {id}, excluído com exito.");
        }             
    }
}