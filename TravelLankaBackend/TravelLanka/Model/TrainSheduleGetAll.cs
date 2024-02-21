﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelLanka.Model
{
    public class TrainSheduleGetAllResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public List<TrainSheduleInsertRequest> data { get; set; }
    }
}
