using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Achievement_Evaluation_System.Models
{
    public class File
    {
// Original Model Attributes
        // File ID
        public int ID { get; set; }

        // File Name
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(50)]
        [DataType(DataType.Text)]
        [Display(Name = "File Name")]
        public string File_name { get; set; }

        // File Created Date
        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy:mm:dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "File Created Date")]
        public DateTime File_created_date { get; set; }

        //Missing file data variable?

// Foreign keys Attributes
        // Achievement Foreign Key
        [ForeignKey("Achievement")]
        public int AchievementID { get; set; }

        // Task Foreign Key
        [ForeignKey("TaskInfo")]
        public int TaskInfoID { get; set; }

// Relations
        public virtual Achievement Achievement { get; set; }
        public virtual TaskInfo TaskInfo { get; set; }


    }
   
    public class FileFormDBContext : DbContext
    {
        public DbSet<File> Files { get; set; }
    }
}