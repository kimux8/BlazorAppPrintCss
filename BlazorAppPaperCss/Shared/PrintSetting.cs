using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppPaperCss.Shared
{
    public class PrintSetting
    {
        public string PageSize { get; set; } = "A4";
        public string IsLandscape { get; set; } = "false";
        public string Padding { get; set; } = "padding-10mm";
        public string Multiple { get; set; } = "1";
        public string AutoPrint { get; set; } = "Yes";
    }
}
