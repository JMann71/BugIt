﻿namespace aspnetserver
{
    public class Bug
    {
        public int BugId { get; set; }
        public int Creator { get; set; }
        public string TimeCreated { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string EstimatedTime { get; set; }
        public int Archived { get; set; }

        public Bug(int bugId, int creator, string timeCreated, string description, string type, string status, string priority, string estimatedTime, int archived = 0)
        {
            BugId = bugId;
            Creator = creator;
            TimeCreated = timeCreated;
            Description = description;
            Type = type;
            Status = status;
            Priority = priority;
            EstimatedTime = estimatedTime;
            Archived = archived;
        }
    }
}