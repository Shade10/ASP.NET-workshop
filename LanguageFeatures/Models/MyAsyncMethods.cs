using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace LanguageFeatures.Models {
    public class MyAsyncMethods {
        public async static Task<long?> GetPageLength() {
            HttpClient client = new HttpClient();
            var httpMesage = await client.GetAsync("http://apress.com");

            return httpMesage.Content.Headers.ContentLength;
        }
    }
}