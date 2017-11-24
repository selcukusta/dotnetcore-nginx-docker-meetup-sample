using app.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace app.CustomTagHelpers
{

    public class EmailTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";    // Replaces <email> with <a> tag
        }
    }
}