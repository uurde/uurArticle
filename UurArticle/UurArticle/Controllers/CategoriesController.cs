using System;
using Business.Abstract;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;


namespace UurArticle.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryBusiness _category;

        public CategoriesController(ICategoryBusiness category)
        {
            _category = category;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var categories = _category.GetAll();
                return Ok(categories);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{articleId}")]
        public IActionResult Get(int categoryId)
        {
            try
            {
                var category = _category.Get(categoryId);

                if (category == null)
                {
                    return NotFound($"There is no book for Id: {categoryId}");
                }

                return Ok(category);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]BlogCategory category)
        {
            try
            {
                _category.Insert(category);
                return Ok(category);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody]BlogCategory category)
        {
            try
            {
                _category.Update(category);
                return Ok(category);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]BlogCategory category)
        {
            try
            {
                _category.Delete(category);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("MarkAsDeleted/{categoryId}")]
        public IActionResult MarkAsDeleted(int categoryId)
        {
            try
            {
                _category.MarkAsDeleted(categoryId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
