using System.Collections.Generic;

namespace RMotownFestival.Api.Domain
{
    public class Festival
    {
        public int Id { get; set; }

        public int LineUpId { get; set; }
        public Schedule LineUp { get; set; }

        public List<Artist> Artists { get; set; }
        public List<Stage> Stages { get; set; }
    }
}
