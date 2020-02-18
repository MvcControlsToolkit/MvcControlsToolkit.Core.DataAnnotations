using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcControlsToolkit.Core.DataAnnotations
{
    public class NestedPropertyNotAllowedException: WrongPropertyNameException
    {
        
        public NestedPropertyNotAllowedException(string propertyName) : base(propertyName)
        {
    
        }
        public override string Message
        {
            get
            {
                return string.Format(Resources.NestedPropertyNotAllowed, PropertyName);
            }
        }
    }
}
