using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGenerator.MetadataModel
{
    public interface IObtainTables
    {
        List<TableDef> ObtainTables(string strFilter);
    }
}
