using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
  
    public static class EnumExtensions
    {
        // 1. Extension methods tillåter oss att lägga till nya metoder på befintliga klasser
        // utan att behöva ärva från dem eller ändra deras kod.

        // 2. Extension methods måste vara statiska och i en statisk klass.
        // Eftersom de inte är en del av klassen de utökar.

        // 3. "this" nyckelordet används för att ange vilken klass som ska utökas.
        // I detta fall är det en Enum.
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
