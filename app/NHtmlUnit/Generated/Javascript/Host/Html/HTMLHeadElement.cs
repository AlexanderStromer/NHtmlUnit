// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLHeadElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLHeadElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHeadElement o) =>
            new HTMLHeadElement(o));
      }

      public HTMLHeadElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHeadElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHeadElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHeadElement)WrappedObject; }
      }

      public HTMLHeadElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHeadElement()) {}

   }


}
