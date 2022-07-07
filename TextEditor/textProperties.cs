using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

interface ITextProperties
{
    Color fontColor { get; set; }
    Color backColor { get; set; }
    Size formSize { get; set; }
    Point formLocation { get; set; }
    string text { get; set; }
    string font { get; set; }
    string title { get; set; }
}

namespace TextEditor
{
    [Serializable]
    public class textProperties : ITextProperties
    {
        public string title { get; set; }
        public Color fontColor { get; set; }
        public Color backColor { get; set; }
        public Size formSize { get; set; }
        public Point formLocation { get; set; }
        public string text { get; set; }
        public string font { get; set; }
        public textProperties() {}

        public String toString()
        {
            return title + text + font +
                 formSize.ToString() + backColor.ToString() + fontColor.ToString();
        }
    }
}
