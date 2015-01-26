var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

var pics = new [] {
	"http://www.infocraft.net/wp-content/uploads/2015/01/6.jpg",
	"http://www.infocraft.net/wp-content/uploads/2015/01/5.jpg",
	"http://www.infocraft.net/wp-content/uploads/2015/01/4.png",
	"http://www.infocraft.net/wp-content/uploads/2015/01/3.jpg",
	"http://www.infocraft.net/wp-content/uploads/2015/01/2.gif",
	"http://www.infocraft.net/wp-content/uploads/2015/01/1.gif",
};

robot.Hear(@"WELCOME(.*)",msg => {
	msg.Send(msg.Random(pics));
});

robot.Hear(@"VGM(.*)",msg => {
	msg.Send(msg.Random(pics));
});

robot.AddHelp(
    "welcome - Random welcome sign"
);