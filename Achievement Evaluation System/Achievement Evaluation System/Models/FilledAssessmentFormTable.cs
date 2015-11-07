using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Achievement_Evaluation_System.Models
{
    public class FilledAssessmentForm
    {
        
        // Filled Assessment Form ID
        [Display(Name = "Filled Assessment Form ID")]
        public int ID { get; set; }


        // Filled Assessment Form Information
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(1000)]
        [DataType(DataType.Text)]
        [Display(Name = "Filled Assessment Form Information")]
        public string Achievement_description { get; set; }

        //Forigen Keys

        //Assessment Form ID
        [ForeignKey("AssessmentForm")]
        public int AssessmentFormID { get; set; }

        // Filler ID
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }


        //Relations
        public virtual Employee Employee { get; set; }
        public virtual AssessmentForm AssessmentForm { get; set; }

        public class FilledAssessmentFormBContext : DbContext
        {
            public DbSet<FilledAssessmentForm> FilledAssessmentForm { get; set; }
        }

    }
}