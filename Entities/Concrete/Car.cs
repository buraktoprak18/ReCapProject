﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        
        public int CarID { get; set; }
        public string ModelYear { get; set; }
        public int BrandID { get; set; }
        public int ColorId { get; set; }
        public int ColorID { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
