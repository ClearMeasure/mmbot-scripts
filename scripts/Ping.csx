var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

robot.Respond(@"PING$",msg => msg.Send("PONG"));

robot.Respond(@"ECHO (.*)$", msg => msg.Send(msg.Match[1]));

robot.Respond(@"TIME$", msg => msg.Send(string.Format("Server time is: {0} {1}", DateTime.Now.ToString("F"), TimeZoneInfo.Local.DisplayName)));

robot.Respond(@"DIE$", msg => Environment.Exit(0));

robot.Respond(@"RESPAWN$", msg => {msg.Finish(); robot.Reset(); });

robot.Hear(@"ROLL CALL$", msg => msg.Send(msg.Random(new[]{"I'm here", "present", "ready and waiting", "sup", robot.Name + " is alive", "yo", "I'm awake", "reporting in", "howdy"})));

robot.AddHelp(
    "rosie ping -  Reply with pong",
    "rosie echo <text> - Reply back with <text>",
    "rosie time - Reply with current time",
    "rosie die - End rosie process"
);
