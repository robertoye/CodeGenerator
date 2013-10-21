using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

using CodeGenerator;
using CodeGenerator.MetadataModel;

namespace MetaDataFactory.Test
{ 
    [TestFixture]
    public class RazorHelperTest
    {
       [Test]
        public void Parsetest()
        {
            string template = "@(Model.Table.Name + \".cs\")";
            GlobalVariable par = new GlobalVariable();
            TableDef tb =new TableDef();
            tb.Name = "abc";
            string strExpected = "abc.cs";
            string result = RazorHelper.Parse(template, par, tb,"asfs");

            Assert.AreEqual(strExpected, result);
        }

       public void abc()
       {
           string a = ""; 
           //a.Substring
       }
    }
}
