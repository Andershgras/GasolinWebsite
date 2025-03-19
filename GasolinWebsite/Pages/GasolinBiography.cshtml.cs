using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class GasolinBiographyModel : PageModel// define  class
{
    public List<BandMember> Members { get; set; } = new List<BandMember>();//object

    public void OnGet()
    {
        Members = new List<BandMember>
        {
            new BandMember { Name = "Kim Larsen", Role = "Vocals, Guitar", Biography = "Kim Larsen was the lead singer and guitarist of Gasolin, known for his poetic lyrics and charismatic stage presence.",ImagePath = "/Images/Kim.jpg "},
            new BandMember { Name = "Franz Beckerlee", Role = "Guitar", Biography = "Franz Beckerlee was the band's lead guitarist, famous for his raw and energetic playing style.",ImagePath = "/Images/franz.jpg " },
            new BandMember { Name = "Wili Jønsson", Role = "Bass", Biography = "Wili Jønsson played bass and contributed to the band's unique sound with his melodic style.",ImagePath = "/Images/wili.jpg " },
            new BandMember { Name = "Søren Berlev", Role = "Drums", Biography = "Søren Berlev was Gasolin's drummer, known for his solid and dynamic drumming.",ImagePath = "/Images/søren.jpg " }
        };
    }
}

public class BandMember
{
    public string Name { get; set; }
    public string Role { get; set; }
    public string Biography { get; set; }
    public string ImagePath { get; set; }
}
