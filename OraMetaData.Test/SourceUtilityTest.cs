using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using NUnit.Framework;

using OraMetaData;

namespace OraMetaData
{
    [TestFixture]
    public class SourceUtilityTest
    {
        [Test]
        public void GetTableDefinition()
        {
            string strOcn = "DATA SOURCE=localora;PERSIST SECURITY INFO=True;USER ID=SCOTT;PASSWORD=tiger";
            DataTable dt = SourceUtility.GetTableDefinition(strOcn, "");
            int expert = 0;
            Assert.Greater(dt.Rows.Count, expert);
        }
    }
}
