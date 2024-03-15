using Dapper;
using System.Data;
using MegaPay.Models;

namespace MegaPay.Services
{
    public class MegaCategoryService : IMegaCategoryService
    {
        public event Action OnCategoryCreatedOrUpdated;
        public readonly IDbConnection _db;
        public MegaCategoryService(IDbConnection db)
        {
            _db = db;
        }

        public List<EBMegaCategories> GetAllCategories()
        {
            string sql = "SELECT * FROM EB_Mega_Categories WHERE Status = 1 ORDER BY Category_Order ASC, Category_Name ASC";
            return _db.Query<EBMegaCategories>(sql).ToList();
        }

        public void CreateCategory(EBMegaCategories newCategory, DateTime CreatedDate, int Status)
        {
            string sql = "INSERT INTO  dbo.EB_Mega_Categories (Parent_Ident,Category_Name, Category_Order, CreateDate, Category_Icon, Status)" +
                                                    " VALUES (@ParentIdent, @CatName, @CatOrder, @Date, @Icon, @Status);";
            _db.Execute(sql, new {
                ParentIdent = newCategory.Parent_Ident,
                CatName = newCategory.Category_Name,
                CatOrder = newCategory.Category_Order,
                Date = DateTime.Now,
                Icon = newCategory.Category_Icon,
                Status = 1
            });
        }

        public void UpdateCategory(EBMegaCategories selectedCategory)
        {
            string sql = "UPDATE dbo.EB_Mega_Categories SET Category_Name = @CatName, Category_Icon = @Icon, Category_Order =@CatOrder, UpdateDate = @Date Where Ident = @Ident;";
            _db.Execute(sql, new { 
                CatName = selectedCategory.Category_Name, 
                Icon = selectedCategory.Category_Icon, 
                CatOrder = selectedCategory.Category_Order, 
                Date = DateTime.Now,
                Ident = selectedCategory.Ident 
            });
        }

        public void DeleteCategory(int CategoryIdent)
        {
            string sql = "UPDATE dbo.EB_Mega_Categories SET Status = @NewStatus WHERE Ident = @Ident OR Parent_Ident = @Ident;";

            _db.Execute(sql, new { NewStatus = 0, Ident = CategoryIdent });
        }
    }

    public interface IMegaCategoryService
    {
       List<EBMegaCategories> GetAllCategories();
       void UpdateCategory(EBMegaCategories selectedCategory);
       void DeleteCategory(int CategoryIdent);
       void CreateCategory(EBMegaCategories newCategory, DateTime CreatedDate, int Status);
       event Action OnCategoryCreatedOrUpdated;
    }
}
