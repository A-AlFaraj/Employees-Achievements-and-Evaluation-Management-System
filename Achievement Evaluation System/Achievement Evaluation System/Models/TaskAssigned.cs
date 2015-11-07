using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Achievement_Evaluation_System.Models
{
    public class TaskAssigned
    {

        // Task Assigned to Employee Table

        //Forigen Keys
        
        //Task Assigned ID
        [Key]
        [ForeignKey("TaskInfo")]
        public int TaskInfoID { get; set; }

        //Task Assigned To Employee ID (-------------(can be two foreign keys a primary key here?)--------------)
        [Key]
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }

        //Relations
        public virtual Employee Employee { get; set; }
        public virtual TaskInfo TaskInfo { get; set; }

        public class TaskAssignedBContext : DbContext
        {
            public DbSet<TaskAssigned> TaskAssigneds { get; set; }
        }

    }
}