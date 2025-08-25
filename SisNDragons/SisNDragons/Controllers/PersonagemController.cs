using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SisNDragons.Models;
using SisNDragons.Services;

namespace SisNDragons.Controllers
{
    [Route("api/personagem")]
    [ApiController]
    public class PersonagemController : ControllerBase
    {
        #region Constructor

        public PersonagemController(PersonagemServices services)
        {
            _services = services;
        }

        #endregion Constructor

        #region Private Properties

        private PersonagemServices _services;

        #endregion Private Properties

        #region Endpoints

        [HttpGet]
        public IEnumerable<PersonagemRecord> Get()
        {
            return _services.GetList();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var record = _services.Get(id);

                return Ok(record);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }


        [HttpGet("personagens")]
        public IActionResult Get(string? nome, int? raca, int? nivel, string? classe, int? alinhamento, bool? is_dead)
        {
            try
            {
                var records = _services.GetFilter(nome, raca, nivel, classe, alinhamento, is_dead);

                return Ok(records);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("getVida/{id}")]
        public IActionResult GetVida(int id)
        {
            try
            {
                int vida = _services.GetVida(id);

                return Ok(vida);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }


        [HttpPost]
        public IActionResult Create([FromBody] PersonagemRecord record)
        {
            try
            {
                _services.Create(record);

                return Created();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }


        [HttpPut]
        public IActionResult Update([FromBody] PersonagemRecord record)
        {
            try
            {
                _services.Update(record);

                return Ok("Registro alterado com sucesso.");
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPatch("patchVida/{id}")]
        public IActionResult patchVida(int id, int vida, int vidaExtra)
        {
            try
            {
                _services.PatchVida(id, vida, vidaExtra);

                return Ok("Registro alterado com sucesso.");
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPatch("patchClasse/{id}")]
        public IActionResult PatchClasse(int id, [FromBody] PatchClasseRecord record)
        {
            try
            {
                _services.PatchClasse(id,record);

                return Ok("Registro alterado com sucesso.");
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPatch("patchAtributos/{id}")]
        public IActionResult PatchAtributos(int id, [FromBody] AtributoRecord atributos)
        {
            try
            {
                _services.PatchAtributos(id, atributos);

                return Ok("Registro alterado com sucesso.");
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _services.Delete(id);

                return Ok("Registro excluído com sucesso.");
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        #endregion Endpoints
    }
}
