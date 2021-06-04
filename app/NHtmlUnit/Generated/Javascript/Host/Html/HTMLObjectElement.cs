// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLObjectElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLObjectElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLObjectElement o) =>
            new HTMLObjectElement(o));
      }

      public HTMLObjectElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLObjectElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLObjectElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLObjectElement)WrappedObject; }
      }

      public HTMLObjectElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLObjectElement()) {}


      public System.String Classid
      {
         get
         {
            return WObj.getClassid();
         }
         set
         {
            WObj.setClassid(value);
         }

      }

      public System.String Alt
      {
         get
         {
            return WObj.getAlt();
         }
         set
         {
            WObj.setAlt(value);
         }

      }

      public System.String Border
      {
         get
         {
            return WObj.getBorder();
         }
         set
         {
            WObj.setBorder(value);
         }

      }

      public System.String Width_js
      {
         get
         {
            return WObj.getWidth_js();
         }
      }

      public System.String Height_js
      {
         get
         {
            return WObj.getHeight_js();
         }
      }

      public System.String Align
      {
         get
         {
            return WObj.getAlign();
         }
         set
         {
            WObj.setAlign(value);
         }

      }
// Generating method code for unwrap
      public virtual object Unwrap()
      {
         var arg = WObj.unwrap();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for checkValidity
      public virtual bool CheckValidity()
      {
         return WObj.checkValidity();
      }

   }


}
