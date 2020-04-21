﻿using System;
using System.Collections.Generic;

namespace BlazorBoilerplate.Shared.Dto.Tenant
{
    public class TenantDto
    {
        public string Id { get; set; }
        public string Identifier { get; set; }
        public string Name { get; set; }
        public IDictionary<string, object> Items { get; }
        public string ConnectionString { get; set; }
    }
}