
/*
 * Created by zhye at 2013-11-20 9:24:04; 
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
    [DataContract(Name = "dtTask")]
    public class dtTask
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 编码
      /// </summary>
      [DataMember(Name = "Code")]
      public string Code { get ; set ; } 

      /// <summary>
      /// 制订日期{$记录创建该项明细信息的日期，允许用户修改$}
      /// </summary>
      [DataMember(Name = "BillDate")]
      public string BillDate { get ; set ; } 

      /// <summary>
      /// 立项主表ID
      /// </summary>
      [DataMember(Name = "dtProjectID")]
      public Guid dtProjectID { get ; set ; } 

      /// <summary>
      /// 父级ID
      /// </summary>
      [DataMember(Name = "ParentID")]
      public Guid ParentID { get ; set ; } 

      /// <summary>
      /// 任务描述
      /// </summary>
      [DataMember(Name = "TaskDesc")]
      public string TaskDesc { get ; set ; } 

      /// <summary>
      /// 优先级别{$用户用户填写数字$}
      /// </summary>
      [DataMember(Name = "PriorityLevel")]
      public int PriorityLevel { get ; set ; } 

      /// <summary>
      /// 权重
      /// </summary>
      [DataMember(Name = "ProportionRate")]
      public string ProportionRate { get ; set ; } 

      /// <summary>
      /// 达成比率
      /// </summary>
      [DataMember(Name = "CompleteRate")]
      public string CompleteRate { get ; set ; } 

      /// <summary>
      /// 工作内容
      /// </summary>
      [DataMember(Name = "WorkContent")]
      public string WorkContent { get ; set ; } 

      /// <summary>
      /// 已关闭
      /// </summary>
      [DataMember(Name = "IsClose")]
      public bool IsClose { get ; set ; } 

      /// <summary>
      /// 关闭原因
      /// </summary>
      [DataMember(Name = "CloseReason")]
      public string CloseReason { get ; set ; } 

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
      /// 实际完工日期
      /// </summary>
      [DataMember(Name = "RealCompleteDate")]
      public string RealCompleteDate { get ; set ; } 

      /// <summary>
      /// 责任人HRID{$根据系统参数定义的规则提前N日邮件知会该工作责任人$}
      /// </summary>
      [DataMember(Name = "ResponsibilityMan")]
      public int ResponsibilityMan { get ; set ; } 

      /// <summary>
      /// 参与人{$直接填写参与人姓名$}
      /// </summary>
      [DataMember(Name = "AttendMan")]
      public string AttendMan { get ; set ; } 

      /// <summary>
      /// 所需资源
      /// </summary>
      [DataMember(Name = "NeedResource")]
      public string NeedResource { get ; set ; } 

      /// <summary>
      /// 依赖前任务完成{$逻辑真表示该任务的前项任务完成后才能启动$}
      /// </summary>
      [DataMember(Name = "IsDependPretaskComplete")]
      public bool IsDependPretaskComplete { get ; set ; } 

      /// <summary>
      /// 属关键点
      /// </summary>
      [DataMember(Name = "IsKeyPoint")]
      public bool IsKeyPoint { get ; set ; } 

      /// <summary>
      /// 是否投资项{$如果是投资项，则显示更多与设备相关的列信息$}
      /// </summary>
      [DataMember(Name = "IsInvest")]
      public bool IsInvest { get ; set ; } 

      /// <summary>
      /// 预算金额{$子项明细累计金额禁止超出分项预算$}
      /// </summary>
      [DataMember(Name = "BudgetAmount")]
      public string BudgetAmount { get ; set ; } 

      /// <summary>
      /// 预算项名称{$可以设备名称，也可以服务等$}
      /// </summary>
      [DataMember(Name = "BudgetItemName")]
      public string BudgetItemName { get ; set ; } 

      /// <summary>
      /// 属设备类{$设备类需求将按设备验收完成：到货、安装、质保验收，否则：分项、质保$}
      /// </summary>
      [DataMember(Name = "IsEquipment")]
      public bool IsEquipment { get ; set ; } 

      /// <summary>
      /// 计量单位ID{$引用基础类别资料：台、套、条……$}
      /// </summary>
      [DataMember(Name = "tpUnitID")]
      public int tpUnitID { get ; set ; } 

      /// <summary>
      /// 规格型号
      /// </summary>
      [DataMember(Name = "StandardModel")]
      public string StandardModel { get ; set ; } 

      /// <summary>
      /// 需求数量
      /// </summary>
      [DataMember(Name = "Qaulity")]
      public string Qaulity { get ; set ; } 

      /// <summary>
      /// 含税单价
      /// </summary>
      [DataMember(Name = "TaxPrice")]
      public string TaxPrice { get ; set ; } 

      /// <summary>
      /// 币种ID{$引用基础类别资料：人民币、美元、欧元、日元……$}
      /// </summary>
      [DataMember(Name = "tpCurrencyTypeID")]
      public int tpCurrencyTypeID { get ; set ; } 

      /// <summary>
      /// 采购周期{$以天为单位，记录自然天数(根据制订日期和采购周期分析采购执行时间)$}
      /// </summary>
      [DataMember(Name = "PurchaseCycle")]
      public int PurchaseCycle { get ; set ; } 

      /// <summary>
      /// 要求到货日期
      /// </summary>
      [DataMember(Name = "RequireArriveDate")]
      public string RequireArriveDate { get ; set ; } 

      /// <summary>
      /// 取得方式ID{$引用基础类别资料：外购、调拨、租用、其他$}
      /// </summary>
      [DataMember(Name = "tpFetchModelID")]
      public int tpFetchModelID { get ; set ; } 

      /// <summary>
      /// 累计订购数量{$累计订购数量不能超过需求数量$}
      /// </summary>
      [DataMember(Name = "PurchaseQaulity")]
      public string PurchaseQaulity { get ; set ; } 

      /// <summary>
      /// 累计订购金额{$累计订购金额不能超过需求数量*预算单价$}
      /// </summary>
      [DataMember(Name = "PurchaseAmount")]
      public string PurchaseAmount { get ; set ; } 

      /// <summary>
      /// 主要技术参数
      /// </summary>
      [DataMember(Name = "MainTechniqueParm")]
      public string MainTechniqueParm { get ; set ; } 

      /// <summary>
      /// 用途说明
      /// </summary>
      [DataMember(Name = "UsageInstruction")]
      public string UsageInstruction { get ; set ; } 

      /// <summary>
      /// 需求部门ID{$引用组织架构中的部门ID$}
      /// </summary>
      [DataMember(Name = "trDeptID_Require")]
      public int trDeptID_Require { get ; set ; } 

      /// <summary>
      /// 变更次数{$由系统自动记录$}
      /// </summary>
      [DataMember(Name = "AlterNumbers")]
      public int AlterNumbers { get ; set ; } 

      /// <summary>
      /// 累计变更额{$同上$}
      /// </summary>
      [DataMember(Name = "AlterAmount")]
      public string AlterAmount { get ; set ; } 

      /// <summary>
      /// 已结案{$结案后，禁止对未取得余量进行采购$}
      /// </summary>
      [DataMember(Name = "IsEndCase")]
      public bool IsEndCase { get ; set ; } 

      /// <summary>
      /// 结案人
      /// </summary>
      [DataMember(Name = "EndCaseMan")]
      public string EndCaseMan { get ; set ; } 

      /// <summary>
      /// 结案日期
      /// </summary>
      [DataMember(Name = "EndCaseDate")]
      public string EndCaseDate { get ; set ; } 

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
      /// 终审人
      /// </summary>
      [DataMember(Name = "FinalCheckMan")]
      public string FinalCheckMan { get ; set ; } 

      /// <summary>
      /// 终审日期
      /// </summary>
      [DataMember(Name = "FinalCheckDate")]
      public string FinalCheckDate { get ; set ; } 

      /// <summary>
      /// 状态ID{$引用基础类别资料：未开始、进行中、已结束/已取消$}
      /// </summary>
      [DataMember(Name = "tpTaskStateID")]
      public int tpTaskStateID { get ; set ; } 
    }
}    