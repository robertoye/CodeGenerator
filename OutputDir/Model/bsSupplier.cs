
/*
 * Created by zhye at 2013-11-20 9:22:36; 
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
    [DataContract(Name = "bsSupplier")]
    public class bsSupplier
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public int ID { get ; set ; } 

      /// <summary>
      /// 编号
      /// </summary>
      [DataMember(Name = "Code")]
      public string Code { get ; set ; } 

      /// <summary>
      /// 商家全称{$标识不同的业务类别名称$}
      /// </summary>
      [DataMember(Name = "Name")]
      public string Name { get ; set ; } 

      /// <summary>
      /// 简称
      /// </summary>
      [DataMember(Name = "ShortName")]
      public string ShortName { get ; set ; } 

      /// <summary>
      /// 联系人
      /// </summary>
      [DataMember(Name = "Linkman")]
      public string Linkman { get ; set ; } 

      /// <summary>
      /// 联系地址
      /// </summary>
      [DataMember(Name = "LinkAddress")]
      public string LinkAddress { get ; set ; } 

      /// <summary>
      /// 联系电话
      /// </summary>
      [DataMember(Name = "Tel")]
      public string Tel { get ; set ; } 

      /// <summary>
      /// 传真号码
      /// </summary>
      [DataMember(Name = "Fax")]
      public string Fax { get ; set ; } 

      /// <summary>
      /// 邮政编码
      /// </summary>
      [DataMember(Name = "PostCode")]
      public string PostCode { get ; set ; } 

      /// <summary>
      /// 售后服务内容
      /// </summary>
      [DataMember(Name = "SaleAfterService")]
      public string SaleAfterService { get ; set ; } 

      /// <summary>
      /// 隶属国家ID{$引用基础类别资料，含：中国、美国、日本、法国……$}
      /// </summary>
      [DataMember(Name = "tpCountryID")]
      public int tpCountryID { get ; set ; } 

      /// <summary>
      /// 隶属城市ID{$引用基础类别资料，含：北京、上海、广州、深圳……$}
      /// </summary>
      [DataMember(Name = "tpCityID")]
      public int tpCityID { get ; set ; } 

      /// <summary>
      /// 资质证号
      /// </summary>
      [DataMember(Name = "CertificateCode")]
      public string CertificateCode { get ; set ; } 

      /// <summary>
      /// 资质等级
      /// </summary>
      [DataMember(Name = "CertificateLevel")]
      public string CertificateLevel { get ; set ; } 

      /// <summary>
      /// 开户银行
      /// </summary>
      [DataMember(Name = "DepositBank")]
      public string DepositBank { get ; set ; } 

      /// <summary>
      /// 纳税号码
      /// </summary>
      [DataMember(Name = "TaxNo")]
      public string TaxNo { get ; set ; } 

      /// <summary>
      /// 银行地址
      /// </summary>
      [DataMember(Name = "BankAddress")]
      public string BankAddress { get ; set ; } 

      /// <summary>
      /// 银行账号
      /// </summary>
      [DataMember(Name = "BankAccount")]
      public string BankAccount { get ; set ; } 

      /// <summary>
      /// 结算方式ID{$引用基础类别资料，含：货到N日、月结N日……$}
      /// </summary>
      [DataMember(Name = "tpClearingModeId")]
      public int tpClearingModeId { get ; set ; } 

      /// <summary>
      /// 结算天数
      /// </summary>
      [DataMember(Name = "ClearingDays")]
      public int ClearingDays { get ; set ; } 

      /// <summary>
      /// 营业执照号码
      /// </summary>
      [DataMember(Name = "ShopCard")]
      public string ShopCard { get ; set ; } 

      /// <summary>
      /// 注册资本
      /// </summary>
      [DataMember(Name = "RegMoney")]
      public string RegMoney { get ; set ; } 

      /// <summary>
      /// 上级机构
      /// </summary>
      [DataMember(Name = "ParentDept")]
      public string ParentDept { get ; set ; } 

      /// <summary>
      /// 主营产品
      /// </summary>
      [DataMember(Name = "MainProduct")]
      public string MainProduct { get ; set ; } 

      /// <summary>
      /// 销售范围
      /// </summary>
      [DataMember(Name = "SaleRange")]
      public string SaleRange { get ; set ; } 

      /// <summary>
      /// 销售员
      /// </summary>
      [DataMember(Name = "SalesMan")]
      public string SalesMan { get ; set ; } 

      /// <summary>
      /// 电子邮箱
      /// </summary>
      [DataMember(Name = "Email")]
      public string Email { get ; set ; } 

      /// <summary>
      /// 公司网址
      /// </summary>
      [DataMember(Name = "WebSite")]
      public string WebSite { get ; set ; } 

      /// <summary>
      /// 内部单位
      /// </summary>
      [DataMember(Name = "isInterior")]
      public bool isInterior { get ; set ; } 

      /// <summary>
      /// 属供应商
      /// </summary>
      [DataMember(Name = "isSupplier")]
      public bool isSupplier { get ; set ; } 

      /// <summary>
      /// 属服务商
      /// </summary>
      [DataMember(Name = "isISP")]
      public bool isISP { get ; set ; } 

      /// <summary>
      /// 属生产商
      /// </summary>
      [DataMember(Name = "isManuFacturer")]
      public bool isManuFacturer { get ; set ; } 

      /// <summary>
      /// 主要客户名单
      /// </summary>
      [DataMember(Name = "MainCustomer")]
      public string MainCustomer { get ; set ; } 

      /// <summary>
      /// 员工数
      /// </summary>
      [DataMember(Name = "EmployeeNum")]
      public int EmployeeNum { get ; set ; } 

      /// <summary>
      /// 信息接收号码
      /// </summary>
      [DataMember(Name = "InfoAcceptPhone")]
      public string InfoAcceptPhone { get ; set ; } 

      /// <summary>
      /// 金蝶科目
      /// </summary>
      [DataMember(Name = "KingDeeCode")]
      public string KingDeeCode { get ; set ; } 

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
      /// 创建日期
      /// </summary>
      [DataMember(Name = "CreateDate")]
      public string CreateDate { get ; set ; } 

      /// <summary>
      /// 修改人
      /// </summary>
      [DataMember(Name = "EditMan")]
      public string EditMan { get ; set ; } 

      /// <summary>
      /// 修改日期{$记录相关业务表的主表ID值(同表多业务需区分取值段)$}
      /// </summary>
      [DataMember(Name = "EditDate")]
      public string EditDate { get ; set ; } 

      /// <summary>
      /// 资料状态ID{$引用基础类别资料，含：待审核、活动有效、冻结待决、撤消失效$}
      /// </summary>
      [DataMember(Name = "tpInfoStateID")]
      public int tpInfoStateID { get ; set ; } 
    }
}    