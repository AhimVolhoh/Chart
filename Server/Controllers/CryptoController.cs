using Microsoft.AspNetCore.Mvc;
using Template.Server.Services.Interfaces;
using Template.Shared.Models;

namespace Template.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CryptoController : ControllerBase
    {
        private readonly ICryptoServices _CryptoWork;
        public CryptoController(ICryptoServices cryptoWork)
        {
            _CryptoWork = cryptoWork;
        }

        [HttpPost]
        public async Task<ActionResult> Add(CryptoDate CryptoTimeDate)
        {
            await _CryptoWork.Add(CryptoTimeDate);
            return Ok();
        }

        [HttpPost("delete")]
        public async Task<ActionResult> Delete([FromBody]int id)
        {
            await _CryptoWork.Delete(id);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<CryptoDate>>> GetList()
        {
            var ListOfCrypto = await _CryptoWork.GetList();
            return Ok(ListOfCrypto);
        }
    }
}
