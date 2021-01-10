using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;



namespace Api
{
    public static class NobelProcessor
    {
        public static async Task<NobelModel> GetNobels()
        {
            try
            {
                using (HttpResponseMessage response=await ApiHelper.ApiClient.GetAsync("https://api.nobelprize.org/2.0/laureates"))
                {
                    if(response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<NobelModel>(json);
                        return result;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
