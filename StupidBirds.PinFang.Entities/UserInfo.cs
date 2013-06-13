using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StupidBirds.PinFang.Entities
{
    [DBTableName]
    public class UserInfo
    {
        int ID { get; set; }
        string Name { get; set; }
        int Gender { get; set; }
        string Adress { get; set; }
    }
}
