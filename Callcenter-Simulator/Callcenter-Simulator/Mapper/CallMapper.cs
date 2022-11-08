
using System.Data;

public class CallMapper
    {
        public static Call ToObject(DataRow row, string[] aliases)
        {
            Call call = new Call();
            call.Id = Convert.ToInt(row, aliases[0]);
            call.DatetimeReceived = Convert.ToDate(row, aliases[1]);
            call.DatetimeAnswered = Convert.ToDate(row, aliases[2]);
            call.DatetimeEnded = Convert.ToDate(row, aliases[3]);
            call.PhoneNumber = Convert.ToString(row, aliases[4]);
            call.IdSession = Convert.ToInt(row, aliases[5]);
            call.IdStatus = Convert.ToInt(row, aliases[6]);
            call.IdStatusEnd = Convert.ToInt(row, aliases[7]);
            return call;
        }

        public static List<Call> ToList(DataTable dataTable)
        {
            List<Call> list = new List<Call>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(ToObject(row, new string[] { "id", "datetimeReceived", "datetimeAnswered",
                    "datetimeEnded", "phoneNumber", "idSession", "idStatus", "idStatusEnd"  }));
            }
            return list;
        }
}

