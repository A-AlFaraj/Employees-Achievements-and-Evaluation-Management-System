using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Achievement_Evaluation_System.Models
{
    public class Achievement
    {
        // original Model Attributes
        // Achievement ID
        [Display(Name = "Achievement ID")]
        public int ID { get; set; }

        // Achievement Name
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        [Display(Name = "Achievement Name")]
        public string Achievement_name { get; set; }

        // Achievement Description
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(1000)]
        [DataType(DataType.Text)]
        [Display(Name = "Achievement Description")]
        public string Achievement_description { get; set; }

        // Achievement Completion Time
        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        [Display(Name = "Achievement Completion Time")]
        public DateTime Achievement_completion_time { get; set; }

        // Achievement Date
        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy:mm:dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Achievement Date")]
        public DateTime Achivement_date { get; set; }

        // Achievement Status
        [Required(ErrorMessage = "This field is required.")]
        [Display(Name = "Achievement Status")]
        public AchievmentStatus? Achievement_status { get; set; }

        // Attributes for Supervisor evaluation ,,, shall they be here?
        //Supervisor Comment
        [StringLength(1000)]
        [DataType(DataType.Text)]
        [Display(Name = "Achievement Evaluation Comment")]
        public string Supervisor_comment { get; set; }

        // Achievement Score
        [Range(0,100, ErrorMessage = "The score must be between 0 and 100")]
        [Display(Name = "Achievement Evaluation Score")]
        public int Achievement_score { get; set; }

        // Attributes for the foreign keys

        // Department Foreign Key
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        // Team Foreign Key
        [ForeignKey("Team")]
        public int TeamID { get; set; }

        // Employee Foreign key
        [ForeignKey("Emplolyee")]
        public int EmployeeID { get; set; }

        // Task Foreign Key
        [ForeignKey("TaskInfo")]
        public int TaskInfoID { get; set; }

        // File Foreign Key
        [ForeignKey("File")]
        public int FileID { get; set; }

        // Relations
        public virtual Department Department { get; set; }
        public virtual Team Team { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual TaskInfo TaskInfo { get; set; }
        public virtual ICollection<File> Files { get; set; }

    }

    public class AchievementBContext : DbContext
    {
        public DbSet<Achievement> Achievements { get; set; }
    }

    // Define a class contains two value for status attribute
    public enum AchievmentStatus
    {
        
        Approved = 1,
        notApproved = 0
    }
}