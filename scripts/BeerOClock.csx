var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

var beerOClockLocations = new Dictionary<int, string>{
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
	var currentUtcTime = DateTime.UtcNow;
	var beerTime = new DateTime(currentUtcTime.Year, currentUtcTime.Month, currentUtcTime.Day, 17,0,0);

	if( currentUtcTime.CompareTo(beerTime) < 0 ){
		var hoursToBeerOClock = ( 17 - currentUtcTime.Hour );		
		
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
