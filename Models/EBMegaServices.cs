namespace MegaPay.Models
{
    public class EBMegaServices
    {
        public int Ident { get; set; }
        public int Category_Ident { get; set; }
        public int Mega_Category_Ident { get; set; }
        public int Mega_Ident { get; set; }
        public string Mega_Name { get; set; }
        public string Service_Name { get; set; }
        public string Service_Icon { get; set;}
        public int Service_Order {  get; set; }
        public DateTime CreateDate { get;set; }
        public DateTime UpdateDate { get;set; }
        public int Status { get; set; }

    }
}
