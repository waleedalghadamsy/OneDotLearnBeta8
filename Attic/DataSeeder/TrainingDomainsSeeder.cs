using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneDotLearnCore.Training;
using OneDotLearnData;

namespace DataSeeder
{
    internal class TrainingDomainsSeeder
    {
        public TrainingDomainsSeeder()
        {
            Task.Run(() => OdlDataHelper.Instance.Domains.AddRangeAsync(
                    new List<ProductDomain>(){
                        new ProductDomain(),
                    })
                );
        }
    }
}
