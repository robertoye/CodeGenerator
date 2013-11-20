
/*
 * Created by zhye at 2013-11-20 9:21:47; 
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
    [DataContract(Name = "dtPurchaseAlterPayScheme")]
    public class dtPurchaseAlterPayScheme
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 采购主表ID
      /// </summary>
      [DataMember(Name = "dtPurchaseID")]
      public Guid dtPurchaseID { get ; set ; } 

      /// <summary>
      /// 原付款计划ID{$新增的付款项，在变更里默认为零$}
      /// </summary>
      [DataMember(Name = "dtPurchasePaySchemeID")]
      public Guid dtPurchasePaySchemeID { get ; set ; } 

      /// <summary>
      /// 原进度序号
      /// </summary>
      [DataMember(Name = "RawProgressNo")]
      public int RawProgressNo { get ; set ; } 

      /// <summary>
      /// 变更后进度序号{$默认同原序号，用户可调整$}
      /// </summary>
      [DataMember(Name = "AlterAfterProgressNo")]
      public int AlterAfterProgressNo { get ; set ; } 

      /// <summary>
      /// 原支付内容描述
      /// </summary>
      [DataMember(Name = "RawPayContentDesc")]
      public string RawPayContentDesc { get ; set ; } 

      /// <summary>
      /// 现支付内容描述{$默认同原内容，用户可调整$}
      /// </summary>
      [DataMember(Name = "CurrentPayContentDesc")]
      public string CurrentPayContentDesc { get ; set ; } 

      /// <summary>
      /// 原付款比率
      /// </summary>
      [DataMember(Name = "RawPayRate")]
      public string RawPayRate { get ; set ; } 

      /// <summary>
      /// 变更后付款比率{$不能低于已付款比率$}
      /// </summary>
      [DataMember(Name = "AlterAfterPayRate")]
      public string AlterAfterPayRate { get ; set ; } 

      /// <summary>
      /// 原比率应付金额
      /// </summary>
      [DataMember(Name = "RawRatePayAmount")]
      public string RawRatePayAmount { get ; set ; } 

      /// <summary>
      /// 现应付比率金额{$系统根据当前总额和比率计算$}
      /// </summary>
      [DataMember(Name = "CurrentRatePayAmount")]
      public string CurrentRatePayAmount { get ; set ; } 

      /// <summary>
      /// 原确认应付金额
      /// </summary>
      [DataMember(Name = "RawConfirmPayAmount")]
      public string RawConfirmPayAmount { get ; set ; } 

      /// <summary>
      /// 变更后确认应付{$默认现应付比率金额，允许用户进行取整调整，但不能低于累计已付额$}
      /// </summary>
      [DataMember(Name = "AlterAfterConfrimPayAmount")]
      public string AlterAfterConfrimPayAmount { get ; set ; } 

      /// <summary>
      /// 累计已付金额
      /// </summary>
      [DataMember(Name = "AccumulatePayAmount")]
      public string AccumulatePayAmount { get ; set ; } 

      /// <summary>
      /// 原付款控制条件{$系统将原控制项为真的转换为汉字串，如：需验收;需发票的形式$}
      /// </summary>
      [DataMember(Name = "RawPayCondition")]
      public string RawPayCondition { get ; set ; } 

      /// <summary>
      /// 可预付
      /// </summary>
      [DataMember(Name = "IsPrepay")]
      public bool IsPrepay { get ; set ; } 

      /// <summary>
      /// 需到货
      /// </summary>
      [DataMember(Name = "IsNeedArriveGoods")]
      public bool IsNeedArriveGoods { get ; set ; } 

      /// <summary>
      /// 需验收
      /// </summary>
      [DataMember(Name = "IsNeedCheck")]
      public bool IsNeedCheck { get ; set ; } 

      /// <summary>
      /// 需质保
      /// </summary>
      [DataMember(Name = "IsNeedQualityGuarantee")]
      public bool IsNeedQualityGuarantee { get ; set ; } 

      /// <summary>
      /// 需发票
      /// </summary>
      [DataMember(Name = "IsNeedInvoice")]
      public bool IsNeedInvoice { get ; set ; } 

      /// <summary>
      /// 简要注释
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 
    }
}    