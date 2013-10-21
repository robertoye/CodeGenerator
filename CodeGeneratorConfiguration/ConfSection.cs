using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace CodeGenerator.Configuration
{
    public class ConfSection : ConfigurationSection
    {
        [ConfigurationProperty("Configurations", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(ConfCollection), AddItemName = "add",ClearItemsName = "clear", RemoveItemName = "remove")]
        public ConfCollection AllConf
        {
            get
            {
                return (ConfCollection)base["Configurations"];
            }
            set
            {
                base["Configurations"] = value;
            }
        }
    }
}
