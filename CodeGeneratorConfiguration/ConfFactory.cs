using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace CodeGenerator.Configuration
{
    public class ConfFactory
    {
        public static Conf _conf;

        protected static Conf DefaultConf(string ConfName)
        {
            Conf cf = new Conf();
            cf.ConfName = ConfName;
            cf.SoureConnString = "";
            cf.SourceType = "Sql";

            cf.TemplateDir = string.Format(@"{0}TemplateDir\",System.AppDomain.CurrentDomain.BaseDirectory);
            cf.OutputDirPattern = string.Format(@"{0}OutputDir\", System.AppDomain.CurrentDomain.BaseDirectory);
            cf.OutputOverCast = false;
            cf.OutputFileNamePattern="@abcdddd.cs";
            cf.OutputCodeNameSpacePattern = "Model";
            cf.OutputOperationSplite=false;
            cf.OutputOperationDirPattern = string.Format(@"{0}OutputDir\", System.AppDomain.CurrentDomain.BaseDirectory);
            cf.OutputOperationFileNamePattern="@abcdddd.cs";
            cf.OutputOperationCodeNameSpacePattern = "DataAccess";

            return cf;
        }

        public static Conf CurrentConf(string ConfName)
        {
            if (_conf == null)
            {
                if (string.IsNullOrEmpty(ConfName))
                {
                    //配置为空，返回缺省配置
                    _conf = DefaultConf("Running");
                }
                else
                {
                    ConfSection confSection = ConfigurationManager.GetSection("CodeGenerator") as ConfSection;
                    if (confSection != null)
                    {
                        ConfCollection allConf = confSection.AllConf;
                        foreach (Conf conf in allConf)
                        {
                            if (conf.ConfName == ConfName)
                            {
                                _conf = conf;
                                break;
                            }
                        }
                    }
                    //现有配置文件找不到对应配置，返回缺省配置
                    if (_conf == null)
                    {
                        _conf = DefaultConf(ConfName);
                    }
                }
            }
            return _conf;
        }

        /// <summary>
        /// 配置写入配置文件
        /// </summary>
        /// <param name="_conf"></param>
        public static void WirteConfToConfiguration(Conf conf)
        {
            ConfSection confSection = ConfigurationManager.GetSection("CodeGenerator") as ConfSection;
            ConfCollection allConf = new ConfCollection();                

            if (confSection != null)
            {
                allConf = confSection.AllConf;
                Conf currentConf = allConf[conf.ConfName];
                if (currentConf != null)
                {                    
                    allConf.Remove(currentConf);
                }                
            }
            else
            {                
                confSection = new ConfSection();                
            }
            allConf.Add(conf);
            

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.Sections.Add("CodeGenerator", confSection);
            confSection.AllConf = allConf;
            config.Save(ConfigurationSaveMode.Minimal);
        }
    }
}
