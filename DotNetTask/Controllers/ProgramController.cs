using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos;
using Services;

namespace DotNetTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramController : ControllerBase
    {
        private readonly IService _service;

        public ProgramController(IService service)
        {
            _service = service;
        }
        [HttpPost("program")]
        public async Task<IActionResult> CreateProgram([FromBody] ProgramDto item)
        {
            item.ProgramId=Guid.NewGuid().ToString();  
            await _service.AddAsync(item);
            return Ok("succesfully Created");
        }
        [HttpGet("get-program")]
        public async Task<IActionResult> GetProgram(string Id)
        {
           var result = await  _service.GetAsync(Id);
            return Ok(result);

        }
        [HttpPut("update-program")]
        public async Task<IActionResult> UpdateProgram([FromBody] ProgramDto item)
        {
            await _service.UpdateAsync(item.ProgramId, item);
            return Ok("Successfully Updated");
        }

        
       
    }
}
