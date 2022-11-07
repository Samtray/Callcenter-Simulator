using System.Data;

public class SessionMapper
{
    public static Session ToObject(DataRow row, string[] aliases)
    {
        Session session = new Session();
        session.Id = Convert.ToInt(row, aliases[0]);
        session.DateTimeLogin = Convert.ToDate(row, aliases[1]);
        session.DateTimeLogout = Convert.ToDate(row, aliases[2]);
        session.IdAgent = Convert.ToInt(row, aliases[3]);
        session.IdStation = Convert.ToInt(row, aliases[4]);
        session.IdCurrentCall = Convert.ToInt(row, aliases[5]);
        session.Active = Convert.ToBoolean(row, aliases[6]);
        return session;
    }

    public static List<Session> ToList(DataTable dataTable)
    {
        List<Session> list = new List<Session>();
        foreach (DataRow row in dataTable.Rows)
        {
            list.Add(ToObject(row, new string[] { "id", "dateTimeLogin", "dateTimeLogout",
                "idAgent", "idStation", "idCurrentCall", "active"  }));
        }
        return list;
    }
}