namespace Microsoft.AspNet.Diagnostics.Views
{
#line 1 "RuntimeInfoPage.cshtml"
using System

#line default
#line hidden
    ;
#line 2 "RuntimeInfoPage.cshtml"
using System.Globalization

#line default
#line hidden
    ;
#line 3 "RuntimeInfoPage.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 4 "RuntimeInfoPage.cshtml"
using Microsoft.AspNet.Diagnostics

#line default
#line hidden
    ;
#line 5 "RuntimeInfoPage.cshtml"
using Microsoft.AspNet.Diagnostics.Views

#line default
#line hidden
    ;
#line 6 "RuntimeInfoPage.cshtml"
using Microsoft.Framework.Runtime;

#line default
#line hidden
    using System.Threading.Tasks;

    public class RuntimeInfoPage : Microsoft.AspNet.Diagnostics.Views.BaseView
    {
#line 9 "RuntimeInfoPage.cshtml"

    public RuntimeInfoPage(RuntimeInfoPageModel model)
    {
        Model = model;
    }

    public RuntimeInfoPageModel Model { get; set; }

#line default
#line hidden
        #line hidden
        public RuntimeInfoPage()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n<html");
            WriteAttribute("lang", Tuple.Create(" lang=\"", 372), Tuple.Create("\"", 433), 
            Tuple.Create(Tuple.Create("", 379), Tuple.Create<System.Object, System.Int32>(
#line 18 "RuntimeInfoPage.cshtml"
             CultureInfo.CurrentUICulture.TwoLetterISOLanguageName

#line default
#line hidden
            , 379), false));
            WriteLiteral(" xmlns=\"http://www.w3.org/1999/xhtml\">\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n   " +
" <title>");
            Write(
#line 21 "RuntimeInfoPage.cshtml"
            Resources.RuntimeInfoPage_Title

#line default
#line hidden
            );

            WriteLiteral("</title>\r\n    <style>\r\n        body {\r\n    font-family: 'Segoe UI', Tahoma, Arial, Helvetica, sans-serif;\r\n    font-size: .813em;\r\n    line-height: 1.4em;\r\n    color: #222;\r\n}\r\n\r\nh1, h2, h3, h4, h5, th {\r\n    font-weight: 100;\r\n}\r\n\r\nh1 {\r\n    color: #44525e;\r\n    margin: 15px 0 15px 0;\r\n}\r\n\r\nh2 {\r\n    margin: 10px 5px 0 0;\r\n}\r\n\r\ntable .even{\r\n    background-color: #f0f0f0;\r\n}\r\n\r\nth {\r\n    font-size: 16px;\r\n}\r\n\r\n\r\n\r\n    </style>\r" +
"\n</head>\r\n<body>\r\n    <h1>");
            Write(
#line 27 "RuntimeInfoPage.cshtml"
         Resources.RuntimeInfoPage_RuntimeVersion

#line default
#line hidden
            );

            WriteLiteral("</h1>\r\n    <h2>");
            Write(
#line 28 "RuntimeInfoPage.cshtml"
          string.IsNullOrWhiteSpace(Model.Version) ? Resources.RuntimeInfoPage_RuntimeVersionFail : Model.Version

#line default
#line hidden
            );

            WriteLiteral("</h2>\r\n    \r\n    <h1>");
            Write(
#line 30 "RuntimeInfoPage.cshtml"
         Resources.RuntimeInfoPage_Packages

#line default
#line hidden
            );

            WriteLiteral("</h1>\r\n");
#line 31 "RuntimeInfoPage.cshtml"
    

#line default
#line hidden

#line 31 "RuntimeInfoPage.cshtml"
     if (@Resources.RuntimeInfoPage_Packages == null)
    {

#line default
#line hidden

            WriteLiteral("        <h2>");
            Write(
#line 33 "RuntimeInfoPage.cshtml"
             Resources.RuntimeInfoPage_PackagesFail

#line default
#line hidden
            );

            WriteLiteral("</h2>\r\n");
#line 34 "RuntimeInfoPage.cshtml"
    }
    else
    {

#line default
#line hidden

            WriteLiteral("        <table>\r\n            <thead>\r\n                <tr>\r\n                    <" +
"th>");
            Write(
#line 40 "RuntimeInfoPage.cshtml"
                         Resources.RuntimeInfoPage_PackageNameColumnName

#line default
#line hidden
            );

            WriteLiteral("</th>\r\n                    <th>");
            Write(
#line 41 "RuntimeInfoPage.cshtml"
                         Resources.RuntimeInfoPage_PackagePathColumnName

#line default
#line hidden
            );

            WriteLiteral("</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#line 45 "RuntimeInfoPage.cshtml"
            

#line default
#line hidden

#line 45 "RuntimeInfoPage.cshtml"
               bool even = false; 

#line default
#line hidden

            WriteLiteral("\r\n");
#line 46 "RuntimeInfoPage.cshtml"
            

#line default
#line hidden

#line 46 "RuntimeInfoPage.cshtml"
             foreach (var package in Model.References.OrderBy(package => package.Name.ToLowerInvariant()))
            {

#line default
#line hidden

            WriteLiteral("                <tr");
            WriteAttribute("class", Tuple.Create(" class=\"", 1494), Tuple.Create("\"", 1522), 
            Tuple.Create(Tuple.Create("", 1502), Tuple.Create<System.Object, System.Int32>(
#line 48 "RuntimeInfoPage.cshtml"
                             even?"even":"odd"

#line default
#line hidden
            , 1502), false));
            WriteLiteral(">\r\n                    <td>");
            Write(
#line 49 "RuntimeInfoPage.cshtml"
                         package.Name

#line default
#line hidden
            );

            WriteLiteral("</td>\r\n                    <td>");
            Write(
#line 50 "RuntimeInfoPage.cshtml"
                         package.Path

#line default
#line hidden
            );

            WriteLiteral("</td>\r\n                </tr>\r\n");
#line 52 "RuntimeInfoPage.cshtml"
                

#line default
#line hidden

#line 52 "RuntimeInfoPage.cshtml"
                   even = !even; 

#line default
#line hidden

#line 52 "RuntimeInfoPage.cshtml"
                                  
            }

#line default
#line hidden

            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#line 56 "RuntimeInfoPage.cshtml"
    }

#line default
#line hidden

            WriteLiteral("</body>\r\n</html>\r\n");
        }
        #pragma warning restore 1998
    }
}
