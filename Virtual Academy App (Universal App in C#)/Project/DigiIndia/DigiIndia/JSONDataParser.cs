using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace DigiIndia
{
    public class JSONDataParser
    {
        async public void JSONDataChapter()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync(new Uri("http://localhost:61367/api/Chapters"));
            var ChapterResult = JsonConvert.DeserializeObject<List<Chapter>>(response);

        }
    }
}
