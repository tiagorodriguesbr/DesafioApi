using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cadastro.Models;
using cadastro.Data;

namespace cadastro.Controllers
{
        [ApiController]
        [Route("users")]
        public class UserController : ControllerBase
        {
            [HttpGet]
            [Route("")]
            public async Task<ActionResult<List<User>>> Get([FromServices] DataContext Context)
            {
                var Users = await Context.Users.ToListAsync();
                return Users;
            }
            
            [HttpPost]
            [Route("")]
            public async Task<ActionResult<User>> Post(
                [FromServices] DataContext context,
                [FromBody]User model)
                {
                    if (ModelState.IsValid)
                    {
                        context.Users.Add(model);
                        await context.SaveChangesAsync();
                        return model;
                    }
                    else
                    {
                        return BadRequest(ModelState);
                    }
                }
            
            [HttpDelete("{id:int}")]
            [Route("")]
            public async Task<ActionResult<User>> Delete([FromServices] DataContext context, int id)
            {
                try
                {
                    var _usuario = context.Users.Find(id);
                    context.Users.Remove(_usuario);
                    await context.SaveChangesAsync();
                    _usuario = null;
                    return Ok("User Deleted!");
                }
                catch (Exception ex)
                {
                    return NotFound();
                }
            }

            [HttpPut("{id:int}")]
            [Route("")]
            public async Task<ActionResult<User>> Put(
                [FromServices] DataContext context,
                [FromBody]User model, int id)
                {
                    if (ModelState.IsValid)
                    {
                        var _usuario = context.Users.Find(id);
                        _usuario.Nome = model.Nome;
                        _usuario.Endereco = model.Endereco;
                        await context.SaveChangesAsync();
                        return Ok("Sucess in update");
                    }
                    else
                    {
                        return BadRequest(ModelState);
                     }
                }
        }
}