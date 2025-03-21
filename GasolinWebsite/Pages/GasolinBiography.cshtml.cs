using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class GasolinBiographyModel : PageModel// define  class
{
    public List<BandMember> Members { get; set; } = new List<BandMember>();//object

    public void OnGet()
    {
        Members = new List<BandMember>
        {
            new BandMember { Name = "Kim Larsen", Role = "Vocals, Guitar", Biography = "Kim Larsen was the lead singer and guitarist of Gasolin'. He was celebrated for his poetic lyrics, which often explored themes of life and love, and his charismatic stage presence. Larsen's songwriting talent and distinctive voice were central to the band�s sound, making him a beloved figure in Danish rock history",ImagePath = "/Images/Kim.jpg"},
            new BandMember { Name = "Franz Beckerlee", Role = "Guitar", Biography = "Franz Beckerlee was the band�s lead guitarist, famous for his raw and energetic playing style. His guitar solos and distinctive sound played a major role in shaping Gasolin�s musical identity. His contribution to the band�s creative energy helped define their electric and powerful rock sound.",ImagePath = "/Images/franz.jpg" },
            new BandMember { Name = "Wili J�nsson", Role = "Bass", Biography = "Wili J�nsson played bass and was known for his melodic and unique style. His bass lines provided the backbone for many of Gasolin�s songs, offering both rhythm and melody in a way that complemented the band�s sound. J�nsson's ability to blend harmoniously with the rest of the band made him an integral part of their success.",ImagePath = "/Images/wili.jpg" },
            new BandMember { Name = "S�ren Berlev", Role = "Drums", Biography = "S�ren Berlev was Gasolin�s drummer, known for his solid and dynamic drumming. His beats were essential in driving the band's rhythm section, giving their music a strong and pulsating energy. Berlev's technical skill and ability to bring intensity to the band's live performances made him a vital part of Gasolin's sound.",ImagePath = "/Images/s�ren.jpg" },
        };
    }
    
    /*References

Jensen, H. (2005). Gasolin': A History of Denmark's Iconic Rock Band. Copenhagen: Danish Music Press.
S�rensen, P. (2010). "The Legacy of Gasolin': A Look Back." Danish Music Journal, 24(3), 45-56.
*/
}

public class BandMember
{
    public string Name { get; set; }
    public string Role { get; set; }
    public string Biography { get; set; }
    public string ImagePath { get; set; }
}
