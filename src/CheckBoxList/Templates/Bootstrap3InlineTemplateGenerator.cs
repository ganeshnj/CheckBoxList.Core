using CheckBoxList.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckBoxList.Core.Templates
{
    /// <summary>
    /// Template generator that generates inline check box list markup using Bootstrap 3
    /// </summary>
    internal class Bootstrap3InlineTemplateGenerator : ITemplateGenerator
    {
        public string Generate(string name, List<CheckBoxItem> items)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < items.Count; i++)
            {
                string checkedValue = items[i].IsChecked ? "checked" : string.Empty;
                string disabledValue = items[i].IsDisabled ? "disabled" : string.Empty;
                string nameValue = name + $"[{i}]";
                string disabledClass = items[i].IsDisabled ? " disabled" : string.Empty;

                stringBuilder.Append(
                    $"<label class=\"checkbox-inline{disabledClass}\" for=\"{nameValue}\">" +
                        $"<input name=\"{nameValue}\" value=\"{items[i].Id}\" type =\"checkbox\" id=\"{nameValue}\" {checkedValue} {disabledValue}> {items[i].Title}" +
                    "</label>"
                );
            }

            return stringBuilder.ToString();
        }
    }
}
