public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static String SubstringAfter(this string input, string y)
    {
        String[] result = input.Split(y);
        return result[1];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string input, string x, string y)
    {       
        string[] result = input.Split(x);
        string[] output = result[1].Split(y);
        return output[0];
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static String Message(this string input)
    {
        string[] result = input.Split(':');
        return result[1].Trim();
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static String LogLevel(this string input)
    {
        return input.SubstringBetween("[", "]");
    }
}
