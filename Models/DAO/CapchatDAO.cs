using System.Configuration;
using Newtonsoft.Json;

namespace Biometrico.Models.DAO
{
    public class CapchatDAO
    {
        public Captcha VerifcarCaptcha(string response)
        {
            string secret = ConfigurationManager.AppSettings["captchaKey"].ToString();
            var client = new System.Net.WebClient();
            var GoogleReply = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secret, response));
            Captcha obj = JsonConvert.DeserializeObject<Captcha>(GoogleReply);
            return obj;
        }
    }
}