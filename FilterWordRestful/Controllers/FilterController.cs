using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilterWordRestful.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WordFilterController : ControllerBase
    {
        private static readonly string[] stopwords = new[]
       {

            "a", "an", "in", "on", "the", "is", "are", "am"
       };


        private readonly ILogger<WordFilterController> _logger;

        public WordFilterController(ILogger<WordFilterController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "WordFilter")]

        public string WordFilterRestful(string content)
        {

            return content;
        }
    }
}
