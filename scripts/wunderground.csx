var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

var key = robot.GetConfigVariable("MMBOT_WUNDERGROUND_KEY");

robot.Hear(@"weather (me|at|for|in) (.*)", msg => 
	{		
		var wuparams = msg.Match[2].Split(',');
		var state = wuparams[1].Trim();
		var city = wuparams[0].Trim();
		
		var url = "http://api.wunderground.com/api/" + key + "/forecast/q/" + state + "/" + city + ".json";
		
		robot.Http(url).GetJson((err, res, body) => 
		{
			var forecast = body["forecast"];
			var txt_forecast = forecast["txt_forecast"];
			var forecastdays = txt_forecast["forecastday"];
			
			foreach(var day in forecastdays)
			{
				var title = day["title"].ToString();
				var forcast = day["fcttext"].ToString();
				var rain = day["pop"].ToString();
				msg.Send(title + " - " + rain + "% chance of rain - " + forcast 
				+ System.Environment.NewLine 
				+ "-----------------------------------------------");
			}
		});
	}
);

robot.Hear(@"radar (me|at|for|in) (.*)", msg => 
	{		
		var wuparams = msg.Match[2].Split(',');
		var state = wuparams[1].Trim();
		var city = wuparams[0].Trim().Replace(" ","_");
		
		var url = "http://api.wunderground.com/api/" + key + "/radar/q/" + state + "/" + city + ".png";
		
		msg.Send(url);
	}
);

robot.AddHelp(
    "weather (me|at|for|in) City, State - shows you an image of the thing you searched for"
);

/*
		
		*/