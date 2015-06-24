﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data.Items;
using Sitecore.Layouts;
using SitecoreContentEditorTabs.Interfaces;
using SitecoreContentEditorTabs.Models;

namespace SitecoreContentEditorTabs.Mappers
{
    public class ComponentMapper : IComponentMapper
    {
        public Component MapToComponent(RenderingReference renderingReference, Item datasource, Item device)
        {
            return MapToComponent(renderingReference, datasource, null, null, device);
        }

        public Component MapToComponent(RenderingReference renderingReference, Item datasource, bool? standardValueRendering, bool? standardValueDatasource,
            Item device)
        {
            var component = new Models.Component()
            {
                Id = renderingReference.UniqueId,
                ComponentName = renderingReference.RenderingItem.Name,
                Placeholder = renderingReference.Placeholder,
                IsPersonalised = renderingReference.Settings.Rules.Count > 0,
                Device = device.DisplayName,
                StandardValue = standardValueRendering.HasValue && standardValueRendering.Value
            };

            if (datasource != null)
            {
                component.DatasourceId = datasource.ID.ToGuid();
                component.DatasourceLink = datasource.Paths.FullPath;
                component.DatasourceName = datasource.Name;
                component.DatasourceIsStandardValue = standardValueDatasource.HasValue && standardValueDatasource.Value;
            }

            return component;
        }
    }
}
