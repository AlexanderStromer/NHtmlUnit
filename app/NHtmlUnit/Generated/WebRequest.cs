// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class WebRequest : ObjectWrapper
   {
      static WebRequest()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.WebRequest o) =>
            new WebRequest(o));
      }

      public WebRequest(com.gargoylesoftware.htmlunit.WebRequest wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.WebRequest WObj
      {
         get { return (com.gargoylesoftware.htmlunit.WebRequest)WrappedObject; }
      }

      public WebRequest(java.net.URL url)
         : this(new com.gargoylesoftware.htmlunit.WebRequest(url)) {}

      public WebRequest(java.net.URL url, NHtmlUnit.HttpMethod submitMethod)
         : this(new com.gargoylesoftware.htmlunit.WebRequest(url, (com.gargoylesoftware.htmlunit.HttpMethod)submitMethod.WrappedObject)) {}

      public WebRequest(java.net.URL url, string acceptHeader, string acceptEncodingHeader)
         : this(new com.gargoylesoftware.htmlunit.WebRequest(url, acceptHeader, acceptEncodingHeader)) {}


      public java.net.URL Url
      {
         get
         {
            return WObj.getUrl();
         }
         set
         {
            WObj.setUrl(value);
         }

      }

      public java.nio.charset.Charset Charset
      {
         get
         {
            return WObj.getCharset();
         }
         set
         {
            WObj.setCharset(value);
         }

      }

      public NHtmlUnit.HttpMethod HttpMethod
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.HttpMethod>(
               WObj.getHttpMethod());
         }
         set
         {
            WObj.setHttpMethod((com.gargoylesoftware.htmlunit.HttpMethod)value.WrappedObject);
         }

      }


      public org.apache.http.auth.Credentials Credentials
      {
         get
         {
            return WObj.getCredentials();
         }
         set
         {
            WObj.setCredentials(value);
         }

      }

      public System.String RequestBody
      {
         get
         {
            return WObj.getRequestBody();
         }
         set
         {
            WObj.setRequestBody(value);
         }

      }

      public java.util.Map AdditionalHeaders
      {
         get
         {
            return WObj.getAdditionalHeaders();
         }
         set
         {
            WObj.setAdditionalHeaders(value);
         }

      }

      public IList<NHtmlUnit.Util.NameValuePair> RequestParameters
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Util.NameValuePair>(
               WObj.getRequestParameters());
         }
       }

      public NHtmlUnit.FormEncodingType EncodingType
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.FormEncodingType>(
               WObj.getEncodingType());
         }
         set
         {
            WObj.setEncodingType((com.gargoylesoftware.htmlunit.FormEncodingType)value.WrappedObject);
         }

      }


      public System.String ProxyHost
      {
         get
         {
            return WObj.getProxyHost();
         }
         set
         {
            WObj.setProxyHost(value);
         }

      }

      public System.Int32 ProxyPort
      {
         get
         {
            return WObj.getProxyPort();
         }
         set
         {
            WObj.setProxyPort(value);
         }

      }

      public System.String ProxyScheme
      {
         get
         {
            return WObj.getProxyScheme();
         }
         set
         {
            WObj.setProxyScheme(value);
         }

      }

      public org.apache.http.auth.Credentials UrlCredentials
      {
         get
         {
            return WObj.getUrlCredentials();
         }
      }

      public System.Int32 Timeout
      {
         get
         {
            return WObj.getTimeout();
         }
         set
         {
            WObj.setTimeout(value);
         }

      }
// Generating method code for setAdditionalHeader
      public virtual void SetAdditionalHeader(string name, string value)
      {
         WObj.setAdditionalHeader(name, value);
      }

// Generating method code for isSocksProxy
      public virtual bool IsSocksProxy()
      {
         return WObj.isSocksProxy();
      }

// Generating method code for hasHint
      public virtual bool HasHint(com.gargoylesoftware.htmlunit.WebRequest.HttpHint hint)
      {
         return WObj.hasHint(hint);
      }

// Generating method code for getAdditionalHeader
      public virtual string GetAdditionalHeader(string name)
      {
         return WObj.getAdditionalHeader(name);
      }

// Generating method code for addHint
      public virtual void AddHint(com.gargoylesoftware.htmlunit.WebRequest.HttpHint hint)
      {
         WObj.addHint(hint);
      }

// Generating method code for isAdditionalHeader
      public virtual bool IsAdditionalHeader(string name)
      {
         return WObj.isAdditionalHeader(name);
      }

// Generating method code for removeAdditionalHeader
      public virtual void RemoveAdditionalHeader(string name)
      {
         WObj.removeAdditionalHeader(name);
      }

   }


}
