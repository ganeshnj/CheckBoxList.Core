using CheckBoxList.Core.Models;
using CheckBoxList.Core.Templates;

namespace CheckBoxList.Core.Factory
{
    /// <summary>
    /// Factory class used to generate Template generator
    /// </summary>
    internal static class TemplateGeneratorFactory
    {

        /// <summary>
        /// Returns template generator for template type
        /// </summary>
        /// <param name="templateType">Template type</param>
        /// <returns>Template Generator for template type</returns>
        internal static ITemplateGenerator GetTemplateGenerator(TemplateType templateType)
        {
            switch(templateType)
            {
                case TemplateType.Bootstrap3Basic:
                    return new Bootstrap3BasicTemplateGenerator();
                case TemplateType.Bootstrap3Inline:
                    return new Bootstrap3InlineTemplateGenerator();
                default:
                    return new BasicTemplateGenerator();
            }
        }
    }
}
