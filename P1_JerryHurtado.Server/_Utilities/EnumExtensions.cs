using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace P1_JerryHurtado.Server._Utilities
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Retorna el valor del atributo Name del enum.
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns>string: Valor de atributo Name del enum</returns>
        public static string GetDisplayName(this Enum enumValue)
            => enumValue.GetType().GetMember(enumValue.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();

        /// <summary>
        /// Retorna una lista que contiene el valor númerico y el valor del atributo Name del enum.
        /// </summary>
        /// <param name="enumType">Type: tipo de enum</param>
        /// <returns>ArrayList: Listado de elementos del enum (EnumValue, EnumDescription).</returns>
        public static ArrayList GetSelectList(this Type enumType)
        {
            var enumValuesAndNameAttribute = new ArrayList();
            foreach (var e in Enum.GetValues(enumType))
            {
                enumValuesAndNameAttribute.Add(new
                {
                    EnumValue = (int)e,
                    EnumDescription = (e.GetType().GetMember(e.ToString()).FirstOrDefault()
                    .GetCustomAttributes(typeof(DisplayAttribute), inherit: false).FirstOrDefault()
                    as DisplayAttribute)?.GetName() ?? e.ToString()
                });
            }
            return enumValuesAndNameAttribute;
        }
    }
}