using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CodeGenerator.MetadataModel;
using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;
using RazorEngine.Common;
using RazorEngine.Compilation;
using RazorEngine.Text;

namespace CodeGenerator
{
    public class RazorHelper
    {
        public static string Parse(string template, GlobalVariable par, TableDef tab,string cacheName)
        {
            string result = "";

            //DynamicViewBag vb = new DynamicViewBag();
            //vb.GetDynamicMemberNames()
            
            TemplateServiceConfiguration config = new TemplateServiceConfiguration();
            config.BaseTemplateType = typeof(HtmlTemplateBase<>);
            TemplateService svc = new TemplateService(config);
            Razor.SetTemplateService(svc);
            
            result = Razor.Parse(template, new { GlobalVariable = par, Table = tab },cacheName);
            return result;
        }
    }
}