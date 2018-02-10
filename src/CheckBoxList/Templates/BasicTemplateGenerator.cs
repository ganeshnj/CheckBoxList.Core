using CheckBoxList.Core.Models;
using System.Collections.Generic;
using System.Text;

namespace CheckBoxList.Core.Templates
{ 
    /// <summary>
    /// Basic template generator class used to generate basic HTML markup
    /// <inpu>
    /// </summary>
    internal class BasicTemplateGenerator : ITemplateGenerator
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
                    $"<label class=\"checkbox{disabledClass}\" for=\"{nameValue}\">" +
                        $"<input name=\"{nameValue}\" value=\"{items[i].Id}\" type =\"checkbox\" id=\"{nameValue}\" {checkedValue} {disabledValue}>{items[i].Title}" +
                    $"</label>" +
                    $"<br>"
                );
            }

            return stringBuilder.ToString();
        }
    }
}
