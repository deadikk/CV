namespace CV.Extensions
{
    public static class PhoneExtensions
    {
        private static string UACode = "+38";

        public static string GetFullPhoneWithCode(this string shortNumber)
        {
            return shortNumber.Length != 10 ? "Wrong format" : $"{UACode}{shortNumber}";
        }


        public static string GetFullPhoneWithBrackets(this string shortNumber)
        {
            return shortNumber.Length != 10 
                ? "Wrong format" 
                : $"{UACode}({shortNumber.Substring(0, 3)}) {shortNumber.Substring(3, 3)}-{shortNumber.Substring(6, 2)}-{shortNumber.Substring(8, 2)}";
        }
    }
}