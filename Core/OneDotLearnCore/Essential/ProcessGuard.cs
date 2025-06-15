using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OneDotLearnCore.Essential
{
    public class ProcessGuard
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        #endregion

        #region Methods
        public static bool IsNull<T>(T entity)
        {
            return entity == null;
        }

        public static bool IsListNullOrEmpty<T>(IEnumerable<T> entityList)
        {
            return entityList == null || !entityList.Any();
        }
        #endregion
    }
}
