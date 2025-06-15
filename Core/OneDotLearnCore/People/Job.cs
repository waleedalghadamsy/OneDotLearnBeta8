using OneDotLearnCore.Essential;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OneDotLearnCore.People
{
    public class Job : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        //public Job(string jobName)
        //{
        //    Name = jobName; EssentialTasks = new List<string>();
        //}
        #endregion

        #region Properties
        //public static Job Manager = new Job("Manager");
        //public static Job Secretary = new Job("Secretary");
        [Required, StringLength(75)]
        public string Name { get; set; }
        public string Description { get; set; }
        //public List<string> EssentialTasks { get; set; }
        //public Salary BasicSalary { get; set; }
        #endregion

        #region Methods
        //public void Method()
        //{
        //}
        #endregion

        #region IEquatable<Job> Members

        //public bool Equals(Job other)
        //{
        //    return (name.ToLower() == other.name.ToLower());
        //}

        #endregion
    }
}
