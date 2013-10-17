﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Umbraco.Core.Models.PublishedContent;

namespace Umbraco.Core.PropertyEditors.ValueConverters
{
    [PropertyValueType(typeof(string))]
    [PropertyValueCache(PropertyCacheValue.All, PropertyCacheLevel.Content)]
    public class TextStringValueConverter : PropertyValueConverterBase
    {
        public override bool IsConverter(PublishedPropertyType propertyType)
        {
            return Guid.Parse(Constants.PropertyEditors.Textbox).Equals(propertyType.PropertyEditorGuid);
        }

        public override object ConvertDataToSource(PublishedPropertyType propertyType, object source, bool preview)
        {
            // in xml a string is: string
            // in the database a string is: string
            // default value is: null
            return source;
        }

        public override object ConvertSourceToObject(PublishedPropertyType propertyType, object source, bool preview)
        {
            // source should come from ConvertSource and be a string (or null) already
            return source ?? string.Empty;
        }

        public override object ConvertSourceToXPath(PublishedPropertyType propertyType, object source, bool preview)
        {
            // source should come from ConvertSource and be a string (or null) already
            return source;
        }
    }
}