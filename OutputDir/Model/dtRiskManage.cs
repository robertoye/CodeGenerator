
/*
 * Created by zhye at 2013-11-20 9:22:07; 
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
    [DataContract(Name = "dtRiskManage")]
    public class dtRiskManage
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
      /// 立项主表ID
      /// </summary>
      [DataMember(Name = "dtProjectID")]
      public Guid dtProjectID { get ; set ; } 

      /// <summary>
      /// 项目任务ID
      /// </summary>
      [DataMember(Name = "dtTaskID")]
      public Guid dtTaskID { get ; set ; } 

      /// <summary>
      /// 责任人
      /// </summary>
      [DataMember(Name = "ResponsibilityMan")]
      public string ResponsibilityMan { get ; set ; } 

      /// <summary>
      /// 潜在风险描述
      /// </summary>
      [DataMember(Name = "RiskDesc")]
      public string RiskDesc { get ; set ; } 

      /// <summary>
      /// 应对措施
      /// </summary>
      [DataMember(Name = "Solution")]
      public string Solution { get ; set ; } 

      /// <summary>
      /// 风险等级ID{$引用基础类别资料，含：高、中、低$}
      /// </summary>
      [DataMember(Name = "tpRiskLevelID")]
      public int tpRiskLevelID { get ; set ; } 

      /// <summary>
      /// 发生概率ID{$引用基础类别资料，含：高、中、低$}
      /// </summary>
      [DataMember(Name = "tpOccurProbabilityID")]
      public int tpOccurProbabilityID { get ; set ; } 

      /// <summary>
      /// 影响程度ID{$引用基础类别资料，含：大、中、小$}
      /// </summary>
      [DataMember(Name = "tpAffectLevelID")]
      public int tpAffectLevelID { get ; set ; } 
    }
}    