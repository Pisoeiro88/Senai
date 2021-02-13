using System;
using System.Threading.Tasks;
using cadaMedicoApi.Data;
using cadaMedicoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace cadaMedicoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicoController : ControllerBase
    {
       private readonly IRepository _repo;

       public MedicoController(IRepository repo){
           _repo = repo;
       }

       [HttpGet]
       public async Task<IActionResult> Get(){
           try{
               var result = await _repo.GetAllMedicoModelsAsync(true);
               return Ok(result); 
           }
           catch (Exception ex){
               return BadRequest($"Erro: {ex.Message}");
           }
       }
       [HttpGet ("{MedicoId}")]
       public async Task<IActionResult> getByMedicoId(int MedicoId){
           try{
               var result = await _repo.GetMedicoModelsById(MedicoId, true);
               return Ok(result);
           }
           catch(Exception ex){
               return BadRequest($"Erro: {ex.Message}");
           }
       }
       [HttpGet("especialidade/{especialidadeId}")]
       public async Task<IActionResult> GetByEspecilaidadeId(int especialidadeId){
           try{
               var result = await _repo.GetMedicoModelsByEspeciaidadeId(especialidadeId, true);
               return Ok(result);
           }
           catch(Exception ex){
               return BadRequest($"Erro: {ex.Message}");
           }
       }
       [HttpPost]
       public async Task<IActionResult> post(MedicoModels model){
           try{
               _repo.Add(model);
               if(await _repo.SaveChangesAsync()){
                   return Ok(model);
               }
           }
           catch(Exception ex){
               return BadRequest($"Erro: {ex.Message}");
           }
           return BadRequest();
       }
       [HttpPut("{medicoId}")]
       public async Task<IActionResult> put(int medicoId, MedicoModels models){
           try{
               var medico = await _repo.GetMedicoModelsById(medicoId, false);
               if(medico==null){
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
           [HttpDelete("{medicoId}")]
           public async Task<IActionResult> delete(int medicoId){
               try{
                   var medico = await _repo.GetMedicoModelsById(medicoId, false);
                   if(medico == null) return NotFound();

                   _repo.Delete(medico);

                   if(await _repo.SaveChangesAsync()){
                       return Ok("Medico Deletado!!");
                   }
               }catch(Exception ex){
                   return BadRequest($"Erro: {ex.Message}");
           }
           return BadRequest();
               
           }

    }
}