using System;
using System.ComponentModel.DataAnnotations;

namespace VacationApp.Models
{
    public class VacationRequest
    {
        [Key]
        public int Id { get; set; }
        public VacationType Type { get; set; }
        public RequestStatus Status { get; set; }
        public DateTime VacationStart { get; set; }
        public DateTime VacationEnd { get; set; }
        public int VacationTotalDays { get; set; }
        public Employee Employee { get; set; }
    }

}