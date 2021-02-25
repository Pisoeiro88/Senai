using System;
using System.Threading.Tasks;
using cadaMedicoApi.Data;
using cadaMedicoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace cadaMedicoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IRepository _repo;

       public UsuarioController(IRepository repo){
           _repo = repo;
       }
       [HttpGet]
       public async Task<IActionResult> Get(){
           try{
               var result = await _repo.GetAllUsuarioModelsAsync(true);
               return Ok(result); 
           }
           catch (Exception ex){
               return BadRequest($"Erro: {ex.Message}");
           }
       }

       [HttpGet ("{UsuarioId}")]
       public async Task<IActionResult> getByUsuarioId(int UsuarioId){
           try{
               var result = await _repo.GetUsuarioModelsById(UsuarioId, true);
               return Ok(result); 
           }
           catch (Exception ex){
               return BadRequest($"Erro: {ex.Message}");
           }
       }
       [HttpPost]
       public async Task<IActionResult> post(UsuarioModels model){
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
       [HttpPut("{UsuarioId}")]
       public async Task<IActionResult> put(int usuarioId, UsuarioModels models){
           try{
               var usuario = await _repo.GetUsuarioModelsById(usuarioId, true);
               if(usuario==null){
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
           [HttpDelete("{usuarioId}")]
           public async Task<IActionResult> delete(int usuarioId){
               try{
                   var usuario = await _repo.GetUsuarioModelsById(usuarioId, true);
                   if(usuario == null) return NotFound();

                   _repo.Delete(usuario);

                   if(await _repo.SaveChangesAsync()){
                       return Ok("Usuario Deletado!!");
                   }
               }catch(Exception ex){
                   return BadRequest($"Erro: {ex.Message}");
           }
           return BadRequest();
               
           }
    }
}