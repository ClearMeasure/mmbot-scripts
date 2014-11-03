var robot = Require<Robot>();

var key = robot.GetConfigVariable("MMBOT_WUNDERGROUND_KEY");

robot.Hear(@"weather (me|at|for|in)? (.*)", msg => 
	{
		
		string[] params;
		string state = "";
		string city = "";

		if(msg.Match[1].ToString().Contains(','))
		{
			params = msg.Match[1].ToString().Split(',');
		
			state = params[1].Trim();
			city = params[0].Trim();
			
			var url = "http://api.wunderground.com/api/" + key + "/forecast/q/" + state + "/" + city + ".json";
			
			robot.Http(url).GetJson((err, res, body) => 
			{
				var forecast = body["forecast"];
				var txt_forecast = forecast["txt_forecast"];
				var forecastdays = txt_forecast["forecastday"];
				
				foreach(var day in forecastdays)
				{
					var day = day["title"].ToString();
					var forcast = day["fcttext"].ToString();
					var rain = day["pop"].ToString();
					msg.Send(day + " - " + rain + "% chance of rain - " + forcast 
					+ System.Environment.NewLine 
					+ "-----------------------------------------------");
				}
			});
		}
	}
);

robot.AddHelp(
    "weather (me|at|for|in) City, State - shows you an image of the thing you searched for"
);



robot.respond /weather (me|at|for|in)? ?(.*)$/i, (msg) ->
    location = msg.match[2]
    get_data robot, msg, location, 'forecast', location.replace(/\s/g, '_'), send_forecast, 60*60*2