﻿using Abp.Domain.Repositories;
using SeaBlog.BlogEntitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Repositories
{
    public interface ICategoryRepository : IRepository<Category, Guid>
    {
    }
}
