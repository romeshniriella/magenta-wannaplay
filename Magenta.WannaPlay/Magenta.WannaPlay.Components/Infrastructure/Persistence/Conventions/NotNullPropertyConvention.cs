﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Conventions;
using FluentNHibernate.Mapping;

namespace Magenta.WannaPlay.Infrastructure.Persistence.Conventions
{
    public class NotNullPropertyConvention : IPropertyConvention
    {
        #region IConvention<IProperty> Members

        public bool Accept(IProperty target)
        {
            return true;
        }

        public void Apply(IProperty target)
        {
            //TODO: think about cleaner way to mark nullable properties
            if(target.Property.Name != "Remarks")
                target.Not.Nullable();
        }

        #endregion
    }
}