using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

using CodeGenerator;
using CodeGenerator.Configuration;
using CodeGenerator.MetadataModel;

namespace CodeGeneratorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConfName = ConfigurationManager.AppSettings["ConfName"].ToString();
            Conf conf = ConfFactory.CurrentConf(ConfName);
            GlobalVariable par = new GlobalVariable();
            par.Creater = "zhye";
            par.Copyright = "Team";

            MetaDataFactory factory = new MetaDataFactory(conf, par);
            //获取元数据定义
            List<TableDef> tabs = factory.GetMetaData();

            //判定
            foreach (TableDef tb in tabs)
            {
                factory.CreateAllFile(false,tb);
                System.Console.WriteLine("生成代码{0}成功;\n",tb.Name);
            }

            //输出文件
            foreach (TableDef tb in tabs)
            {
                //factory.CreateAllFile(false,tb);
            }
        }
    }
}