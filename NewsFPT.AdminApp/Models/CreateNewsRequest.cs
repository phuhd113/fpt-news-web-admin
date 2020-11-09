using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsFPT.AdminApp.Models
{
    public class CreateNewsRequest
    {
        public string NewsTitle { get; set; }
        public string Newscontent { get; set; }
        public DateTime DayOfPost { get; set; }
        public int ChannelId { get; set; }
        public string LinkImage { get; set; }




    }
}
