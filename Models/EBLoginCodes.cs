namespace MegaPay.Models
{
    public class EBLoginCodes
    {
        public int Ident {get; set; }
        public string Cu_Code { get; set; }
        public string Usr_Code { get; set; }
        public DateTime Usr_Login_Date { get; set; }
        public int Usr_Login_Code { get; set; }
        public DateTime Usr_Code_Expires { get; set; }
        public int Usr_Code_Status { get; set; }
        public string Usr_Code_Message { get; set; }
    }
}
