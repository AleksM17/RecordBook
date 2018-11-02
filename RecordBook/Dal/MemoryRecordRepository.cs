using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RecordBook.Models;

namespace RecordBook.Dal
{
    public class MemoryRecordRepository : IRecordRepository
    {
        private static List<Record> _records = new List<Record>()
        {
            new Record {Id=1, Author="Sasha",Message="Asp.NetRulll",Date=DateTime.Now},
            new Record {Id=2, Author="Petya",Message="Ado.Net",Date=DateTime.Now}
        };
        public void CreateRecord(Record rec)
        {
            rec.Id = _records.Last().Id + 1;
            rec.Date = DateTime.Now;
            _records.Add(rec);
        }

        public List<Record> GetRecords()
        {
            return _records;
        }
    }
}