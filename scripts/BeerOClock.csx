var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

var beerOClockLocations = new Dictionary<int, string>{
	{-11, "Unalaska, AK"},
	{-10, "Anchorage, AK"},
	{-9, "Adamstown, Pitcairn Islands"},
	{-8, "Los Angeles, Canada"},
	{-7, "Regina, Canada (Ryhmes with...)"},
	{-6, "Austin, TX (Keep it weird Austin)"},
	{-5, "Cary, NC (someone let Derik know)"},
	{-4, "Santiago, Chile"},
	{-3, "Rio de Janero, Brazil"},
	{-2, "Someplace in the middle of the Atlantic"},
	{-1, "Cape Verde, Africa"},
	{0, "London, England"},
	{1, "Paris, France"},
	{2, "Istanbul, Turkey"},
	{3, "Nairobi, Kenya"},
	{4, "Moscow, Russia"},
	{5, "Islamabad, Pakistan"},
	{6, "Dhaka, Bangladesh"},
	{7, "Jakarta, Indonesia"},
	{8, "Singapore, Singapore"},
	{9, "Tokyo, Japan"},
	{10, "Melbourne, Australia"},
	{11, "Wellington, New Zealand"},
	{12, "Honolulu, Hawaii"},
};

robot.Hear(@"(.*)(beer|booze|shot|bourbon|vodka|tequila)(.*)", msg => {
	var message = new StringBuilder();

	var currentTime = DateTime.Now;
	var currentUtcTime = DateTime.UtcNow;
	var beerTime = new DateTime(currentUtcTime.Year, currentUtcTime.Month, currentUtcTime.Day, 17,0,0);
	var hoursToBeerOClock = ( 17 - currentUtcTime.Hour );	

	if( msg.Match[0].Contains("--debug") ){
		message.AppendLine("");
		message.AppendLine("***** DEBUG *****");
		message.AppendLine(string.Format( "Current Beer Time: {0}", beerTime));
		message.AppendLine(string.Format( "Current Utc Time: {0}", currentUtcTime));
		message.AppendLine(string.Format( "Current Local Time: {0}", DateTime.Now));
		message.AppendLine(string.Format( "UTC Offset to Beer o'Clock: {0}", hoursToBeerOClock));

		message.AppendLine("***** DEBUG *****");
		message.AppendLine("");
	}

	if( currentTime.CompareTo(beerTime) < 0 ){				
		message.AppendLine( "Isn't it a little early to be talking about drinking?");
	
		if( beerOClockLocations.ContainsKey(hoursToBeerOClock) ){
			var location = beerOClockLocations[hoursToBeerOClock];
		
			message.AppendLine(string.Format("May not be 5 o'clock here, but if you pretend you live in {0} it is all good.  Drink up!!!", location));
		}
	}
	else 
	{
		message.AppendLine("Drink Up and pour one for me.");
	}

	msg.Send(message.ToString());
});
