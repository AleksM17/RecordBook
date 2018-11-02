using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecordBook.Models
{
    public class Record
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public string Author { get; set; }

        public DateTime Date { get; set; }
    }
}