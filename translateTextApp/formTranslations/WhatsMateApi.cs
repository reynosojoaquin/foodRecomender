using System;
using System.IO;
using System.Net;


namespace formTranslations
{
    class translator
    {
        // When you have your own cliend ID and secret, specify them here:
        private static string CLIENT_ID = "FREE_TRIAL_ACCOUNT";
        private static string CLIENT_SECRET = "PUBLIC_SECRET";

        private static string API_URL = "http://api.whatsmate.net/v1/translation/translate";

       
        public bool translate(string fromLang, string toLang, string text)
        {
            bool success = true;

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    client.Headers["X-WM-CLIENT-ID"] = CLIENT_ID;
                    client.Headers["X-WM-CLIENT-SECRET"] = CLIENT_SECRET;
                    client.Encoding = System.Text.Encoding.UTF8;

                    Payload payloadObj = new Payload() { fromLang = fromLang, toLang = toLang, text = text };
                    string postData = (new JavaScriptSerializer()).Serialize(payloadObj);

                    string response = client.UploadString(API_URL, postData);
                    Console.WriteLine(response);
                }
            }
            catch (WebException webEx)
            {
               
                Stream stream = ((HttpWebResponse)webEx.Response).GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                String body = reader.ReadToEnd();
                success = false;
            }

            return success;
        }

        public class Payload
        {
            public string fromLang { get; set; }
            public string toLang { get; set; }
            public string text { get; set; }
        }
    }
}
