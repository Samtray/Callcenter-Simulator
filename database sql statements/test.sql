-- receieve call
declare @result as int;
exec spReceiveCall
	@phoneNumber = '1289380923',
	@status = @result output;
select @result;

--login agent
declare @result as int;
exec spLoginAgent
	@agentId = 1006,
	@agentPin = 2006,
	@stationId = 6,
	@status = @result output;
select @result;

--logout
declare @result as int;
exec spLogoutAgent
	@agentId = 1006,
	@status = @result output;
select @result;

--end call
declare @result as int;
exec spEndCall
	@callId = 21,
	@statusEndId = 1, -- 1: Customer Ended, 2: Agent Ended, 3: Call Dropped, 4: Transfered (from table statusCallEnd)
	@status = @result output;
select @result;

-- calls
select * from viewCalls;
--sessions
select * from viewSessions;
-- session log
select * from viewSessionLog where idSession = 3; 

-- hacer una api con 3 acciones
-- POST http://localhost:8080/api/call/recieve/6641921846
-- POST http://localhost:8080/api/call/recieve/{idcall}/{idstatus}
-- POST http://localhost:8080/api/agent/login/
-- {header: id, pin, stationId}