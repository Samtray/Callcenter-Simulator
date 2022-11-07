alter procedure spLogoutAgent
	-- parameters
	@agentId int,
	@status int output
as
begin
	-- variables
	declare @callWaitTime time;
	declare @dateTimeAnswered as dateTime;
	declare @dateTimeReceived as dateTime;

	-- validation
	set @status = 0;
	if not exists(select id from agents where id = @agentId) set @status = 1; -- could not log in agent (invalid id and/or pin)
	if not exists(select id from sessions where idAgent = @agentId and active = 1) set @status = 2; --agent not logged in
	if not exists(select id from sessions where idAgent = @agentId and idCurrentCall is null) set @status = 3; --Agent has an active call


	--try
	if @status = 0 begin	
		--transaction
		begin transaction
			begin try
				update sessions set dateTimeLogout = CURRENT_TIMESTAMP, active = 0 where idAgent = @agentId;
				commit transaction
			end try
			begin catch
				rollback transaction
			end catch
		select @status;
	end 
end