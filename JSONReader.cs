using Newtonsoft.Json;

namespace TheBattleBot
{
    internal class JSONReader
    {
        public string Token {  get; set; }
        public string Prefix { get; set; }

        public async Task ReadJSON()
        {
            using (var sr = new StreamReader("config.json")) 
            { 
                var json = await sr.ReadToEndAsync();
                var config = JsonConvert.DeserializeObject<JSONStructor>(json);

                this.Token = config.token;
                this.Prefix = config.prefix;
            }
        }
    }

    internal sealed class JSONStructor
    {
        public string token { get; set; }
        public string prefix { get; set; }
    }
}
