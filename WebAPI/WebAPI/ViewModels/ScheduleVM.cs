﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;

namespace WebAPI.ViewModels
{
    public class ScheduleVM
    {
        public int? GameNumber { get; set; }
        public int? Round { get; set; }
        public DateTime? Date { get; set; }
        public string? Time { get; set; }
        public string Season { get; set; }
        public int? HomePoints { get; set; }
        public int? AwayPoints { get; set; }
        public StaticData.GameTypeEnum GamePhase { get; set; }
        public sbyte Status { get; set; }
        public DateTime Timestamp { get; set; }
        public Guid? HomeClubId { get; set; }
        public Guid? AwayClubId { get; set; }

        public string? HomeClubName { get; set; }
        public string? AwayClubName { get; set; }
    }
}
