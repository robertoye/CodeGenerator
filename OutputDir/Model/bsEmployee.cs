
/*
 * Created by zhye at 2013-11-20 9:23:13; 
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
    [DataContract(Name = "bsEmployee")]
    public class bsEmployee
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public int ID { get ; set ; } 

      /// <summary>
      /// 姓名
      /// </summary>
      [DataMember(Name = "Name")]
      public string Name { get ; set ; } 

      /// <summary>
      /// 隶属部门
      /// </summary>
      [DataMember(Name = "trDeptID")]
      public int trDeptID { get ; set ; } 

      /// <summary>
      /// 邮箱
      /// </summary>
      [DataMember(Name = "Email")]
      public string Email { get ; set ; } 

      /// <summary>
      /// 办公电话
      /// </summary>
      [DataMember(Name = "OfficeTel")]
      public string OfficeTel { get ; set ; } 

      /// <summary>
      /// 职位名称
      /// </summary>
      [DataMember(Name = "PositionName")]
      public string PositionName { get ; set ; } 

      /// <summary>
      /// 域帐号
      /// </summary>
      [DataMember(Name = "DomainAccount")]
      public string DomainAccount { get ; set ; } 

      /// <summary>
      /// 部门领导ID{$人事HRID$}
      /// </summary>
      [DataMember(Name = "DeptHead")]
      public string DeptHead { get ; set ; } 
    }
}    