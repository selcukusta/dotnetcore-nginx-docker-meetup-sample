using app.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace app.CustomTagHelpers
{
    [HtmlTargetElement("profile-information")]
    public class ProfileInformationTagHelper : TagHelper
    {
        public Member Info { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (string.IsNullOrWhiteSpace(Info.EMail))
            {
                output.SuppressOutput();
            }
            else
            {
                output.TagName = "section";
                output.TagMode = TagMode.StartTagAndEndTag;
                output.Content.SetHtmlContent
                    ($@"
                    <div class=""card"">
                        <img src=""{Info.ProfileImageUrl}"" alt=""{Info.UserName}"" style=""width:100%"">
                        <h1>{Info.UserName}</h1>
                        <p>{Info.EMail}</p>
                    </div>
                    ");
            }
        }
    }
}