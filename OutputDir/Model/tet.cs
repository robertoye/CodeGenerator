
/*
 * Created by zhye at 2013-11-20 9:23:20; 
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
    [DataContract(Name = "tet")]
    public class tet
    {
      /// <summary>
      /// 
      /// </summary>
      [DataMember(Name = "ID")]
      public int ID { get ; set ; } 

      /// <summary>
      /// 
      /// </summary>
      [DataMember(Name = "Name")]
      public string Name { get ; set ; } 

      /// <summary>
      /// 
      /// </summary>
      [DataMember(Name = "DeafultValue")]
      public string DeafultValue { get ; set ; } 

      /// <summary>
      /// 
      /// </summary>
      [DataMember(Name = "Emblem")]
      public string Emblem { get ; set ; } 

      /// <summary>
      /// 
      /// </summary>
      [DataMember(Name = "isValid")]
      public bool isValid { get ; set ; } 
    }
}    