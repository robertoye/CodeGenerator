
/*
 * Created by zhye at 2013-11-20 9:22:24; 
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
    [DataContract(Name = "bsSysParm")]
    public class bsSysParm
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public int ID { get ; set ; } 

      /// <summary>
      /// 隶属机构ID
      /// </summary>
      [DataMember(Name = "tpOrganId")]
      public int tpOrganId { get ; set ; } 

      /// <summary>
      /// 编码
      /// </summary>
      [DataMember(Name = "Code")]
      public string Code { get ; set ; } 

      /// <summary>
      /// 参数名称
      /// </summary>
      [DataMember(Name = "Name")]
      public string Name { get ; set ; } 

      /// <summary>
      /// 参数数字值
      /// </summary>
      [DataMember(Name = "DigitValue")]
      public decimal DigitValue { get ; set ; } 

      /// <summary>
      /// 上限值
      /// </summary>
      [DataMember(Name = "UpperLimitValue")]
      public decimal UpperLimitValue { get ; set ; } 

      /// <summary>
      /// 下限值
      /// </summary>
      [DataMember(Name = "LowerLimitValue")]
      public decimal LowerLimitValue { get ; set ; } 

      /// <summary>
      /// 参数字符值
      /// </summary>
      [DataMember(Name = "CharValue")]
      public string CharValue { get ; set ; } 

      /// <summary>
      /// 是否数字
      /// </summary>
      [DataMember(Name = "IsDigit")]
      public bool IsDigit { get ; set ; } 

      /// <summary>
      /// 是否系统参数
      /// </summary>
      [DataMember(Name = "IsSystemParm")]
      public bool IsSystemParm { get ; set ; } 

      /// <summary>
      /// 简要说明
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
      /// 修改日期
      /// </summary>
      [DataMember(Name = "EditDate")]
      public string EditDate { get ; set ; } 

      /// <summary>
      /// 启用状态
      /// </summary>
      [DataMember(Name = "IsValid")]
      public bool IsValid { get ; set ; } 
    }
}    