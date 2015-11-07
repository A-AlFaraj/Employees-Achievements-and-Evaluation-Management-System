using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Achievement_Evaluation_System.Models
{
    public class Team
    {
        //Team ID
        [Display(Name = "Team ID" )]
        public int ID { get; set; }

        //Team Name
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        [Display(Name = "Team Name")]
        public string Team_name { get; set; }
        
        //Team Type
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        [Display(Name = "Team Type")]
        public string Team_type { get; set; }

        //Team Description
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(1000)]
        [DataType(DataType.Text)]
        [Display(Name = "Team Description")]
        public string Team_description { get; set; }

        //Forgien Keys

        //Team Supervisor ID 
        [ForeignKey("Employee")]
        public int SupervisorID { get; set; }

        //Team Leader ID  (Don't we need if-statement\Valdition to check for supervisor & Team Leader IDs???)
        [ForeignKey("Employee")]
         public int LeaderID { get; set; }

        //Team leader Name


        //Deparment ID
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        //Team Employees
        public List<Employee> Team_employee_list { get; set; }



        //Relations
        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Employee> Employees{ get; set; }

    }

    public class TeamDBContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
    }
}