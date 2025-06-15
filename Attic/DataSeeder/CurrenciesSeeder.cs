using OneDotLearnCore.Essential;
using OneDotLearnData;
using OneDotLearnCore.Financials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataSeeder
{
    internal class CurrenciesSeeder
    {
        public CurrenciesSeeder()
        {
            Task.Run(() => OdlDataHelper.Instance.Currencies.AddRangeAsync(
                    new List<Currency>(){
                        new Currency(),
                    })
                );
        }
    }
}
