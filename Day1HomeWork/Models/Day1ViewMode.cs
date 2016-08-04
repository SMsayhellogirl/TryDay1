using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day1HomeWork.Models
{
    public class Day1ViewMode
    {
        public int Dno { get; set; }

        [Display(Name = "類別")]
        public string Dtype { get; set; }

        [Display(Name = "金額")]
        public string Dmoney { get; set; }

        [Display(Name = "日期")]
        public string Dday { get; set; }

        [Display(Name = "備註")]
        public string Dnote { get; set; }
    }
}