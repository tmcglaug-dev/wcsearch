using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Search;
using Microsoft.Azure.Search.Models;
using Microsoft.Spatial;
using Newtonsoft.Json;

namespace WCSearch.Models
{
    public class WC
    {

        [IsSearchable, IsSortable]
        public string content { get; set; }

        [IsSearchable, IsSortable]
        public string AppealTitle { get; set; }

        [IsSearchable, IsSortable]
        public string Employee { get; set; }

        [IsSearchable, IsSortable]
        public string Employer { get; set; }

        [IsSearchable, IsSortable]
        public string Insurer { get; set; }

        [IsSearchable, IsSortable]
        public string TPA { get; set; }

        [IsSearchable, IsSortable]
        public string CaseNo { get; set; }

        [IsSearchable, IsSortable]
        public string Date { get; set; }

        [IsSearchable, IsSortable]
        public string URL { get; set; }

        [IsSearchable, IsSortable]
        public string FileName { get; set; }


    }
}
