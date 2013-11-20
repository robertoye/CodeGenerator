
/*
 * Created by zhye at 2013-11-20 9:22:45; 
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
    [DataContract(Name = "dtAttachment")]
    public class dtAttachment
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 业务表名称{$列字段名：TableName$}
      /// </summary>
      [DataMember(Name = "TableName")]
      public string TableName { get ; set ; } 

      /// <summary>
      /// 业务表ID{$记录附件与业务表记录相关的具体ID$}
      /// </summary>
      [DataMember(Name = "BillIDValue")]
      public Guid BillIDValue { get ; set ; } 

      /// <summary>
      /// 文件名称
      /// </summary>
      [DataMember(Name = "FileName")]
      public string FileName { get ; set ; } 

      /// <summary>
      /// 存放路径
      /// </summary>
      [DataMember(Name = "SavePath")]
      public string SavePath { get ; set ; } 

      /// <summary>
      /// 附件类型ID{$引用类别基础资料，如：JPG、PDF……$}
      /// </summary>
      [DataMember(Name = "tpAttachTypeID")]
      public int tpAttachTypeID { get ; set ; } 

      /// <summary>
      /// 简要注释
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 

      /// <summary>
      /// 默认值
      /// </summary>
      [DataMember(Name = "DefaultValue")]
      public string DefaultValue { get ; set ; } 

      /// <summary>
      /// 录入人
      /// </summary>
      [DataMember(Name = "CreateMan")]
      public string CreateMan { get ; set ; } 

      /// <summary>
      /// 录入日期
      /// </summary>
      [DataMember(Name = "CreateDate")]
      public string CreateDate { get ; set ; } 

      /// <summary>
      /// 修改人
      /// </summary>
      [DataMember(Name = "EditMan")]
      public string EditMan { get ; set ; } 

      /// <summary>
      /// 修改日期
      /// </summary>
      [DataMember(Name = "EditDate")]
      public string EditDate { get ; set ; } 
    }
}    