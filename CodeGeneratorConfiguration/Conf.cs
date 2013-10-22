using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace CodeGenerator.Configuration
{
    /// <summary>
    /// 自定义配置节对应类
    /// </summary>
    public class Conf : System.Configuration.ConfigurationElement
    {
        #region --配置文件中记录的初始参数
        
        /// <summary>
        /// 配置名称
        /// </summary>
        [ConfigurationProperty("ConfName", IsRequired = true, IsKey = true)]
        public string ConfName
        {

            get { return (string)base["ConfName"] as string; }
            set { base["ConfName"] = value; }
        }
        /// <summary>
        /// 元数据库连接字符串信息
        /// </summary>
        [ConfigurationProperty("SoureConnString", IsRequired = false)]
        public string SoureConnString
        {
            get { return base["SoureConnString"] as string; }
            set { base["SoureConnString"] = value; }
        }
        /// <summary>
        /// 元数据保存数据库类型
        /// </summary>
        [ConfigurationProperty("SourceType", IsRequired = false)]
        public string SourceType
        {
            get { return (string)base["SourceType"] as string; }
            set { base["SourceType"] = value; }
        }
        /// <summary>
        /// 模板文件对应目录
        /// </summary>
        [ConfigurationProperty("TemplateDir", IsRequired = false)]
        public string TemplateDir
        {
            get { return base["TemplateDir"] as string; }
            set { base["TemplateDir"] = value; }
        }

        /// <summary>
        /// 输出模板代码文件对应根目录
        /// </summary>
        [ConfigurationProperty("OutputDirPattern", IsRequired = false)]
        public string OutputDirPattern
        {
            get { return base["OutputDirPattern"] as string; }
            set { base["OutputDirPattern"] = value; }
        }

        /// <summary>
        /// 输出文件是否覆盖唯读
        /// </summary>
        [ConfigurationProperty("OutputOverCast", IsRequired = false)]
        public bool OutputOverCast
        {
            get { return (bool) base["OutputOverCast"] ; }
            set { base["OutputOverCast"] = value; }
        }        
        
        /// <summary>
        /// 输出文件名格式
        /// </summary>
        [ConfigurationProperty("OutputFileNamePattern", IsRequired = false)]
        public string OutputFileNamePattern
        {
            get { return base["OutputFileNamePattern"] as string; }
            set { base["OutputFileNamePattern"] = value; }
        }

        /// <summary>
        /// 输出模板代码命名空间
        /// </summary>
        [ConfigurationProperty("OutputCodeNameSpacePattern", IsRequired = false)]
        public string OutputCodeNameSpacePattern
        {
            get { return base["OutputCodeNameSpacePattern"] as string; }
            set { base["OutputCodeNameSpacePattern"] = value; }
        }
        
        /// <summary>
        /// 输出模板操作方法是否与模板分开
        /// </summary>
        [ConfigurationProperty("OutputOperationSplite", IsRequired = false)]
        public bool OutputOperationSplite
        {

            get { return (bool) base["OutputOperationSplite"]; }
            set { base["OutputOperationSplite"] = value; }
        }

        /// <summary>
        /// 输出模板操作方法与模板分开时，操作方法输出目录
        /// </summary>
        [ConfigurationProperty("OutputOperationDirPattern", IsRequired = false)]
        public string OutputOperationDirPattern
        {
            get { return base["OutputOperationDirPattern"] as string; }
            set { base["OutputOperationDirPattern"] = value; }
        }
        
        /// <summary>
        /// 操作方法输出代码文件名模板
        /// </summary>
        [ConfigurationProperty("OutputOperationFileNamePattern", IsRequired = false)]
        public string OutputOperationFileNamePattern
        {

            get { return base["OutputOperationFileNamePattern"] as string; }

            set { base["OutputOperationFileNamePattern"] = value; }
        }

        /// <summary>
        /// 操作方法输出代码命名空间模板
        /// </summary>
        [ConfigurationProperty("OutputOperationCodeNameSpacePattern", IsRequired = false)]
        public string OutputOperationCodeNameSpacePattern
        {

            get { return base["OutputOperationCodeNameSpacePattern"] as string; }

            set { base["OutputOperationCodeNameSpacePattern"] = value; }
        }
        #endregion --配置文件中记录的初始参数

        public string CodeTemplate { get ; set ; }
        public string OperatorTemplate { get; set; }
    }
}