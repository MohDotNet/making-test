using Microsoft.OpenApi.Services;

namespace making_test
{
    public static class MaskingService
    {
        public static string ToMasked(this string textToMask)
        {
            int visibleLength = 4;
            string result = string.Empty;

            if (string.IsNullOrEmpty(textToMask))
            {
                return result;
            }

            int length = textToMask.Length;
            result = textToMask.Substring(0, visibleLength) + new string('*',length - visibleLength);
            
            return result;
        }
    }
}
