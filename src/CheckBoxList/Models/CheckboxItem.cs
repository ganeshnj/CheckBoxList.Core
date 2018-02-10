using System;
using System.Collections.Generic;
using System.Text;

namespace CheckBoxList.Core.Models
{
    /// <summary>
    /// Model class used to build the check box list
    /// </summary>
    public class CheckBoxItem
    {
        /// <summary>
        /// Used to indicate the value atribute of the checkbox input
        /// </summary>
        public object Id { get; set; }

        /// <summary>
        /// Used to indicate the title text of the checkbox input
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Used to set checked attribute of the checkbox input
        /// </summary>
        public bool IsChecked { get; set; }

        /// <summary>
        /// Used to set disabled attribute of the checkbox input
        /// </summary>
        public bool IsDisabled { get; set; }

        public CheckBoxItem(object id, string title, bool isChecked = false, bool isDisabled = false)
        {
            Id = id;
            Title = title;
            IsChecked = isChecked;
            IsDisabled = isDisabled;
        }
    }
}
