namespace smz3.countdown.wasm.Extenstions
{
    public static class StringExtensions
    {
        public static string ConvertShortGuidToGuidString(this string shortGuid)
        {
            //the SMZ3 site uses slugid, which uses uuid to convert the seed's guid on single player seeds to a shorter, url friendly string
            //this does the necessary steps to reconvert.
            try
            {
                if (shortGuid?.Length == 22)
                    return Convert.ToHexString(Convert.FromBase64String(shortGuid.Replace("-", "+").Replace("_", "/") + "==")).ToLower();

                return shortGuid ?? string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        //public static string ConvertGuidToSlug(this string guid)
        //{
        //    return Convert.ToBase64String(Convert.ToHexString());
        //}
    }
}
