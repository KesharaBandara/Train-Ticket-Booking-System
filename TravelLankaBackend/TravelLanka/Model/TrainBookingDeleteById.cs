﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelLanka.Model
{
    public class TrainBookingDeleteByIdRequest
    {
        [Required]
        public string ID { get; set; }
    }
    public class TrainBookingDeleteByIdResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
