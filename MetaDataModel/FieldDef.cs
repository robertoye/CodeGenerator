using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGenerator.MetadataModel
{
    public class FieldDef
    {
        public TableDef Table { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int Column_Id { get; set; }
        public string RawType { get; set; }
        public bool isPrimeKey { get; set; }
    }
}
