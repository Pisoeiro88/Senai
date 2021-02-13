using System;
using System.Threading.Tasks;
using cadaMedicoApi.Data;
using cadaMedicoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace cadaMedicoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CidadeController : ControllerBase
    {
        private readonly IRepository _repo;

       public CidadeController(IRepository repo){
           _repo = repo;
       }
       [HttpGet]
       public async Task<IActionResult> Get(){
           try{
               var result = await _repo.GetAllCidadeModelsAsync(true);
               return Ok(result); 
           }
           catch (Exception ex){
               return BadRequest($"Erro: {ex.Message}");
           }
       }

       [HttpGet ("{CidadeId}")]
       public async Task<IActionResult> getByCidadeId(int CidadeId){
           try{
               var result = await _repo.GetCidadeModelsById(CidadeId, true);
               return Ok(result); 
           }
           catch (Exception ex){
               return BadRequest($"Erro: {ex.Message}");
           }
       }
    }
}