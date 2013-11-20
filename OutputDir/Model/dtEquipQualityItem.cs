
/*
 * Created by zhye at 2013-11-20 9:23:50; 
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
    [DataContract(Name = "dtEquipQualityItem")]
    public class dtEquipQualityItem
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 质保验收主表ID
      /// </summary>
      [DataMember(Name = "dtEquipQualityID")]
      public Guid dtEquipQualityID { get ; set ; } 

      /// <summary>
      /// 质保验收项ID{$引用基础类别资料，含：技术性能,指标参数、安全性、易操作性、易维护性、节能,环保性能、机械,电气稳定性、其他$}
      /// </summary>
      [DataMember(Name = "tpQualityAcceptID")]
      public int tpQualityAcceptID { get ; set ; } 

      /// <summary>
      /// 验收结论{$引用基础类别资料，含：合格、不合格$}
      /// </summary>
      [DataMember(Name = "tpAcceptSummaryID")]
      public int tpAcceptSummaryID { get ; set ; } 

      /// <summary>
      /// 补充说明
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 
    }
}    