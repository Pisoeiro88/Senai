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
       [HttpPost]
       public async Task<IActionResult> post(CidadeModels model){
           try{
               _repo.Add(model);
               if(await _repo.SaveChangesAsync()){
                   return Ok($"Adicionado com Sucesso");
               }
           }
           catch(Exception ex){
               return BadRequest($"Erro: {ex.Message}");
           }
           return BadRequest();
       }
       [HttpPut("{cidadeId}")]
       public async Task<IActionResult> put(int cidadeId, CidadeModels models){
           try{
               var cidade = await _repo.GetCidadeModelsById(cidadeId, false);
               if(cidade==null){
                   return NotFound();
               }
               _repo.Update(models);

               if(await _repo.SaveChangesAsync()){
                   return Ok("Alteração Realizada");
               }
           }catch(Exception ex){
               return BadRequest($"Erro: {ex.Message}");
           }
           return BadRequest();
       }
           [HttpDelete("{cidadeId}")]
           public async Task<IActionResult> delete(int cidadeId){
               try{
                   var cidade = await _repo.GetCidadeModelsById(cidadeId, false);
                   if(cidade == null) return NotFound();

                   _repo.Delete(cidade);

                   if(await _repo.SaveChangesAsync()){
                       return Ok(new {menssege="Cidade Deletado!!"});
                   }
               }catch(Exception ex){
                   return BadRequest($"Erro: {ex.Message}");
           }
           return BadRequest();
               
           }
    }
}