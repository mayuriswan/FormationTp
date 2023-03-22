using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Formation.Pages.Tags
{
    [HtmlTargetElement("my-custom-tag")]
    public class MyTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {


            output.TagName = "div";
            output.Attributes.SetAttribute("class", "my-custom-class");

        }
    }

}



