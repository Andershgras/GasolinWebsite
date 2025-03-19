using Microsoft.AspNetCore.Mvc.RazorPages;

public class GasolinTimeLineModel : PageModel
{
    public List<GasolinEvent> GasolinTimeLineEvents { get; set; } = new();

    public void OnGet()
    {
        // Sample events for testing
        GasolinTimeLineEvents = new List<GasolinEvent>
        {
            new GasolinEvent { Date = "1970", Title = "Formation of Gasolin", Description = "Gasolin was formed in Denmark." },
            new GasolinEvent { Date = "1976", Title = "Peak Popularity", Description = "Gasolin became one of Denmark's top rock bands." },
            new GasolinEvent { Date = "1978", Title = "Disbandment", Description = "Gasolin disbanded after a successful career." }
        };
    }
}

// Event Model
public class GasolinEvent
{
    public string Date { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
