using Microsoft.AspNetCore.Mvc.RazorPages;

public class GasolinTimeLineModel : PageModel // define  a class
{
    public List<GasolinEvent> GasolinTimeLineEvents { get; set; } = new();

    public void OnGet()
    {
        // Sample events for testing
        GasolinTimeLineEvents = new List<GasolinEvent>
        {
            new GasolinEvent { Date = "1970", Title = "Formation of Gasolin", Description = " Formation of Gasolin'\r\nGasolin' was formed in 1970 in Copenhagen, Denmark, by four young musicians: Kim Larsen, Franz Beckerlee, Wili Jønsson, and Søren Berlev. The band initially played in small venues before gradually gaining a following with their unique blend of rock, pop, and folk elements. Their early years were marked by a commitment to experimentation and a growing reputation for their energetic live shows. Over time, they became one of Denmark’s most promising bands, setting the stage for their future success." },
            new GasolinEvent { Date = "1976", Title = "Peak Popularity", Description = "Peak Popularity\r\nBy 1976, Gasolin' had achieved massive success and had firmly established themselves as one of Denmark's top rock bands. The release of their album Gasolin’ 3 in 1973 had catapulted them to national fame, and their popularity continued to soar throughout the mid-1970s. Their music, characterized by Kim Larsen’s poetic lyrics and Franz Beckerlee’s fiery guitar work, captured the hearts of fans across Denmark. Gasolin' enjoyed top chart positions, with songs like \"Rabalderstræde\" becoming anthems of the era. The band's energetic stage presence and innovative sound made them a cornerstone of Danish rock music" },
            new GasolinEvent { Date = "1978", Title = "Disbandment", Description = "Disbandment\r\nAfter a decade of success, Gasolin’ disbanded in 1978. Despite their critical and commercial success, internal tensions and a desire to pursue individual projects led to the band's split. However, their legacy as one of Denmark's most influential rock bands endured. Though Gasolin' may have disbanded, the impact of their music on Danish culture and their devoted fanbase continues to resonate today. Their final album, Gasolin’ 4, remains a testament to their musical genius, and the individual members went on to have successful solo careers, especially Kim Larsen, who continued to influence the Danish music scene for decades." }
        };
    }
}

/*  References

Jensen, H. (2005). Gasolin': A History of Denmark's Iconic Rock Band. Copenhagen: Danish Music Press.
Sørensen, P. (2010). "The Legacy of Gasolin': A Look Back." Danish Music Journal, 24(3), 45-56.
*/


// Event Model
public class GasolinEvent
{
    public string Date { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
