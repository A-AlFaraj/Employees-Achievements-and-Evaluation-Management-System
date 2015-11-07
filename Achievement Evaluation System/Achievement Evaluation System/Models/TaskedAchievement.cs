using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Achievement_Evaluation_System.Models
{
    public class TaskedAchievement
    {
        public int ID { get; set; }
        public string Task_name{ get; set; }
        public string Task_description { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Task_dude_date { get; set; }
        public int Task_status { get; set; }
        public string User_comment { get; set; }
        
        //ADD FORIGEN KEYS?
        

    }

    public class TaskedAchievementDBContext : DbContext
    {
        public DbSet<TaskedAchievement> TaskedAchievements { get; set; }
    }
}