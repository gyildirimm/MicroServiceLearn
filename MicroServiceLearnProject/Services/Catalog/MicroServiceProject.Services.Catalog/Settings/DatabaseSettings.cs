﻿using MicroServiceProject.Services.Catalog.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceProject.Services.Catalog.Settings
{
    internal class DatabaseSettings : IDatabaseSettings
    {
        public string CourseCollectionName { get; set; }

        public string CategoryCollectionName { get; set; }

        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }
}
