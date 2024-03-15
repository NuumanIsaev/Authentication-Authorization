namespace MegaPay.Models
{
    public class EBAccounts
    {
        public int Ident { get; set; }
        public int Cu_Ident { get; set; }
        public string Cu_Code { get; set; }   
        public string Usr_Code { get; set; }
        public string Acc_Type { get; set; }
        public string Usr_Type { get; set; }
        public string Acc_Currency { get; set; }
        public string Acc_Local { get;set; }
        public DateTime Acc_Open_Date { get; set; }
        public string Acc_Status { get;set; }
        public decimal Acc_Balance { get; set; }
        public decimal Acc_Interest { get; set;}
        public DateTime Acc_Last_Sync { get; set;}
        public int Acc_Closed { get; set; }
        public string Acc_Of_Code { get; set; }
    }
}
