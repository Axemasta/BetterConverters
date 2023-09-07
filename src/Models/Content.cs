using BetterConverters.Enums;

namespace BetterConverters.Models;

public class Content
{
    public int Id { get; set; }

    public MediaType Type { get; set; }

    public string Name { get; set; }
}
