using System.ComponentModel.DataAnnotations;
using ibrahimekinci.Plugin.Localization.Public;

namespace ibrahimekinci.Plugin.CustomAttributes
{
    public class CustomMaxLengthAttribute : MaxLengthAttribute
    {
        public CustomMaxLengthAttribute(int length) : base(length)
        {
            ErrorMessageResourceType = typeof(Lang);
            ErrorMessageResourceName = "Warning_MaxLenght";
        }
    }
}
