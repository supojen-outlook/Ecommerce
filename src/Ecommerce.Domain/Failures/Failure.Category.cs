using Ecommerce.Domain.Failures.Attributes;

namespace Ecommerce.Domain.Failures;

/// <summary>
/// 有關於基礎類目的錯誤
/// </summary>
public enum CategoryCode
{
    [Code("Category.MustHasName")]
    [Message("必須有類目名稱")] 
    MustHasName,
    
    [Code("Category.DeepNumberCannotOverThree")]
    [Message("類目深度不能操過3層")] 
    DeepNumberCannotOverThree,

    [Code("Category.NotExist")]
    [Message("類目不存在")] 
    NotExist,
    
    [Code("Category.AddFailure")]
    [Message("新增基礎類目失敗")]
    AddFailure,

    [Code("Category.DuplicatedName")]
    [Message("同一層類目，名稱不能相同")]
    DuplicatedName,
    
    [Code("Category.DuplicateCode")]
    [Message("編號不能重複")]
    DuplicateCode,
}
