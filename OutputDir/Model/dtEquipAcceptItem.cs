
/*
 * Created by zhye at 2013-11-20 9:23:16; 
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
    [DataContract(Name = "dtEquipAcceptItem")]
    public class dtEquipAcceptItem
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 到货确认主表ID
      /// </summary>
      [DataMember(Name = "dtEquipAcceptID")]
      public Guid dtEquipAcceptID { get ; set ; } 

      /// <summary>
      /// 到货验收明细项ID
      /// </summary>
      [DataMember(Name = "dtPurchaseDetailID")]
      public Guid dtPurchaseDetailID { get ; set ; } 

      /// <summary>
      /// 参照结论{$引用基础类别资料到货确认项的描述内容$}
      /// </summary>
      [DataMember(Name = "ReferSummary")]
      public string ReferSummary { get ; set ; } 

      /// <summary>
      /// 验收意见
      /// </summary>
      [DataMember(Name = "AcceptSuggest")]
      public string AcceptSuggest { get ; set ; } 
    }
}    