using Ecommerce.Domain.Failures;
using OneOf;

namespace Ecommerce.Domain.Kernel.Creation;

public class CategoryBuilder
{
    protected Category category;
    protected Failure failure;

    /// <summary>
    /// 建立新的基礎類目
    /// </summary>
    public CategoryBuilder()
    {
        category = new Category();
    }

    /// <summary>
    /// 繼續編輯基礎類目
    /// </summary>
    /// <param name="category"></param>
    public CategoryBuilder(Category category)
    {
        this.category = category;
    }
    
    /// <summary>
    /// 為基礎類目設定名稱
    /// </summary>
    /// <param name="name"></param>
    public void SetName(string name)
    {
        category.Name = name;
    }
    
    /// <summary>
    /// 為基礎類目增加子類目
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public Category AddChild(string name)
    {
        // description - 如果類目深度深度已經超過兩層，就不能在加一層子類目了
        var layerNum = getLayerNumOfParent();
        if (layerNum > 2)
        {
            failure = Failure.New(CategoryCode.DeepNumberCannotOverThree);
        }
        var child = new Category();
        child.Name = name;
        child.Parent = child;
        if (child.Children.Contains(child))
        {
            failure = Failure.New(CategoryCode.DuplicatedName);
        }
        child.Children.Add(child);
        return child;
    }

    /// <summary>
    /// 為基礎類目新增類目屬性
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public CategoryAttribute AddAttribute(string name)
    {
        var attribute = new CategoryAttribute();
        attribute.Name = name;
        var attributes = getAttributesFromParent();
        if (attributes.Contains(attribute))
        {
            failure = Failure.New(CategoryCode.DuplicatedName);
        }
        category.Attributes.Add(attribute);
        return attribute;
    }
    
    /// <summary>
    /// 建立基礎類目
    /// </summary>
    /// <returns></returns>
    public OneOf<Failure,Category> Build()
    {
        if (category.Name == null)
        {
            failure = Failure.New(CategoryCode.MustHasName);
        }

        if (failure != null)
            return failure;

        return category;
    }
    
    /// <summary>
    ///  取得根類目的深度
    /// </summary>
    /// <returns></returns>
    private int getLayerNumOfParent()
    {
        var parent = category;
        var number = 0;
        while (parent is not null)
        {
            number += 1;
            parent = parent.Parent;
        }
        return number;
    }
    
    /// <summary>
    /// 取得根類目的所有屬性
    /// </summary>
    /// <returns></returns>
    private HashSet<CategoryAttribute> getAttributesFromParent()
    {
        var parent = category;
        var attributes = new HashSet<CategoryAttribute>();
        while (parent is not null)
        {
            attributes.UnionWith(parent.Attributes);
            parent = parent.Parent;
        }
        return attributes;
    }
    
}