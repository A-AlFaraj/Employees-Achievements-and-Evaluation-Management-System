using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Achievement_Evaluation_System.Models
{
    public class Department
    {
// Original Model Attributes
        // Department ID
        public int ID { get; set; }

        // Department Name
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(50)]
        [DataType(DataType.Text)]
        [Display(Name = "Department Name")]
        public string Department_name { get; set; }

        // Department Acronym
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(10)]
        [DataType(DataType.Text)]
        [Range(2,10)]
        [Display(Name = "Department Acronym")]
        public string Acronym { get; set; }

        // Department Description
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(1000)]
        [DataType(DataType.Text)]
        [Display(Name = "Department Description")]
        public string Department_description { get; set; }

// Attributes for foreign keys
        // Achievement Foreign key
        [ForeignKey("Achievement")]
        public int AchievementID { get; set; }

        // Employee Foreign Key
        [ForeignKey("Employee")]
        [Display(Name = "Department Manager")]
        public int ManagerID { get; set; }

        // Task Foreign key
        [ForeignKey("TaskInfo")]
        public int TaskInfoID { get; set; }

        // Team Foreign Key
        [ForeignKey("Team")]
        public int TeamID { get; set; }

// Relations
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<TaskInfo> TaskInfos { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Achievement> Achievements { get; set; }


    }

    public class DepartmentDBContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
    }
}