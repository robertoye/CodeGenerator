/*
 * Created by zhye at 2013-10-22 11:44:40; 
 *
 *
 *
 *
 *
 * Copyright:Team
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Model;

namespace DAL
{
    public class ContactAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.Contact> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ContactID,
                NameStyle,
                Title,
                FirstName,
                MiddleName,
                LastName,
                Suffix,
                EmailAddress,
                EmailPromotion,
                Phone,
                PasswordHash,
                PasswordSalt,
                AdditionalContactInfo,
                rowguid,
                ModifiedDate
            from Contact";

        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public void Insert(Model.Contact entity)
        {
            private _strInsertSql = @"insert into Contact(
                ContactID,
                NameStyle,
                Title,
                FirstName,
                MiddleName,
                LastName,
                Suffix,
                EmailAddress,
                EmailPromotion,
                Phone,
                PasswordHash,
                PasswordSalt,
                AdditionalContactInfo,
                rowguid,
                ModifiedDate
)
            values (
                :ContactID,
                :NameStyle,
                :Title,
                :FirstName,
                :MiddleName,
                :LastName,
                :Suffix,
                :EmailAddress,
                :EmailPromotion,
                :Phone,
                :PasswordHash,
                :PasswordSalt,
                :AdditionalContactInfo,
                :rowguid,
                :ModifiedDate
)";
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.Contact entity)
        {
            private _strUpdateSql = @"Update  Contact set
                ContactID = :ContactID, 
                NameStyle = :NameStyle, 
                Title = :Title, 
                FirstName = :FirstName, 
                MiddleName = :MiddleName, 
                LastName = :LastName, 
                Suffix = :Suffix, 
                EmailAddress = :EmailAddress, 
                EmailPromotion = :EmailPromotion, 
                Phone = :Phone, 
                PasswordHash = :PasswordHash, 
                PasswordSalt = :PasswordSalt, 
                AdditionalContactInfo = :AdditionalContactInfo, 
                rowguid = :rowguid, 
                ModifiedDate = :ModifiedDate 
            where Id=:Id";
        }
        /// <summary>
        /// 删除方法
        /// </summary>
        public void Delete(int Id)
        {
            private _strDeleteSql = @"";
        }
    }
}    