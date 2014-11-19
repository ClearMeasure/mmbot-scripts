var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

robot.Hear(@"WHO DO YOU LOVE$",msg => msg.Send("#LoveClearMeasure"));

robot.AddHelp(
    "mmbot who do you love -  #LoveClearMeasure"
);
