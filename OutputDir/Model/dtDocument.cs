
/*
 * Created by zhye at 2013-11-20 9:22:00; 
 *
 *
 *
 *
 *
 * Copyright:Strong
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract(Name = "dtDocument")]
    public class dtDocument
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 单据编号
      /// </summary>
      [DataMember(Name = "BillCode")]
      public string BillCode { get ; set ; } 

      /// <summary>
      /// 项目ID
      /// </summary>
      [DataMember(Name = "dtProjectID")]
      public int dtProjectID { get ; set ; } 

      /// <summary>
      /// 项目任务ID
      /// </summary>
      [DataMember(Name = "dtTaskID")]
      public int dtTaskID { get ; set ; } 

      /// <summary>
      /// 文档类别ID{$引用基础类别资料，如：$}
      /// </summary>
      [DataMember(Name = "tpDocumentTypeID")]
      public int tpDocumentTypeID { get ; set ; } 

      /// <summary>
      /// 文档类型ID{$引用基础类别资料，如：$}
      /// </summary>
      [DataMember(Name = "tpDocumentClassID")]
      public int tpDocumentClassID { get ; set ; } 

      /// <summary>
      /// 文档标题
      /// </summary>
      [DataMember(Name = "DocumentTitle")]
      public string DocumentTitle { get ; set ; } 

      /// <summary>
      /// 索引关键字
      /// </summary>
      [DataMember(Name = "IndexKey")]
      public string IndexKey { get ; set ; } 

      /// <summary>
      /// 主要内容描述
      /// </summary>
      [DataMember(Name = "MainContentDesc")]
      public string MainContentDesc { get ; set ; } 

      /// <summary>
      /// 文档摘要
      /// </summary>
      [DataMember(Name = "DocumentSummary")]
      public string DocumentSummary { get ; set ; } 

      /// <summary>
      /// 存放路径
      /// </summary>
      [DataMember(Name = "SavePath")]
      public string SavePath { get ; set ; } 

      /// <summary>
      /// 简要注释
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 
    }
}    