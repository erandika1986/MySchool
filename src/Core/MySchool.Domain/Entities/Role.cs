﻿using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class Role : BaseAuditEntity
    {
        public string Name { get; set; }
    }
}
