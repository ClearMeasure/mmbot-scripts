var robot = Require<Robot>();

robot.Hear(@"CHEER ME UP$",msg => {
	msg.Send("https://s3.amazonaws.com/clearmeasure/cheer-me-up.jpg");
});

robot.AddHelp(
    "mmbot CHEER ME UP - Rayne and Meagan as kids"
);