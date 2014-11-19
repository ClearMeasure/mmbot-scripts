var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

robot.Hear(@"CHEER ME UP$",msg => {
	msg.Send("https://s3.amazonaws.com/clearmeasure/cheer-me-up.jpg");
});

robot.AddHelp(
    "mmbot CHEER ME UP - Rayne and Meagan as kids"
);