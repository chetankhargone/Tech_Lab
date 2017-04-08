namespace Angular_app.DTO
{
    using System.Collections.Generic;

    public class CustomerTO
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public string Password { get; set; }
        public List<string> Products { get; set; }
        public int CountryId { get; set; }
        public string CustCountry { get; set; }
    }
}