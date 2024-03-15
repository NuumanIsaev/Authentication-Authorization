namespace MegaPay.Models
{
    public class EBMegaCategories
    {
        public int Ident { get; set; }
        public int Parent_Ident { get; set; }
        public string Category_Name { get; set; }
        public string Mega_Name { get; set; }
        public int Mega_Ident { get; set; }
        public int Category_Order { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Category_Icon { get; set; }
        public int Status { get; set; }
    }
}
