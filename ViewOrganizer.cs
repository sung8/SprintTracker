﻿using SprintTrackerBasic.Builder;
using SprintTrackerBasic.Tasks;
using SprintTrackerBasic.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintTrackerBasic
{
    public class ViewOrganizer
    {
        private List<Users.Team> teams = new List<Users.Team>();
        private List<Users.TeamMember> assigned = new List<Users.TeamMember>();
        private static ViewOrganizer instance = new ViewOrganizer();

        private ViewOrganizer() { }


        public static ViewOrganizer GetInstance()
        {
            return instance;
        } 

        public List<Users.Team> GetTeams()
        {
            return teams;
        }

        /*
        private string taskName = "";
        private DateTime dueDate;
        private string desc ="";
        private List<Users.TeamMember> assigned = new List<Users.TeamMember>();
        private List<TaskAbs> subTask = new List<TaskAbs>();
        */
        public TaskAbs ParseData(string tn, DateTime dd, string d, List<TeamMember> a, List<TaskAbs> ta)
        {

            if(ta.Count == 0)
            {
                TaskBuilderIF tb = AbsTaskBuilder.GetTaskBuilder("task");
                var task = tb
                 .SetTaskName(tn)
                 .SetDueDate(dd)
                 .SetDescription(d)
                 .Build();
                return task;
            }
            else
            {
                TaskBuilderIF tb = AbsTaskBuilder.GetTaskBuilder("composite");
                var task = tb
                 .SetTaskName(tn)
                 .SetDueDate(dd)
                 .SetDescription(d)
                 .Build();
                return task;
            }
        }

    }
}
