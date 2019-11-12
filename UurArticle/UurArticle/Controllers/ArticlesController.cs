using System;
using Business.Abstract;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UurArticle.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleBusiness _article;

        public ArticlesController(IArticleBusiness article)
        {
            _article = article;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var articles = _article.GetAll();
                return Ok(articles);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{articleId}")]
        public IActionResult Get(int articleId)
        {
            try
            {
                var article = _article.Get(articleId);

                if (article == null)
                {
                    return NotFound($"There is no book for Id: {articleId}");
                }

                return Ok(article);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]BlogArticle article)
        {
            try
            {
                _article.Insert(article);
                return Ok(article);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody]BlogArticle article)
        {
            try
            {
                _article.Update(article);
                return Ok(article);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]BlogArticle article)
        {
            try
            {
                _article.Delete(article);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("MarkAsDeleted/{articleId}")]
        public IActionResult MarkAsDeleted(int articleId)
        {
            try
            {
                _article.MarkAsDeleted(articleId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetArticles")]
        public IActionResult GetArticles()
        {
            try
            {
                var articles = _article.GetArticles();
                return Ok(articles);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
