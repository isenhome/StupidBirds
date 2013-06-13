using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StupidBirds.PinFang.Framwork
{
    public class Reflect
    {
    }

    [AttributeUsage(AttributeTargets.Field|AttributeTargets.Enum|AttributeTargets.Class)]
    public class DBTableName : Attribute
    { 
    
    }
}
