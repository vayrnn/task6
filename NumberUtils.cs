namespace CrossPlatformUtils
{
    public static class NumberUtils
    {
        public static int ParseIntOrDefault(string input, int defaultValue = 0)
        {
            return int.TryParse(input, out int result) ? result : defaultValue;
        }
    }
}
