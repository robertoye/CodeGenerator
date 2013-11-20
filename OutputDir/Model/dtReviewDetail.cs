
/*
 * Created by zhye at 2013-11-20 9:21:21; 
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
    [DataContract(Name = "dtReviewDetail")]
    public class dtReviewDetail
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 回访主表ID
      /// </summary>
      [DataMember(Name = "dtReviewID")]
      public Guid dtReviewID { get ; set ; } 

      /// <summary>
      /// 回访项ID{$引用基础类别资料，含：工程安装、安全性、系统操作方便性……$}
      /// </summary>
      [DataMember(Name = "tpReviewItemID")]
      public int tpReviewItemID { get ; set ; } 

      /// <summary>
      /// 回访结论{$引用基础类别资料，含：合格、不合格$}
      /// </summary>
      [DataMember(Name = "ReviewSummary")]
      public int ReviewSummary { get ; set ; } 
    }
}    