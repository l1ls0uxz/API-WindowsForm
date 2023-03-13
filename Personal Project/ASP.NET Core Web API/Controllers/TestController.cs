using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Data;

namespace ASP.NET_Core_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // MySQL Connect
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;database=demohmiconnectpc1;username=root;password=0546;");

        // GET
        [HttpGet]
        public string Get()
        {
            //string sqlCmd = "SELECT * FROM b04;";

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM b04 where (DateTime between '2023-03-03 06:00:00' and '2023-03-03 18:00:00');", conn); //

            da.SelectCommand.CommandType = CommandType.Text;

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return JsonConvert.SerializeObject(dt);
            }
            else
            {
                return "no data found!";
            }
        }
    }
}