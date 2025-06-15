using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneDotLearnCore.Essential;
using OneDotLearnData;

namespace DataSeeder
{
    internal class CountriesSeeder
    {
        public CountriesSeeder()
        {
            Task.Run(() => OdlDataHelper.Instance.Countries.AddRangeAsync(
                    new List<Country>(){
                        new Country(),
                    })
                );
        }
    }
}
