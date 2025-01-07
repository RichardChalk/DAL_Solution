using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    public enum MenuOptions
    {
        [Description("Run Project 1")]
        RunProject1,
        [Description("Run Project 2")]
        RunProject2,
        Exit
    }
    public static class MyEnums
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            if (field == null)
            {
                // Detta borde egentligen aldrig hända om du arbetar med giltiga enums
                return value.ToString();
            }

            var attribute = field.GetCustomAttribute<DescriptionAttribute>();
            return attribute != null ? attribute.Description : value.ToString();
        }
    }
}
