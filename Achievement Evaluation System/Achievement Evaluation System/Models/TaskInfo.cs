using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Achievement_Evaluation_System.Models
{
    public class TaskInfo
    {
        //Task ID
        [Display(Name = "Task ID")]
        public int ID { get; set; }

        //Task Name
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        [Display(Name = "Task Name")]
        public string Task_name{ get; set; }

        //Task Description
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(1000)]
        [DataType(DataType.Text)]
        [Display(Name = "Task Description")]
        public string Task_description { get; set; }

        //Task Due Date
        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy:mm:dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Task Due Date")]
        public DateTime Task_dude_date { get; set; }

        //Task Status
        [Required(ErrorMessage = "This field is required.")]
        [Display(Name = "Task Status")]
        public int Task_status { get; set; }

        //Task Employee Comment
        [Display(Name = "Employee Comment")]
        public string User_comment { get; set; }


        //FORIGEN KEYS
        // Department Foreign Key
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        // Team Foreign Key
        [ForeignKey("Team")]
        public int TeamID { get; set; }

        // Employee Foreign key
        [ForeignKey("Task")]
        public int EmployeeID { get; set; }

        // Task Foreign Key
        [ForeignKey("Achievement")]
        public int AchievementID { get; set; }

        //Don't we need to retrive names after (for forigen keys)

        //Don't we need Task FileID\Attachment?!


        //Relations
        public virtual Department Department { get; set; }
        public virtual Team Team { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Achievement Achievement { get; set; }
        public virtual ICollection<File> Files { get; set; } //Needed?

    }

    public class TaskInfoDBContext : DbContext
    {
        public DbSet<TaskInfo> TaskInfos { get; set; }
    }

    // Define a class contains two value for status attribute
    public enum Task_Status
    {

        Completed = 1,
        Not_Completed = 0
    }
}