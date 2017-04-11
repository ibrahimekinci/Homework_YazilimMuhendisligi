//using System;
//using System.Reflection;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//namespace ibrahimekinci.Data.Code.CustomAttributes
//{
//    //public class CustomDisplayAttribute:DisplayNameAttribute 
//    //{

//    //}
//    public class CustomRequiredAttribute : RequiredAttribute
//    {
//        public CustomRequiredAttribute()
//        {
//            this.ErrorMessageResourceType = typeof(Lang);
//            this.ErrorMessageResourceName = "Warning_FieldRequired";
//        }
//    }
//    public class CustomMinLengthAttribute : MinLengthAttribute
//    {
//        public CustomMinLengthAttribute(int Length) : base(Length)
//        {
//            this.ErrorMessageResourceType = typeof(Lang);
//            this.ErrorMessageResourceName = "Warning_MinLenght";
//        }
//    }
//    public class CustomMaxLengthAttribute : MaxLengthAttribute
//    {
//        public CustomMaxLengthAttribute(int Length) : base(Length)
//        {
//            this.ErrorMessageResourceType = typeof(Lang);
//            this.ErrorMessageResourceName = "Warning_MaxLenght";
//        }
//    }
//    public class CustomLengthAttribute : StringLengthAttribute
//    {
//        public CustomLengthAttribute(int Length) : base(Length)
//        {
//            //Length varsayılan olarak max length eşittir.
//            this.MinimumLength = MaximumLength;
//            this.ErrorMessageResourceType = typeof(Lang);
//            this.ErrorMessageResourceName = "Warning_LenghtLimit";
//        }
//        public CustomLengthAttribute(int MinimumLength,int MaximumLength) : base(MaximumLength)
//        {
//            this.MinimumLength = MinimumLength;
//            this.ErrorMessageResourceType = typeof(Lang);
//            this.ErrorMessageResourceName = "Warning_Interval";
//        }
//    }
//    //public class CustomDisplayNameAttribute : DisplayNameAttribute
//    //{
//    //    private PropertyInfo _nameProperty;
//    //    private Type _resourceType;

//    //    public CustomDisplayNameAttribute(string displayNameKey)
//    //        : base(displayNameKey)
//    //    { }

//    //    public Type NameResourceType
//    //    {
//    //        get { return _resourceType; }
//    //        set
//    //        {
//    //            _resourceType = value;
//    //            //initialize nameProperty when type property is provided by setter  
//    //            _nameProperty = _resourceType.GetProperty(base.DisplayName, BindingFlags.Static | BindingFlags.Public);
//    //        }
//    //    }
//    //    public override string DisplayName
//    //    {
//    //        get
//    //        {
//    //            //check if nameProperty is null and return original display name value  
//    //            if (_nameProperty == null) { return base.DisplayName; }
//    //            return (string)_nameProperty.GetValue(_nameProperty.DeclaringType, null);
//    //        }
//    //    }
//    //}
//}
