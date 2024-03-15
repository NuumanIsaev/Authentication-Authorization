namespace MegaPay.Models
{
    public class EBLogs
    {
        public int Ident {  get; set; }
        public string Usr_Code { get; set; }
        public DateTime Log_Date { get; set; }
        public int Log_Type { get; set;}
        public int Log_Status { get; set;}
        public string Log_Message { get; set; }
        public string Log_Error { get; set; }
        public string IPAddress { get; set; }
    }
}
