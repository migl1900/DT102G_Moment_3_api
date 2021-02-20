using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DT102G_Moment3_api.Models
{
    public class Record
    {
        // Properties
        public int RecordId { get; init; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public string Category { get; set; }
    }
}
