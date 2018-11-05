using RecordBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordBook.Dal
{
    interface IRecordRepository
    {
        List<Record> GetRecords();

        void CreateRecord(Record rec);

        void UpdateRecord(Record rec);

        Record GetRecord(int id);

        void Delete(Record rec);

    }
}
