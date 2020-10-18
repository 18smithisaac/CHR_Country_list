using System.Collections.Generic;
using CHR_Country_list.Models;

namespace CHR_Country_list.Data
{
    public interface ICountryListRepo 
    {
        Route GetRoute(string name);
    }
}