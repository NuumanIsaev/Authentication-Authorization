using Dapper;
using System.Data;
using MegaPay.Models;

namespace MegaPay.Services
{
    public class MegaServices : IMegaServices
    {

        public readonly IDbConnection _db;
        public MegaServices(IDbConnection db)
        {
            _db = db;
        }

        public List<EBMegaServices> GetAllServices()
        {
            string sql = "SELECT * FROM EB_Mega_Services WHERE Status = 1 ORDER BY Service_Order ASC, Service_Name ASC";

            return _db.Query<EBMegaServices>(sql).ToList();
        }

        public void UpdateServiceCategoryIdent(int CategoryIdent, int ServiceIdent)
        {
            string sql = "UPDATE EB_Mega_Services SET Category_Ident = @CatIdent Where Ident = @SerIdent; ";

            _db.Execute(sql, new { CatIdent = CategoryIdent, SerIdent = ServiceIdent});
        }

        public void DeleteService(int ServiceIdent)
        {
            string sql = "UPDATE EB_Mega_Services SET Status = @NewStatus Where Ident = @Ident; ";

            _db.Execute(sql, new { NewStatus = 0, Ident = ServiceIdent });
        }

        public void UpdateService(string ServiceName, string ServiceIcon, int ServiceOrder, int ServiceIdent)
        {
            string sql = "UPDATE EB_Mega_Services SET Service_Name = @NewValue, Service_Icon = @NewValue1, Service_Order =@NewValue2 Where Ident = @Ident; ";

            _db.Execute(sql, new { NewValue = ServiceName,NewValue1 = ServiceIcon, NewValue2 = ServiceOrder,   Ident = ServiceIdent });
        }
    }

    public interface IMegaServices
    {
        List<EBMegaServices> GetAllServices();
        void UpdateServiceCategoryIdent(int CategoryIdent, int ServiceIdent);
        void DeleteService(int ServiceIdent);
        void UpdateService(string ServiceName, string ServiceIcon, int ServiceOrder, int ServiceIdent);
    }
}
