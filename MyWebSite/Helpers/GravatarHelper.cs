using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MyWebSite.Helpers
{
    public static class GravatarHelper
    {
        public static HtmlString GravatarImage(this HtmlHelper htmlHelper, string emailAddress, GravatarOptions options = null)
        {
            if (options == null)
                options = GravatarOptions.GetDefaults();

            var imgTag = new TagBuilder("img");

            emailAddress = string.IsNullOrEmpty(emailAddress) ? string.Empty : emailAddress.Trim().ToLower();

            imgTag.Attributes.Add(
                "src",
                string.Format(
                    "http://www.gravatar.com/avatar/{0}?s={1}{2}{3}",
                    GetMd5Hash(emailAddress),
                    options.Size,
                    "&d=" + options.DefaultImageType,
                    "&r=" + options.RatingLevel));

            return new HtmlString(imgTag.ToString(TagRenderMode.SelfClosing));
        }

        // Source: http://msdn.microsoft.com/en-us/library/system.security.cryptography.md5.aspx
        private static string GetMd5Hash(string input)
        {
            byte[] data = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(input));
            var builder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
}