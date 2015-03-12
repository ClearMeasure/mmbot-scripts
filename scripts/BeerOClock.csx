var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

robot.Hear(@"(beer|booze|drink|shots)",msg => {	
	msg.Send("Did someone mention beer?");
});

robot.AddHelp(
	"Beer-O-Clock - Will listen for keywords (beer, booze, drink, shots) in conversations let you know if it is beer o'clock"
);