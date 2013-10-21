using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGenerator.MetadataModel
{
    public interface IFields
    {
        List<FieldDef> ObtainFields(TableDef tb,string strFilter);
        //string StandardType();
    }
}
