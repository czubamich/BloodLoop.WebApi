﻿using BloodCore.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodLoop.Domain.Donations
{
    public class DonationTypeId : Identity<DonationTypeId>
    {
        public DonationTypeId(Guid id) : base(id) { }
    }
}
