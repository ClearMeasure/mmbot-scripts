var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

robot.Hear(@"GUID ME$",msg => {
	var g = Guid.NewGuid();
	msg.Send(g.ToString());
});

robot.AddHelp(
    "guid me - generates a guid"
);