using System;
using System.Collections.Generic;

namespace TimeTracker.Models
{
    public partial class ToDo
    {
        public int Id { get; set; }
        public bool IsCompleted { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> MinutesSpent { get; set; }
        public int Priority { get; set; }
    }
}
