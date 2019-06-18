﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Categorys.Dto
{
    public class CategoryDetailOutput : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public int Count { get; set; }
    }
}
