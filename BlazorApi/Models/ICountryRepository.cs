using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorShared;

namespace BlazorApi.Models
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
    }
}
