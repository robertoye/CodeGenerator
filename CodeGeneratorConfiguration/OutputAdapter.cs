using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGeneratorConfiguration
{
    public class OutputAdapter
    {
        /// <summary>
        /// 输出适配器名
        /// </summary>
        string AdapterName ;
        /// <summary>
        /// 元数据类别
        /// </summary>
        string MeataSoureType;
        /// <summary>
        /// 元数据设置
        /// </summary>
        string MetaSoureConfig ;
        /// <summary>
        /// 模板文件名称
        /// </summary>
        string TemplateFileName ;
        /// <summary>
        /// 输出文件名称
        /// </summary>
        string OutPutFileName ;
        /// <summary>
        /// 输出文件是否覆盖源文件
        /// </summary>
        bool OutputOverCast ;

        /// <summary>
        /// 
        /// </summary>
        public virtual void Func() 
        {

        }
    }
}
