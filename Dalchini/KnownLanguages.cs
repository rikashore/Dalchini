namespace Dalchini;

public static class KnownLanguages
{
    private static readonly Language CLike = new("//", ("/*", "*/"));
    
    public static readonly Dictionary<string, Language> Languages = new()
    {
        { ".cs", CLike },
        { ".c", CLike },
        { ".h", CLike },
        { ".cpp", CLike },
        { ".hpp", CLike },
        { ".java", CLike },
        { ".lua", new Language("--", ("--[[", "--]]")) },
        { ".ml", new Language("", ("(*", "*)")) },
        { ".mli", new Language("", ("(*", "*)")) },
        { ".rb", new Language("#", ("=begin", "=end")) },
        { ".rs", new Language("//", ("", "")) },
    };
}