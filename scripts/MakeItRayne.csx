var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

robot.Hear(@"MAKE IT RAIN$",msg => {
	msg.Send("https://s3.amazonaws.com/clearmeasure/make-it-rayne.png");
});

robot.AddHelp(
    "mmbot MAKE IT RAIN - Rayne personality pics"
);