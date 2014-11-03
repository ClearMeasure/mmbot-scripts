var robot = Require<Robot>();

var key = robot.GetConfigVariable("MMBOT_RESUMATOR_KEY");

robot.Hear(@"show open jobs", msg => 
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
    "show me - shows you an image of the thing you searched for"
);