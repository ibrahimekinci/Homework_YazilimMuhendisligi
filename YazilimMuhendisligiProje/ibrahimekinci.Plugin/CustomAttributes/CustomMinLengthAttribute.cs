using System.ComponentModel.DataAnnotations;
using ibrahimekinci.Plugin.Localization.Public;

namespace ibrahimekinci.Plugin.CustomAttributes
{
    public class CustomMinLengthAttribute : MinLengthAttribute
    {
        public CustomMinLengthAttribute(int length) : base(length)
        {
            ErrorMessageResourceType = typeof(Lang);
            ErrorMessageResourceName = "Warning_MinLenght";
        }
    }
}
