using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetApiReact.Models
{
    public class UserActivitiesDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ActiviyType { get; set; }
        public DateTime Time { get; set; }
    }
}