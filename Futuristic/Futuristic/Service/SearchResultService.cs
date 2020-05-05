using Futuristic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Futuristic.Service
{
    class SearchResultService
    {
        public List<SearchResult> GetSearchResultsList()
        {
            return new List<SearchResult>()
            {
                new SearchResult () { ImageUrl="walmart.png" ,  Distance= 1 , NumberOfPeople= 80 , PlaceName="WALMART" },
                new SearchResult () { ImageUrl="samsung.png" ,  Distance= 2 , NumberOfPeople= 50 , PlaceName="SAMSUNG" },
                new SearchResult () { ImageUrl="nike.jpg" , Distance= 3 , NumberOfPeople= 10 , PlaceName="NIKE" },
                new SearchResult () { ImageUrl="hyperstar.png" , Distance= 5 , NumberOfPeople= 100 , PlaceName="HYPERSTAR" },
                new SearchResult () { ImageUrl="google.jpg" , Distance= 7 , NumberOfPeople= 2 , PlaceName="GOOGLE" },
                new SearchResult () { ImageUrl="bestbuy.png" , Distance= 8 , NumberOfPeople= 120 , PlaceName="BESTBUY"},
                new SearchResult () { ImageUrl="hyperstar.png" , Distance= 9 , NumberOfPeople= 100 , PlaceName="HYPERSTAR 2" },
                new SearchResult () { ImageUrl="google.jpg" , Distance= 10 , NumberOfPeople= 2 , PlaceName="GOOGLE 2" },
                new SearchResult () { ImageUrl="bestbuy.png" , Distance= 11 , NumberOfPeople= 120 , PlaceName="BESTBUY 2"}

            };

        }
    }
}
