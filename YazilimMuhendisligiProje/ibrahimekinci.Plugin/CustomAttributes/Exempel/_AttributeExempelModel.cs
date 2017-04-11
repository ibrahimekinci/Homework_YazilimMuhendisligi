//using System;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
// 
//using System.Collections.Generic;

//namespace ibrahimekinci.Data.Code
//{
//    [Table("TableName")]
//    class _AttributeExempelModel
//    {
//        //    [Table("TableName", "Foo")]
//        //ColumnAttribute
//        //    ComplexTypeAttribute
//        //    DatabaseGeneratedAttribute
//        //    ForeignKeyAttribute
//        //    InversePropertyAttribute
//        //    NotMappedAttribute
//        //    TableAttribute
//        [Display(ResourceType = typeof(Lang), Name = "FirstName")]
//        [Required(ErrorMessageResourceName = "Warning_FieldRequired", ErrorMessageResourceType = typeof(Lang))]
//        [MinLength(2, ErrorMessageResourceType = typeof(Lang), ErrorMessageResourceName = "Warning_MinLenght")]
//        [MaxLength(5, ErrorMessageResourceName = "Warning_MaxLenght", ErrorMessageResourceType = typeof(Lang))]
//        public string MyProperty { get; set; }

//        [Display(ResourceType = typeof(Lang), Name = "FirstName")]
//        [CustomRequired()]
//        [CustomMaxLength(5)]
//        [CustomMinLength(2)]
//        [DataType(DataType.EmailAddress)]
//        [DefaultValue("sNameasd@hotmail.com")]
//        public string MyProperty2 { get; set; }

//        [Range(1, 100), DataType(DataType.Currency)]
//        [CustomLength(5)] //alan 5 karakterden oluşmalı
//        [CustomRequired()]
//        public string MyProperty5 { get; set; }

//        [CustomLength(0, 6)] //alan en az 0 en çok 6 karakterden oluşmalı
//        [CustomRequired()]
//        public string MyProperty6 { get; set; }
//        [ScaffoldColumn(false)]//veri tabanına ekleme
//        [Required(ErrorMessage = "An Album Title is required")]
//        [StringLength(160)]
//        [DisplayName("ad")]
//        [Range(0.01, 100.00, ErrorMessage = "Price must be between 0.01 and 100.00")]
//        public int MyProperty3 { get; set; }


//        [Key]
//        [ForeignKey("table")]
//        [Display(Name = "")]
//        [Required(ErrorMessage = " alanı boş geçilemez.")]
//        [StringLength(50, ErrorMessage = " alanına en az {2} en çok {0} karakter girilebilir.", MinimumLength = 1)]
//        [ScaffoldColumn(false)]
//        public int MyProperty4 { get; set; }

//        [DatabaseGenerated(DatabaseGeneratedOption.None)] //manuel primary key girişi otomatik artması önlenir
//        [Column(Order = 0)]
//        public int MyProperty7 { get; set; }


//        public string Sifre { get; set; }

//        [Compare("Sifre")]
//        public string SifreTekrar { get; set; }

//        [Required(ErrorMessage = "Lütfen eposta alanını doldurunuz..")]
//        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Lütfen doğru bir eposta  giriniz..")]
//        [Display(Name = "E-Posta")]
//        public string eposta { get; set; }

//        [DefaultValue("true")]
//        public bool Active { get; set; }

//        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
//        [DefaultValue("getutcdate()")]
//        public DateTime CreatedOn { get; set; }

//        [Column(TypeName = "datetime2")]
//        [System.Xml.Serialization.XmlAttribute]
//        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
//        [Display(Name = "Date Modified")]
//        public DateTime DateModified
//        {
//            get { return dateModified; }
//            set { dateModified = value; }
//        }
//        private DateTime dateModified = DateTime.Now.ToUniversalTime();


//        //[Range('01/01/2000','01/01/2010',ErrorMessage ="")]
//        [CustomRequired()]
//        [Display(ResourceType = typeof(Lang), Name = "LabelStartDate")]
//        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss}", ApplyFormatInEditMode = true)]
//        public DateTime StartDate { get; set; }
//        [CustomRequired()]
//        [Display(ResourceType = typeof(Lang), Name = "LabelEndDate")]
//        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss}", ApplyFormatInEditMode = true)]
//        public DateTime EndDate { get; set; }

//        [ForeignKey("UserId")]
//        public virtual _AttributeExempelModel Id { get; set; }
//        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("MenuItemID")]

//        public virtual ICollection<_AttributeExempelModel> kitap { get; set; }
//    }
//}
