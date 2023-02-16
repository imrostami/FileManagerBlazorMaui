global using static FileManagerBlazor.Data.PathEncoder;
namespace FileManagerBlazor.Data
{
    public class PathEncoder
    {
        static PathEncoder _encoder;




        public static PathEncoder PathEncoderContext
        {
            get
            {
                if(_encoder is null)
                {
                    _encoder = new PathEncoder();
                    return _encoder;
                }
                return _encoder;
            }
        }


        public string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }


        public string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
