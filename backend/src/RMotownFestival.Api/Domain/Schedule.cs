using System.Collections.Generic;

namespace RMotownFestival.Api.Domain
{
    public class Schedule
    {
        public int Id { get; set; }

        public List<ScheduleItem> Items { get; set; }
    }
}
