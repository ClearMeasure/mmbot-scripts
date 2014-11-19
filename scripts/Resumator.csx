var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

var key = robot.GetConfigVariable("MMBOT_RESUMATOR_KEY");

robot.Respond(@"show open jobs", msg => 
	{
		var url = "https://api.resumatorapi.com/v1/jobs?apikey=" + key;
		
		robot.Http(url).GetJson((err, res, body) => 
		{
			foreach(var job in body)
			{
				if(job["status"].ToString() == "Open")
				{
					msg.Send("Title: " + job["title"].ToString() + Environment.NewLine + 
					"City: " + job["city"].ToString() + Environment.NewLine + 
					"Dept: " + job["department"].ToString() + Environment.NewLine + 
					"Type: " + job["type"].ToString() + Environment.NewLine +
					"-----------------------------------------------");
				}
			}
		});
		
	}
);

robot.AddHelp(
    "rosie show me - shows open jobs"
);