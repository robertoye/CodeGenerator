using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGenerator.MetadataModel
{
    public class TableDef
    {        
        public int Object_Id { get; set; }
        public string Name { get; set; }
        public string Schema { get; set; }
        public List<FieldDef> Fields { get; set; }

        public bool NeedCreate { get; set; }

        public string Dir { get; set; }
        public string FileName { get; set; }
        public string CodeNameSpace { get; set; }
        public string OperationDir { get; set; }
        public string OperationFileName { get; set; }
        public string OperationCodeNameSpace { get; set; }
    }
}
