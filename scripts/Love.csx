var robot = Require<Robot>();

robot.Hear(@"WHO DO YOU LOVE$",msg => msg.Send("#LoveClearMeasure"));

robot.AddHelp(
    "mmbot who do you love -  #LoveClearMeasure"
);
