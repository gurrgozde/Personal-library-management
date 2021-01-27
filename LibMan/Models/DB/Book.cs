using System;
using System.Collections.Generic;

namespace LibMan.Models.DB
{
    public partial class Book
    {
        public int? Bookid { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Translator { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }
        public byte[] Cover { get; set; }
        public string Categories { get; set; }
        public string Status { get; set; }
        public int? Userid { get; set; }
    }
}
