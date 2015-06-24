﻿using System;

namespace SitecoreContentEditorTabs.Models
{
    public class Component : Sitecore.Services.Core.Model.EntityIdentity
    {
        public string itemId
        {
            get { return Id; }
        }

        public string ComponentName { get; set; }

        public string DatasourceName { get; set; }

        public Guid DatasourceId { get; set; }

        public string DatasourceLink { get; set; }

        public string Placeholder { get; set; }

        public bool IsPersonalised { get; set; }

        public string Device { get; set; }

        public bool StandardValue { get; set; }

        public bool DatasourceIsStandardValue { get; set; }
    }
}