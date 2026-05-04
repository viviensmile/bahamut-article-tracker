using Artemis_Shield.Data;
using Artemis_Shield.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Artemis_Shield.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BahamutArticlesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<BahamutArticlesController> _logger;

        public BahamutArticlesController(ApplicationDbContext context, ILogger<BahamutArticlesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("GetArticles")]
        public async Task<IActionResult> GetArticles()
        {
            try
            {
                var articles = await _context.BahamutArticles.ToListAsync();

                var BahamutArticlesDtos = articles.Select(article => new BahamutArticlesDto
                {
                    id = article.article_id,
                    title = article.title,
                    url = article.link,
                    date = article.published_date,
                    content = article.summary,
                }).ToList();

                return Ok(BahamutArticlesDtos);
            }
            catch (SqlException sqlEx)
            {
                // 資料庫查詢發生錯誤
                _logger.LogError(sqlEx, "Database error occurred while retrieving articles.");
                return StatusCode(500, new { message = "A database error occurred while retrieving articles." });
            }
            catch (Exception ex)
            {
                // 其他一般錯誤
                _logger.LogError(ex, "An unexpected error occurred.");
                return StatusCode(500, new { message = "Internal server error occurred." });
            }
        }
    }
}
