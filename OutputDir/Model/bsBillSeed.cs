
/*
 * Created by zhye at 2013-11-20 9:23:06; 
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
    [DataContract(Name = "bsBillSeed")]
    public class bsBillSeed
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public int ID { get ; set ; } 

      /// <summary>
      /// 机构ID
      /// </summary>
      [DataMember(Name = "tpOrganId")]
      public int tpOrganId { get ; set ; } 

      /// <summary>
      /// 机构代码{$默认机构资料中的代码，允许用户修改$}
      /// </summary>
      [DataMember(Name = "OrganCode")]
      public string OrganCode { get ; set ; } 

      /// <summary>
      /// 启用机构编码段
      /// </summary>
      [DataMember(Name = "isEnableOrgan")]
      public bool isEnableOrgan { get ; set ; } 

      /// <summary>
      /// 单据类别ID{$标识不同的业务类别名称$}
      /// </summary>
      [DataMember(Name = "bsBillTypeId")]
      public int bsBillTypeId { get ; set ; } 

      /// <summary>
      /// 单据类别代码{$默认系统中单据类别的代码，允许用户修改$}
      /// </summary>
      [DataMember(Name = "BillCode")]
      public string BillCode { get ; set ; } 

      /// <summary>
      /// 启用类别编码段
      /// </summary>
      [DataMember(Name = "isEnableType")]
      public bool isEnableType { get ; set ; } 

      /// <summary>
      /// 日期字符{$默认4位年份字符，如：2013。跨年后新增记录行$}
      /// </summary>
      [DataMember(Name = "DateChar")]
      public string DateChar { get ; set ; } 

      /// <summary>
      /// 启用日期符编码段
      /// </summary>
      [DataMember(Name = "isEnableDate")]
      public bool isEnableDate { get ; set ; } 

      /// <summary>
      /// 业务编号种子{$根据：机构+单据类别+日期字符 自动流水增长$}
      /// </summary>
      [DataMember(Name = "CodeSeed")]
      public int CodeSeed { get ; set ; } 
    }
}    