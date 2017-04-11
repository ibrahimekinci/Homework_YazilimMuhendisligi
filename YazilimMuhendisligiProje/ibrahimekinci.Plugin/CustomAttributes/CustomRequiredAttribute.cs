using System.ComponentModel.DataAnnotations;
using ibrahimekinci.Plugin.Localization.Public;

namespace ibrahimekinci.Plugin.CustomAttributes
{
    public class CustomRequiredAttribute : RequiredAttribute
    {
        public CustomRequiredAttribute()
        {
            ErrorMessageResourceType = typeof(Lang);
            ErrorMessageResourceName = "Warning_FieldRequired";
        }
    }
}
