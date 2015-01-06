using Humanizer;

var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

robot.Hear(@"Humanize (.*)",msg => {
	try 
	{
		DateTime dt = Convert.ToDateTime(msg.Match[1]);
		if(dt != null)
		{
			msg.Send(dt.Humanize());
		}
	}
	catch(Exception e)
	{
		msg.Send(msg.Match[1].Humanize());
	}
});

robot.AddHelp(
    "Humanize turns your string into something more readable!"
);