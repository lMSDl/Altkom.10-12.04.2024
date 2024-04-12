using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.Visitor.I
{
    internal class HtmlVisitor : IVisitor
    {
        private StringBuilder StringBuilder { get; } = new StringBuilder();

        public void Visit(PlainText plainText)
        {
            StringBuilder.Append(plainText.Text);
        }

        public void Visit(BoldText boldText)
        {
            StringBuilder.Append($"<b>{boldText.Text}</b>");
        }

        public void Visit(Hyperlink link)
        {
            StringBuilder.Append($"<a href={link.Link}>{link.Text}</a>");
        }
        public override string ToString()
        {
            return StringBuilder.ToString();
        }
    }
}
