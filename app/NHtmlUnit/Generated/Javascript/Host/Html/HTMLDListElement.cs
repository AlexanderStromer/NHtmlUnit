// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDListElement : NHtmlUnit.Javascript.Host.Html.HTMLListElement
   {
      static HTMLDListElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDListElement o) =>
            new HTMLDListElement(o));
      }

      public HTMLDListElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDListElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDListElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDListElement)WrappedObject; }
      }

      public HTMLDListElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDListElement()) {}

   }


}
