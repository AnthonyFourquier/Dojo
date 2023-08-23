using BO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TPDojo.Models
{
    public class SamouraiVM
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Force { get; set; }
        public int? ArmeId { get; set; }
        public Arme? Arme { get; set; }
        public SelectList Armes { get; set; }
        public List<ArtMartial>? ArtMartials { get; set; }
        public SelectList ArtMartialsSelect { get; set; }
        public List<int> ArtMartialSamouraiIds { get; set; } = new List<int>();
    }
}
