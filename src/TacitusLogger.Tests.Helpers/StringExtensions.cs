
namespace TacitusLogger.Tests.Helpers
{
    public static class StringExtensions
    {
        public static string SmartSubstring(this string str, int length)
        {
            if (str == null)
                return string.Empty;
            else
                return (length < str.Length) ? str.Substring(0, length) : str;
        }
    }
}
