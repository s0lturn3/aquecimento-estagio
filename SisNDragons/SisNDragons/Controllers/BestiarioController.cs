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
            catch (Exception ex)
            {
                return StatusCode(500);
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
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }


        [HttpPost]
        public IActionResult Create([FromBody] BestiarioRecord record)
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
        public IActionResult Update([FromBody] BestiarioRecord record)
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
