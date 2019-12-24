using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Search.Models;

namespace WCSearch.Models
{
    public class SearchData
    {
        public string searchText { get; set; }

        // The list of results.
        public DocumentSearchResult<WC> resultList;


    }
}
