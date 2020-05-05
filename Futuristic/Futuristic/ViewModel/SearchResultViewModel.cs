using Futuristic.Model;
using Futuristic.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Futuristic.ViewModel
{
    class SearchResultViewModel
    {
        public List<SearchResult> SearchResults { get; set; }
        public SearchResultViewModel()
        {
            SearchResults = new SearchResultService().GetSearchResultsList();
        }
    }
}
