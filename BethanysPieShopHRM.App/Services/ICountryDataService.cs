using BethanysPieShopHRM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.App.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
