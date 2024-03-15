using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MegaPay.Models
{
    public class EBTrOrdersVerification
    {
        public int Ident { get; set; }
        public DateTime Tro_Start_Date { get; set; }
        public int Tro_User_Ident { get; set; }
        public string Tro_JSON { get; set; }
        public string Tro_API {  get; set; }
        public int Tro_Verification_User_Ident { get; set; }
        public DateTime Tro_Verification_Date { get; set; }
        public int Tro_Status {  get; set; }
        public string Tro_Status_Message { get; set; }
        public string Tro_Error {  get; set; }
        public int Tro_Type { get; set; }
        public string Tro_CuCode { get; set; }
        public int Deleted { get; set; }
        public DateTime Tro_Value_Date {  get; set; }
        public string Tro_Token { get; set; }
        public string Tro_Trans_Order { get; set; }
        public int Tro_Order {  get; set; }
    }
}
