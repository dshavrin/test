﻿using InfinniPlatform.DesignControls.Layout;
using InfinniPlatform.Sdk.Dynamic;

namespace InfinniPlatform.DesignControls.DesignerSurface
{
    public sealed class ParameterObject : ILayoutProvider
    {
        public string ParameterName
        {
            get { return Parameter != null ? ObjectHelper.GetProperty(Parameter, "Name") : string.Empty; }
        }

        public dynamic Parameter { get; set; }

        public string ParameterSourceString
        {
            get { return Parameter != null ? Parameter.ToString() : string.Empty; }
        }

        public dynamic GetLayout()
        {
            var layoutProvider = Parameter as ILayoutProvider;
            if (layoutProvider != null)
            {
                return layoutProvider.GetLayout();
            }
            return new DynamicWrapper();
        }

        public void SetLayout(dynamic value)
        {
        }

        public string GetPropertyName()
        {
            var layoutProvider = Parameter as ILayoutProvider;
            if (layoutProvider != null)
            {
                return layoutProvider.GetPropertyName();
            }
            return string.Empty;
        }
    }
}