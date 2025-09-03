using Microsoft.AspNetCore.Mvc;
using SisNDragons.Models;
using SisNDragons.Services;

namespace SisNDragons.Controllers
{
    [ApiController]
    [Route("api/bestiario")]
    public class BestiarioController : Controller
    {

        #region Constructor
        
        public BestiarioController(BestiarioServices services)
        {
            _services = services;
        }

        #endregion Constructor

        #region Private Properties

        private BestiarioServices _services;

        #endregion Private Properties

        #region Endpoints

        [HttpGet]
        public IEnumerable<BestiarioRecord> Get()
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
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }


        [HttpGet("criaturas")]
        public IActionResult Get(string? nome, int? nivel, int? tipo, int? nivelPerigo, int? raridade)
        {
            try
            {
                var records = _services.GetFilter(nome, nivel, tipo, nivelPerigo, raridade);

                return Ok(records);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }


        [HttpPost]
        public IActionResult Create([FromBody] BestiarioRecord record)
        {
            try
            {
                _services.Create(record);

                return Created("api/bestiario/", record);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }


        [HttpPut]
        public IActionResult Update([FromBody] BestiarioRecord record)
        {
            try
            {
                _services.Update(record);

                return Ok("Registro alterado com sucesso.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
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
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }

        #endregion Endpoints

    }
}
