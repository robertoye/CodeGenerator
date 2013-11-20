
/*
 * Created by zhye at 2013-11-20 9:21:37; 
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
    [DataContract(Name = "dtProjectMember")]
    public class dtProjectMember
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 立项主表ID
      /// </summary>
      [DataMember(Name = "dtProjectID")]
      public Guid dtProjectID { get ; set ; } 

      /// <summary>
      /// 成员HRID
      /// </summary>
      [DataMember(Name = "bsEmployeeId")]
      public int bsEmployeeId { get ; set ; } 

      /// <summary>
      /// 职责描述
      /// </summary>
      [DataMember(Name = "ResponsibilityDesc")]
      public string ResponsibilityDesc { get ; set ; } 

      /// <summary>
      /// 项目角色ID{$引用基础类别资料，含：项目经理、项目组长、工程师、组员$}
      /// </summary>
      [DataMember(Name = "tpProjectRoleID")]
      public int tpProjectRoleID { get ; set ; } 

      /// <summary>
      /// 参与程度{$记录项目成员在该项目的参与成度$}
      /// </summary>
      [DataMember(Name = "AttendRate")]
      public string AttendRate { get ; set ; } 

      /// <summary>
      /// 工作状态ID{$引用基础类别资料，含：未开始、工作中、撤消任务、完成任务$}
      /// </summary>
      [DataMember(Name = "tpWorkStateID")]
      public int tpWorkStateID { get ; set ; } 
    }
}    