using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ToDoSoulinthavong.Models
{
    public class SubmitButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.BuildTag("button", "btn btn-primary");
            output.Attributes.SetAttribute("type", "submit");
        }
    }
}
