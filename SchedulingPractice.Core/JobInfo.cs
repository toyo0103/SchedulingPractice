﻿using System;

namespace SchedulingPractice.Core
{
    public class JobInfo
    {
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime RunAt { get; set; }
        public DateTime? ExecuteAt { get; set; }

        public int State { get; set; }
    }

    public enum JobStateEnum : int
    {
        CREATE = 0,
        LOCK = 1,
        COMPLETE = 2
    }
}
