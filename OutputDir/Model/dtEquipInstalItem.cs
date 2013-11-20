
/*
 * Created by zhye at 2013-11-20 9:23:34; 
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
    [DataContract(Name = "dtEquipInstalItem")]
    public class dtEquipInstalItem
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 安装验收主表ID
      /// </summary>
      [DataMember(Name = "dtEquipInstalID")]
      public Guid dtEquipInstalID { get ; set ; } 

      /// <summary>
      /// 安装验收项ID{$引用基础类别资料，含：操作，运行功能确认、设备整体性能确认、制成品质量确认、验收文件资料、对设备的总评价$}
      /// </summary>
      [DataMember(Name = "tpInstalAcceptID")]
      public int tpInstalAcceptID { get ; set ; } 

      /// <summary>
      /// 验收意见
      /// </summary>
      [DataMember(Name = "AcceptSuggest")]
      public string AcceptSuggest { get ; set ; } 
    }
}    