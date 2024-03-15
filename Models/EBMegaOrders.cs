namespace MegaPay.Models
{
    public class EBMegaOrders
    {
        public int Ident {  get; set; }
        public int User_Ident { get; set; }
        public string User_Cu_Code { get; set; }
        public DateTime Date { get; set; }
        public string Mega_Pay_Status { get; set; }
        public int Mega_Pay_Status_Final { get; set; }
        public string Abs_Trans_Status { get; set; }
        public int Abs_Trans_Status_Final { get; set; }
        public string Mega_Message {  get; set; }
        public string Abs_Message {  get; set; }
        public string Aclocal {  get; set; }
        public int Mega_Service_Id { get; set; }
        public string Mega_Service_Name { get; set; }
        public string Mega_Account {  get; set; }
        public decimal Amount { get; set; }
        public string User_Token { get; set; }
        public int Deleted { get; set; }
    }
}
