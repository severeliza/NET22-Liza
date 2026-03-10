using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Xml;

namespace hw14
{
    internal class HttpTry
    {
        static HttpClient client = new HttpClient();
        public static async Task GetWeather()
        {
            string url = "http://api.weatherapi.com/v1/current.json?key=58c80189eb8242d4b4992615260403&q=Minsk&aqi=no";

            try
            {
                string responseBody = await client.GetStringAsync(url);
                Console.WriteLine(ParseRawJson(responseBody));
            }
            catch (HttpRequestException e)
            { 
                Console.WriteLine(e.Message);
            }
        }

        private static string ParseRawJson(string rawJson)
        {
            using JsonDocument document = JsonDocument.Parse(rawJson);

            return JsonSerializer.Serialize(document.RootElement, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
        }
    }
}
