// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlLink : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlLink()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlLink o) =>
            new HtmlLink(o));
      }

      public HtmlLink(com.gargoylesoftware.htmlunit.html.HtmlLink wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlLink WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlLink)WrappedObject; }
      }


      public NHtmlUnit.WebRequest WebRequest
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.WebRequest>(
               WObj.getWebRequest());
         }
      }


      public System.String HrefAttribute
      {
         get
         {
            return WObj.getHrefAttribute();
         }
      }

      public System.String RelAttribute
      {
         get
         {
            return WObj.getRelAttribute();
         }
      }

      public System.String CharsetAttribute
      {
         get
         {
            return WObj.getCharsetAttribute();
         }
      }

      public System.String HrefLangAttribute
      {
         get
         {
            return WObj.getHrefLangAttribute();
         }
      }

      public System.String TypeAttribute
      {
         get
         {
            return WObj.getTypeAttribute();
         }
      }

      public System.String RevAttribute
      {
         get
         {
            return WObj.getRevAttribute();
         }
      }

      public System.String MediaAttribute
      {
         get
         {
            return WObj.getMediaAttribute();
         }
      }

      public System.String TargetAttribute
      {
         get
         {
            return WObj.getTargetAttribute();
         }
      }
// Generating method code for getWebResponse
      public virtual NHtmlUnit.WebResponse GetWebResponse(bool downloadIfNeeded, NHtmlUnit.WebRequest request)
      {
         var arg = WObj.getWebResponse(downloadIfNeeded, (com.gargoylesoftware.htmlunit.WebRequest)request.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.WebResponse>(arg);
      }

// Generating method code for getWebResponse
      public virtual NHtmlUnit.WebResponse GetWebResponse(bool downloadIfNeeded)
      {
         var arg = WObj.getWebResponse(downloadIfNeeded);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.WebResponse>(arg);
      }

   }


}
