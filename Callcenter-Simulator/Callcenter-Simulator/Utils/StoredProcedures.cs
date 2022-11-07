using System.Data.SqlClient;

public class StoredProcedures
    {
        public static int ReceiveCall(string phoneNumber)
        {
            string statement = "spReceiveCall";
            SqlCommand command = new SqlCommand(statement);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            return SqlServerConnection.ExecuteProcedure(command);
        }

        public static int LoginAgent(int agentId, int agentPin, int stationId)
        {
            string statement = "spLoginAgent";
            SqlCommand command = new SqlCommand(statement);
            command.Parameters.AddWithValue("@agentId", agentId);
            command.Parameters.AddWithValue("@agentPin", agentPin);
            command.Parameters.AddWithValue("@stationId", stationId);
            return SqlServerConnection.ExecuteProcedure(command);
        }

        public static int EndCall(int callId, int statusEndId)
        {
            string statement = "spEndCall";
            SqlCommand command = new SqlCommand(statement);
            command.Parameters.AddWithValue("@callId", callId);
            command.Parameters.AddWithValue("@statusEndId", statusEndId);
            return SqlServerConnection.ExecuteProcedure(command);
        }

        public static int LogoutAgent(int agentId)
        {
            string statement = "spLogoutAgent";
            SqlCommand command = new SqlCommand(statement);
            command.Parameters.AddWithValue("@agentId", agentId);
            return SqlServerConnection.ExecuteProcedure(command);
        }
}

