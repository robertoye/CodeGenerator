using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace CodeGenerator.Configuration
{   
    public class ConfCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new Conf();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((Conf)element).ConfName;
        }

        public void Add(Conf conf)
        {
            base.BaseAdd(conf);
        }

        public void Remove(Conf conf)
        {
            base.BaseRemove(conf);
        }

        public Conf this[int index]
        {
            get { return (Conf)base.BaseGet(index); }
        }

        new public Conf this[string name]
        {
            get { return (Conf)base.BaseGet(name); }
        }
    }
}
