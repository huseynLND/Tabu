namespace FirstAPI.Entities;

public class Language
{
    public string Name {get; set;}
    public string Code {get; set;}
    public string Icon {get; set;}
    public IEnumerable<Game>? Games {get; set;}
}
