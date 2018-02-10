using CheckBoxList.Core.Factory;
using CheckBoxList.Core.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;

namespace CheckBoxList.Core.TagHelpers
{
    public class CheckBoxListTagHelper : TagHelper
    {
        public string Name { get; set; }
        public List<CheckBoxItem> Items { get; set; }
        public TemplateType Template { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (Items == null)
            {
                throw new Exception("item property of checkbox-list cannot be null");
            }

            if (String.IsNullOrEmpty(Name))
            {
                throw new Exception("name property of checkbox-list cannot be null or empty");
            }

            output.TagName = string.Empty;
            var templateGenerator = TemplateGeneratorFactory.GetTemplateGenerator(Template);
            var template = templateGenerator.Generate(Name, Items);
            output.Content.SetHtmlContent(template);
        }
    }
}
