
/*
 * Created by zhye at 2013-11-20 9:24:25; 
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
    [DataContract(Name = "dtTransferProjectDetail")]
    public class dtTransferProjectDetail
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 移交主表ID
      /// </summary>
      [DataMember(Name = "dtTransferProjectID")]
      public Guid dtTransferProjectID { get ; set ; } 

      /// <summary>
      /// 主要移交项目描述{$引用基础类别资料，含：操作，运行功能确认、设备整体性能确认、制成品质量确认、验收文件资料、对设备的总评价$}
      /// </summary>
      [DataMember(Name = "Desc")]
      public string Desc { get ; set ; } 

      /// <summary>
      /// 补充说明
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 
    }
}    