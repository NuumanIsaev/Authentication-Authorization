namespace MegaPay.Models
{
    public class EBUserLogins
    {
        public int Ident { get; set; }
        public string Cu_Code { get; set; }
        public string Usr_Code { get; set; }
        public DateTime Usr_Login_Date { get; set; }
        public int Usr_Login_Status { get; set; }
        public string Usr_Login_Message { get; set; }
        public string TempCode { get; set; }
        public string IPAddress { get; set; }

    }
}
