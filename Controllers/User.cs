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
        }
}