using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Achievement_Evaluation_System.Models
{
    public class Complaint
    {
        //Complatnt ID
        [Display(Name = "Complaint ID")]
        public int ID { get; set; }

        //Complaint Description
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(1000)]
        [DataType(DataType.Text)]
        [Display(Name = "Complaint Description")]
        public string Complaint_description { get; set; }

        //Complaint Status
        [Required(ErrorMessage = "This field is required.")]
        [Display(Name = "Complaint Status")]
        public int Complaint_status { get; set; }
        /* -----------------------------What status are needed there?!------------------------------- */

        //Forgien Keys

        // Employee Foreign key
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }

        // Task Foreign Key
        [Display(Name = "Assessment Complained on ID")]
        [ForeignKey("AssessmentForm")]
        public int AssessmentFormID { get; set; }

        //Relations
        public virtual Employee Employee { get; set; }
        public virtual AssessmentForm AssessmentForm { get; set; }
    }

    public class ComplaintDBContext : DbContext
    {
        public DbSet<Complaint> Complaints { get; set; }
    }
}