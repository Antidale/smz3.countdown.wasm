using smz3.countdown.wasm.Attributes;
using System.ComponentModel;

namespace smz3.countdown.wasm.Extenstions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum name)
        {
            var field = name.GetType().GetField(name.ToString());
            if (field == null)
            {
                return name.ToString();
            }

            var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return name.ToString();
        }

        public static bool IsMajor(this Enum name)
        {
            var field = name.GetType().GetField(name.ToString());
            if (field == null)
                return false;

            var attributes = (MajorAttribute[])field.GetCustomAttributes(typeof(MajorAttribute), false);
            if (attributes != null && attributes.Length > 0)
                return attributes[0].Major;
            else
                return false;
        }

        public static T GetAttribute<T>(this Enum name) where T : Attribute, new()
        {
            var field = name.GetType().GetField(name.ToString());
            if (field == null)
                return new T();

            var attributes = (T[])field.GetCustomAttributes(typeof(T), false);
            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0];
            }
            else
            {
                return new T();
            }
        }
    }
}
