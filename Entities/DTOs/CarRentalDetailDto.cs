﻿using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarRentalDetailDto : IDto
    {
        public int RentalId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColrName { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
