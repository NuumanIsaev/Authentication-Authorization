namespace MegaPay.Models
{
    public class EBUsers
    {
        public int Ident {  get; set; }
        public int Deleted { get; set; }
        public string Cu_Code { get; set; }   
        public int Usr_Ident { get; set; }
        public int Cu_Ident { get; set; }
        public string Usr_Code { get; set; }
        public string Usr_Sdc { get; set; }
        public string Usr_Name { get; set; }
        public string Usr_Name_Eng { get; set; }
        public string Usr_Email { get; set; }
        public string Usr_Mobile { get; set; }
        public string Usr_Mobile2 { get; set; }
        public DateTime Usr_Create_Date { get; set; }
        public DateTime Usr_Last_Sync {  get; set; }
        public DateTime Usr_Last_Login { get; set; }
        public string Usr_Notify_Type { get; set; }
        public string Usr_Last_IP { get; set; }
        public int Usr_First_Login { get; set; }

    }
}
