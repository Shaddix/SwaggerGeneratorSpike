using Microsoft.AspNetCore.Mvc;

namespace SwaggerGenSpike.Controllers
{
    public class ApiController : Controller
    {
        [HttpGet("/api/index")]
        public ActionResult<string> Index()
        {
            return "zxc";
        }

        public class Tst1
        {
            public int I { get; set; }
            public string Str { get; set; }
        }

        [HttpGet("/api/index2")]
        public ActionResult<Tst1> Index2()
        {
            return new Tst1();
        }

        public class Index3RequestDto
        {
            public int IntVar { get; set; }
            public string Str { get; set; }
        }

        [HttpGet("/api/index3")]
        public ActionResult<Tst1> Index3(Index3RequestDto dto)
        {
            return new Tst1()
            {
                I = dto.IntVar,
                Str = dto.Str
            };
        }

        [HttpPost("/api/index4")]
        public ActionResult<Tst1> Index4([FromBody]Index3RequestDto dto)
        {
            return new Tst1()
            {
                I = dto.IntVar,
                Str = dto.Str
            };
        }
    }
}