namespace CrossPlatformUtils
{
    public static class StringUtils
    {
        public static string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return new string(input.Reverse().ToArray());
        }
    }
}
