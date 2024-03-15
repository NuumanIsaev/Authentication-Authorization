namespace MegaPay.Models
{
    public class EBMpcLogs
    {
        public int Ident {  get; set; }
        public int User_Ident { get; set; }
        public string User_Cu_Code { get; set; }
        public DateTime Date { get; set; }
        public string Internal_Ref { get; set;}
        public int Mpc_Is_Deposit { get; set; }
        public string Mpc_Payment_ID { get; set; }
        public string Mpc_Create_Status { get; set; }
        public string Mpc_Confirm_Status { get; set; }
        public string Abs_Trans_Status { get; set; }
        public string Message { get;set; }
        public string Acc_Number { get;set; }
        public string Card_Number { get; set;}
        public string Card_Expiry { get; set;}
        public decimal Card_Available_Amount { get; set;}
        public decimal Oper_Amount { get;set;}
        public string Oper_Currency { get; set; }
        public string Oper_Currency_Code { get;set; }
        public int Deleted {  get; set; }

    }
}
