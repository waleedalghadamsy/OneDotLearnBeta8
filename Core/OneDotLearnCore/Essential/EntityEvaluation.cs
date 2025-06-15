using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Essential
{
    [Table("Evaluations", Schema = "General")]
    public class EntityEvaluation : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int EntityId { get; set; }
        [Required]
        public EntityType EntityType { get; set; }
        [Required]
        public int EvaluatedById { get; set; }
        [Required]
        public EvaluationDegree Degree { get; set; }
        public string? Details { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
