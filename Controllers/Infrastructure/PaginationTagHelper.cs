using System;
using Bookman.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Bookman.Controllers.Infrastructure
{


    [HtmlTargetElement("div", Attributes = "page-dynamic")]
    public class PaginationTagHelper : TagHelper
    {

        private IUrlHelperFactory uhf;

        public PaginationTagHelper(IUrlHelperFactory temp)
        {
            uhf = temp;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext vc { get; set; }

        // Different than ViewContext
        public PageInfo PageDynamic { get; set; }
        public string PageAction { get; set; }



        public override void Process(TagHelperContext thc, TagHelperOutput tho)
        {
            IUrlHelper uh = uhf.GetUrlHelper(vc);

            TagBuilder final = new TagBuilder("div");

            for (int i = 1; i <= PageDynamic.TotalPages; i++)
            {
                TagBuilder tb = new TagBuilder("a");

                tb.Attributes["href"] = uh.Action(PageAction, new { pageNum = i });
                tb.Attributes["style"] = "margin-right: 10px; margin-left: 10px;";
                tb.Attributes["class"] = "btn";
                tb.InnerHtml.Append(i.ToString());

                final.InnerHtml.AppendHtml(tb);

            }

            tho.Content.AppendHtml(final.InnerHtml);
        }
    }


}

