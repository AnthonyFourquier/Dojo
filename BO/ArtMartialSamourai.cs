using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ArtMartialSamourai
    {
        public int ArtMartialId { get; set; }
        public int SamouraiId { get; set; }

        public Samourai Samourai { get; set; }

        public ArtMartial ArtMartial { get; set; }


    }
}
