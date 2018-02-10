using CheckBoxList.Core.Models;
using System.Collections.Generic;

namespace CheckBoxList.Core.Templates
{
    /// <summary>
    /// Interface for classes capable of creating template generators
    /// </summary>
    public interface ITemplateGenerator
    {
        /// <summary>
        /// Creates template generators
        /// </summary>
        /// <param name="name">name attribute used for checkbox input type</param>
        /// <param name="items">items used to build checkbox input list</param>
        /// <returns></returns>
        string Generate(string name, List<CheckBoxItem> items);
    }
}
