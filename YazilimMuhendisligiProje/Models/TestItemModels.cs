using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ibrahimekinci.Plugin.CustomAttributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ibrahimekinci.Plugin.Localization.Public;

namespace YazilimMuhendisligiProje.Models
{
    public class TestItemModels
    {
        [Key]
        public int Id { get; set; }
        public int Index { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelQuestion"), CustomRequired, CustomMinLength(2), CustomMaxLength(1000)]
        public string Question { get; set; }

        [Display(ResourceType = typeof(Lang), Name = "LabelOption"), CustomRequired, CustomMinLength(2), CustomMaxLength(1000)]
        public string OptionA { get; set; }

        [Display(ResourceType = typeof(Lang), Name = "LabelOption"), CustomRequired, CustomMinLength(2), CustomMaxLength(1000)]
        public string OptionB { get; set; }

        [Display(ResourceType = typeof(Lang), Name = "LabelOption"), CustomRequired, CustomMinLength(2), CustomMaxLength(1000)]
        public string OptionC { get; set; }

        [Display(ResourceType = typeof(Lang), Name = "LabelOption"), CustomRequired, CustomMinLength(2), CustomMaxLength(1000)]
        public string OptionD { get; set; }
    }
}