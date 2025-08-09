using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBindingsApp
{
    public class TagLabel : Label
    {
        public static readonly BindableProperty TagProperty =
            BindableProperty.Create("Tag",
                                    typeof(string),
                                    typeof(TagLabel),
                                    "");
        public string Tag
        {
            get => (string)GetValue(TagProperty);
            set => SetValue(TagProperty, value);
        }
    }
}
