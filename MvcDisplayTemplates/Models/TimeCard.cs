using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDisplayTemplates.Models
{
    public class TimeCard
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        [DisplayName("Start Date")]
        [DataType(DataType.DateTime)]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.Duration)]
        [DisplayName("Number of Hours")]
        [UIHint("HoursOfTheDay")]
        public Decimal NumberOfHours { get; set; }
    }
}