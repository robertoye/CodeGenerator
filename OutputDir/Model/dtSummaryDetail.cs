
/*
 * Created by zhye at 2013-11-20 9:22:56; 
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
    [DataContract(Name = "dtSummaryDetail")]
    public class dtSummaryDetail
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 总结主表ID
      /// </summary>
      [DataMember(Name = "dtSummaryID")]
      public Guid dtSummaryID { get ; set ; } 

      /// <summary>
      /// 案例总结项ID{$引用基础类别资料，含：项目背景、项目目的及目标……$}
      /// </summary>
      [DataMember(Name = "tpSummaryItemID")]
      public int tpSummaryItemID { get ; set ; } 

      /// <summary>
      /// 总结内容描述
      /// </summary>
      [DataMember(Name = "summaryContent")]
      public string summaryContent { get ; set ; } 
    }
}    