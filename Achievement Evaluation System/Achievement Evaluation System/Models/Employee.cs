using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Achievement_Evaluation_System.Models
{
    public class Employee
    {
        // Employee ID
        [Display(Name = "Employee ID")]
        public int ID { get; set; }

        //Employee National ID
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(10)]
        [DataType(DataType.Text)]
        [Display(Name = "National ID")]
        public string National_ID { get; set; }
        
        //Sex Type
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(10)]
        [DataType(DataType.Text)]
        [Display(Name = "Sex")]
        public string Sex { get; set; }

        //First Name
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(50)]
        [DataType(DataType.Text)]
        [Display(Name = "First name")]
        public string Fname { get; set; }

        //Middle Name
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(50)]
        [DataType(DataType.Text)]
        [Display(Name = "Middle name")]
        public string Mname { get; set; }

        //Last Name
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(50)]
        [DataType(DataType.Text)]
        [Display(Name = "Last name")]
        public string Lname { get; set; }

        //Mobile Number
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(50)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Mobile Number")]
        public string Mobile_number { get; set; }

        //Birth date
        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy:mm:dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birth Date")]
        public DateTime Birth_date { get; set; }

        //Address
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(500)]
        [DataType(DataType.Text)]
        [Display(Name = "Address")]
        public string Address { get; set; }
        
        // Job Position
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(50)]
        [DataType(DataType.Text)]
        [Display(Name = "Job Position")]
        public string Job_position { get; set; }

        //Booleans to check prevliges 
        [Display(Name = "Is General Manager")]
        public Boolean Is_general_manager { get; set; }

        [Display(Name = "Is Manager")]
        public Boolean Is_manager { get; set; }

        [Display(Name = "Is Supervisor")]
        public Boolean Is_supervisor { get; set; }

        //Forigen Keys
        // Department Foreign Key
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        // Team Foreign Key
        [ForeignKey("Team")]
        public int TeamID { get; set; }

        //Relations
        public virtual Department Department { get; set; }
        public virtual Team Team { get; set; }
    }

    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}