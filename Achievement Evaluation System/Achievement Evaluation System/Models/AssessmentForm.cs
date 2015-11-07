using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Achievement_Evaluation_System.Models
{
    public class AssessmentForm
    {
        // AssessmentForm ID
        [Display(Name = "Assessment Form ID")]
        public int ID { get; set; }

        //Assessment Form name
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        [Display(Name = "Assessment Form Name")]
        public string Assessment_form_name { get; set; }

        //Assessment Form Data

        public XmlSiteMapProvider Assessment_form_data { get; set; } /*--------------Change according to note---------------*/ 

    }

    public class AssessmentFormDBContext : DbContext
    {
        public DbSet<AssessmentForm> AssessmentForms { get; set; }
    }
}