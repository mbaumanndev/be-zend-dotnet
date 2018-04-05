using System;
using System.Collections.Generic;
using System.Text;
using MBaumann.ConfNet.WebMvc.ViewModels;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MBaumann.ConfNet.WebMvc.TagHelpers
{
    [HtmlTargetElement("carousel", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class CarouselTagHelper : TagHelper
    {
        public List<CarouselItem> Slides { get; set; }

        public int Interval { get; set; }

        public string Id { get; set; }

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
            if (String.IsNullOrWhiteSpace(Id))
                throw new ApplicationException("Carousel Id cannot be null or empty");

            if (Slides == null)
                throw new ApplicationException("Carousel slides list cannot be null or empty");

            if (Interval < 2000)
                throw new ApplicationException("Carousel interval must be at least of 2 seconds");

            StringBuilder v_indicators = null;
            StringBuilder v_slides = null;

            try
            {
                v_indicators = new StringBuilder("<ol class=\"carousel-indicators\">");
                v_slides = new StringBuilder("<div class=\"carousel-inner\" role=\"listbox\">");

                output.TagName = "div";
                output.TagMode = TagMode.StartTagAndEndTag;

                output.Attributes.SetAttribute("id", Id);
                output.Attributes.SetAttribute("class", "carousel slide");
                output.Attributes.SetAttribute("data-ride", "carousel");
                output.Attributes.SetAttribute("data-interval", Interval);

                for (int i = 0; i < Slides.Count; i++) {
                    CarouselItem v_item = Slides[i];

                    v_indicators.AppendFormat("<li data-target=\"#{0}\" data-slide-to=\"{1}\" class=\"{2}\"></li>", Id, i, i == 0 ? "active" : String.Empty);
                    v_slides.AppendFormat(@"<div class=""item {0}"">
                        <img src=""{1}"" alt=""{2}"" class=""img-responsive"" />
                        <div class=""carousel-caption"" role=""option"">
                            <p>
                                {3}
                                <a class=""btn btn-default"" href=""{4}"">
                                    {5}
                                </a>
                            </p>
                        </div>
                    </div>", i == 0 ? "active" : String.Empty, v_item.Image, v_item.ImageAltText, v_item.Caption, v_item.CaptionLink, v_item.CaptionLinkLabel);
                }

                v_indicators.Append("</ol>");
                v_slides.Append("</div>");

                output.Content.AppendHtml(v_indicators.ToString());
                output.Content.AppendHtml(v_slides.ToString());

                output.Content.AppendHtml(String.Format(@"<a class=""left carousel-control"" href=""#{0}"" role=""button"" data-slide=""prev"">
                    <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""right carousel-control"" href=""#{0}"" role=""button"" data-slide=""next"">
                    <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>", Id));

            }
            finally
            {

            }
		}
	}
}
