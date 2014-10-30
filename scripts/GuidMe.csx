var robot = Require<Robot>();

robot.Hear(@"GUID ME$",msg => {
	var g = Guid.NewGuid();
	msg.Send(g.ToString());
});

robot.AddHelp(
    "guid me - generates a guid"
);