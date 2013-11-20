
/*
 * Created by zhye at 2013-11-20 9:21:24; 
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
    [DataContract(Name = "dtProject")]
    public class dtProject
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 项目编码
      /// </summary>
      [DataMember(Name = "Code")]
      public string Code { get ; set ; } 

      /// <summary>
      /// 项目名称
      /// </summary>
      [DataMember(Name = "Name")]
      public string Name { get ; set ; } 

      /// <summary>
      /// 隶属公司
      /// </summary>
      [DataMember(Name = "bsAccountID")]
      public int bsAccountID { get ; set ; } 

      /// <summary>
      /// 紧急程序{$项目可标识为紧急与一般两种状态，逻辑真表示：紧急；否表示：一般$}
      /// </summary>
      [DataMember(Name = "EmergencyProgram")]
      public bool EmergencyProgram { get ; set ; } 

      /// <summary>
      /// 实施方式ID{$引用基础类别资料：自制、委外、自制+委外$}
      /// </summary>
      [DataMember(Name = "tpRunModelID")]
      public int tpRunModelID { get ; set ; } 

      /// <summary>
      /// 项目类别ID{$引用基础类别资料：设备项目、技改项目、基建项目、综合项目$}
      /// </summary>
      [DataMember(Name = "tpProjectTypeID")]
      public int tpProjectTypeID { get ; set ; } 

      /// <summary>
      /// 立项申请人
      /// </summary>
      [DataMember(Name = "ApplyMan")]
      public string ApplyMan { get ; set ; } 

      /// <summary>
      /// 申请日期
      /// </summary>
      [DataMember(Name = "ApplyDate")]
      public string ApplyDate { get ; set ; } 

      /// <summary>
      /// 项目终审人{$根据项目级别不同，终审人可能不同，由审批流程写入$}
      /// </summary>
      [DataMember(Name = "FinalCheckMan")]
      public string FinalCheckMan { get ; set ; } 

      /// <summary>
      /// 批复日期
      /// </summary>
      [DataMember(Name = "ReplyDate")]
      public string ReplyDate { get ; set ; } 

      /// <summary>
      /// 项目级别ID{$引用基础类别资料：大型项目、中型项目、小型项目、微型项目$}
      /// </summary>
      [DataMember(Name = "tpProjectLevelID")]
      public int tpProjectLevelID { get ; set ; } 

      /// <summary>
      /// 需采购参与{$如果项目中涉及到需总部采购部参与的需设置为逻辑真，以指导流程路径$}
      /// </summary>
      [DataMember(Name = "IsInvolvePurchase")]
      public bool IsInvolvePurchase { get ; set ; } 

      /// <summary>
      /// 需确认人力成本{$由用户自行判断$}
      /// </summary>
      [DataMember(Name = "IsConfirmHumanCost")]
      public bool IsConfirmHumanCost { get ; set ; } 

      /// <summary>
      /// 需确认工艺品质{$由用户自行判断$}
      /// </summary>
      [DataMember(Name = "IsConfrimTechnologyQuality")]
      public bool IsConfrimTechnologyQuality { get ; set ; } 

      /// <summary>
      /// 计划开工日期
      /// </summary>
      [DataMember(Name = "PlanStartWorkDate")]
      public string PlanStartWorkDate { get ; set ; } 

      /// <summary>
      /// 计划完工日期
      /// </summary>
      [DataMember(Name = "PlanCompleteWorkDate")]
      public string PlanCompleteWorkDate { get ; set ; } 

      /// <summary>
      /// 立项依据
      /// </summary>
      [DataMember(Name = "ProposalBase")]
      public string ProposalBase { get ; set ; } 

      /// <summary>
      /// 立项目的目标
      /// </summary>
      [DataMember(Name = "ProposalTarget")]
      public string ProposalTarget { get ; set ; } 

      /// <summary>
      /// 利弊分析{$必要性和利弊分析$}
      /// </summary>
      [DataMember(Name = "BehoofHarmAnalysis")]
      public string BehoofHarmAnalysis { get ; set ; } 

      /// <summary>
      /// 规划内容{$描述项目初步规划内容、主要设备、技术难点$}
      /// </summary>
      [DataMember(Name = "PlanContent")]
      public string PlanContent { get ; set ; } 

      /// <summary>
      /// 预计变更项{$预计变更内容及批准权限$}
      /// </summary>
      [DataMember(Name = "PredictAlterItem")]
      public string PredictAlterItem { get ; set ; } 

      /// <summary>
      /// 项目总投资额{$项目总费用，含税$}
      /// </summary>
      [DataMember(Name = "InvestAmount")]
      public string InvestAmount { get ; set ; } 

      /// <summary>
      /// 累计变更额{$记录项目的历次金额变更累计数据，且该数据应该低于允超丝率$}
      /// </summary>
      [DataMember(Name = "AlterAmount")]
      public string AlterAmount { get ; set ; } 

      /// <summary>
      /// 项目允超率{$项目实际发生的费用允许超出预算的百分比$}
      /// </summary>
      [DataMember(Name = "LimitRate")]
      public string LimitRate { get ; set ; } 

      /// <summary>
      /// 投资回收计算
      /// </summary>
      [DataMember(Name = "InvestRecycleCalculate")]
      public string InvestRecycleCalculate { get ; set ; } 

      /// <summary>
      /// 主导部门ID
      /// </summary>
      [DataMember(Name = "trDeptID")]
      public int trDeptID { get ; set ; } 

      /// <summary>
      /// 主导部门意见
      /// </summary>
      [DataMember(Name = "LeadDepartSuggest")]
      public string LeadDepartSuggest { get ; set ; } 

      /// <summary>
      /// 访问控制ID{$引用基础类别资料：默认、私有、公开、定制成员$}
      /// </summary>
      [DataMember(Name = "tpCallControlID")]
      public int tpCallControlID { get ; set ; } 

      /// <summary>
      /// 白名单成员{$记录可访问项目的成员HRID，多个成员间以半角逗号分隔$}
      /// </summary>
      [DataMember(Name = "WhiteListMember")]
      public string WhiteListMember { get ; set ; } 

      /// <summary>
      /// 简要注释
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 

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
      /// 修改时间
      /// </summary>
      [DataMember(Name = "EditDate")]
      public string EditDate { get ; set ; } 

      /// <summary>
      /// 系统注释{$由系统自动记录关键操作信息，如：反审信息，关闭信息等$}
      /// </summary>
      [DataMember(Name = "SystemRemark")]
      public string SystemRemark { get ; set ; } 

      /// <summary>
      /// 已触发警戒{$当项目发生超期或超预算时，逻辑值为真。当变更后自动解除，逻辑值为否$}
      /// </summary>
      [DataMember(Name = "IsTriggerGuard")]
      public bool IsTriggerGuard { get ; set ; } 

      /// <summary>
      /// 警戒类别ID{$引用基础类别资料：超期(当前日期超过计划完工日期)、超预算$}
      /// </summary>
      [DataMember(Name = "tpGuardTypeID")]
      public int tpGuardTypeID { get ; set ; } 

      /// <summary>
      /// 项目状态ID{$引用基础类别资料：待审批、审批中、已审批、执行中、已验收、已移交、已结案/已关闭$}
      /// </summary>
      [DataMember(Name = "tpProjectStateID")]
      public int tpProjectStateID { get ; set ; } 
    }
}    