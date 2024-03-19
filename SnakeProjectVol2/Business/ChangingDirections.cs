using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeGameSpace.Business;

namespace SnakeProjectVol2.Business
{
    internal class ChangingDirections : Attribute
    {
        public Directions[] directions { get; private set; }

        public ChangingDirections(Directions[] name)
        {
            this.directions = name;
        }
    }
}

public static class EnumAttributes
{
    public static TAttribute GetAttribute<TAttribute>(this Enum value) where TAttribute : Attribute
    {
        var enumType = value.GetType();
        var name = Enum.GetName(enumType, value);
        return enumType.GetField(name).GetCustomAttributes(false).OfType<TAttribute>().SingleOrDefault();
    }
}