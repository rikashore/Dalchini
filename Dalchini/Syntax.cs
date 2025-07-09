namespace Dalchini;

// Represents a line comment marker
public readonly record struct LineMarker(string Value)
{
    public static implicit operator string(LineMarker l)
        => l.Value;

    public static implicit operator LineMarker(string s)
        => new(s);
}

// Represents a multi line comment marker
public readonly record struct MultilineMarker(string Start, string End)
{
    public static implicit operator MultilineMarker((string, string) pair)
        => new(pair.Item1, pair.Item2);
}

public record Language(LineMarker LineMarker, MultilineMarker MultilineMarker);
