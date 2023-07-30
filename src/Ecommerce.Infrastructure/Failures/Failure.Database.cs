using Ecommerce.Domain.Failures.Attributes;

namespace Ecommerce.Infrastructure.Failures;

public enum DatabaseCode
{
    [Code("database.Common")]
    [Message("資料庫通用錯誤")]
    Common,   
    
    [Code("Database.DataNotExist")]
    [Message("資料不存在")]
    DataNotExist,
    
    [Code("Database.IDIsAlreadyExist")]
    [Message("ID 已經使用過了")]
    IDIsAlreadyExist,
    
    [Code("Database.NameIsAlreadyExist")]
    [Message("名稱已經使用過了")]
    NameIsAlreadyExist
}