using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VIPStore.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalIteams { get; set; }

        public int IteamsPerPage {get; set; }
        public int CurrentPage { get; set; }

        public int TotalPage => (int)Math.Ceiling((decimal)TotalIteams / IteamsPerPage);
    }
}
