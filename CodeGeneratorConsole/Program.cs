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

            string a= "\"";
            //获取命令行参数
            CodeGenerator.MetadataModel.ArgsHelper pars = new CodeGenerator.MetadataModel.ArgsHelper(args);            
            GlobalVariable par = new GlobalVariable();
            par.Creater = pars.Creator;
            par.Copyright = pars.CopyrightTeamName;
            string strFilter = SqlMetaData.SqlStandard.BuildFilter(pars);
            
            string ConfName = ConfigurationManager.AppSettings["ConfName"].ToString();
            Conf conf = ConfFactory.CurrentConf(ConfName);
            

            MetaDataFactory factory = new MetaDataFactory(conf, par);
            //获取元数据定义
            List<TableDef> tabs = factory.GetMetaData(strFilter);

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