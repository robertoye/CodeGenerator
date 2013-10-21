using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CodeGenerator.Configuration;
using CodeGenerator.MetadataModel;
using SqlMetaData;

namespace CodeGenerator
{
    public class MetaDataFactory
    {
        #region
        private Conf _CurrentConf { get; set; }
        private GlobalVariable _CurrentPar { get; set; }

        private string _strTemplateCodeFileName = "Model.razor";
        private string _strTemplateOperatorFileName = "ModelOperator.razor";

        #endregion
        /// <summary>
        /// 根据输入条生成对应文件
        /// </summary>
        /// <param name="createType"></param>
        /// <param name="td"></param>
        /// <returns></returns>
        private void _CreateCodeFile(bool isCheck,eCreateCodeType createType, TableDef td)
        {
            //变化点2：
            string strOutputDir = "";
            string strFileName = "";
            string strNameSpace = "";
            string strCodeTemplate = "";

            switch (createType)
            {
                case eCreateCodeType.ModelCode:
                    strOutputDir = RazorHelper.Parse(_CurrentConf.OutputDirPattern, _CurrentPar, td,"OutputDir");
                    strFileName = RazorHelper.Parse(_CurrentConf.OutputFileNamePattern, _CurrentPar, td,"FileName");
                    strNameSpace = RazorHelper.Parse(_CurrentConf.OutputCodeNameSpacePattern, _CurrentPar, td,"CodeNameSpacePattern");
                    td.CodeNameSpace = strNameSpace;                    
                    strCodeTemplate = _CurrentConf.CodeTemplate;
                    td.FileName = string.Format("{0}{1}", strOutputDir, strFileName);                    
                    break;
                case eCreateCodeType.ModelOperator:
                    strOutputDir = RazorHelper.Parse(_CurrentConf.OutputOperationDirPattern, _CurrentPar, td,"OutputOperationDir");
                    strFileName = RazorHelper.Parse(_CurrentConf.OutputOperationFileNamePattern, _CurrentPar, td,"OutputOperationFileName");     
                    strNameSpace = RazorHelper.Parse(_CurrentConf.OutputOperationCodeNameSpacePattern, _CurrentPar, td,"OutputOperationCodeNameSpace");
                    strCodeTemplate = _CurrentConf.OperatorTemplate;
                    td.OperationFileName = string.Format("{0}{1}", strOutputDir, strFileName);
                    td.OperationCodeNameSpace = strNameSpace;
                    break;
                default:
                    break;
            }
            string strFilePath = string.Format("{0}{1}", strOutputDir, strFileName);
            string strFileContent = RazorHelper.Parse(strCodeTemplate, _CurrentPar, td,createType.ToString());
            if (!isCheck)
            {
                FileHelper.WriteCodeToFile(strFilePath, strFileContent);
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="conf"></param>
        /// <param name="par"></param>
        public MetaDataFactory(Conf conf, GlobalVariable par)
        {
            _CurrentConf = conf;
            _CurrentPar = par;

            //变化点：
            //读取模板信息到配置中
            string strCodeTemplateFileName = string.Format("{0}{1}", _CurrentConf.TemplateDir, _strTemplateCodeFileName);
            _CurrentConf.CodeTemplate = FileHelper.ReadTemplate(strCodeTemplateFileName);

            if (_CurrentConf.OutputOperationSplite)
            {
                strCodeTemplateFileName = string.Format("{0}{1}", _CurrentConf.TemplateDir, _strTemplateOperatorFileName);
                _CurrentConf.OperatorTemplate = FileHelper.ReadTemplate(strCodeTemplateFileName);
            }           

            //par.ModelSpaceName = _CurrentConf.OutputCodeNameSpacePattern;
            //if(conf.OutputOperationSplite && string.IsNullOrEmpty(_CurrentConf.OutputOperationCodeNameSpacePattern))
            //{
            //    par.OperatorSpaceName = _CurrentConf.OutputCodeNameSpacePattern;
            //}
        }
        
        /// <summary>
        /// 获取元数据定义
        /// </summary>
        /// <returns></returns>
        public List<TableDef> GetMetaData()
        {
            List<TableDef> list = new List<TableDef>();
                      
            switch (_CurrentConf.SourceType)
            {
                case "Sql":
                    SqlStandard st = new SqlStandard(_CurrentConf.SoureConnString);
                    list = st.ObtainTables("a.Name like 'Contact%'");
                    break;
                default:
                    SqlStandard sql = new SqlStandard(_CurrentConf.SoureConnString);
                    list = sql.ObtainTables("");
                    break;            
            }
            return list;
        }        

        /// <summary>
        /// 生成代码文件
        /// </summary>
        /// <param name="td">元数据表定义</param>
        public void CreateAllFile(bool isCheck,TableDef td)
        {
            //生成模型代码文件
            this._CreateCodeFile(isCheck, eCreateCodeType.ModelCode, td);
            //生成操作方法代码
            if (_CurrentConf.OutputOperationSplite)
            {
                this._CreateCodeFile(isCheck, eCreateCodeType.ModelOperator, td);
            }
        }      
    }
}