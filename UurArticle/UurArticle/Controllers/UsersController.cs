using System;
using Business.Abstract;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;


namespace UurArticle.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserBusiness _user;

        public UsersController(IUserBusiness user)
        {
            _user = user;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var users = _user.GetAll();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{userId}")]
        public IActionResult Get(int userId)
        {
            try
            {
                var user = _user.Get(userId);

                if (user == null)
                {
                    return NotFound($"There is no book for Id: {userId}");
                }

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]BlogUser user)
        {
            try
            {
                _user.Insert(user);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody]BlogUser user)
        {
            try
            {
                _user.Update(user);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]BlogUser user)
        {
            try
            {
                _user.Delete(user);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("MarkAsDeleted/{userId}")]
        public IActionResult MarkAsDeleted(int userId)
        {
            try
            {
                _user.MarkAsDeleted(userId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
