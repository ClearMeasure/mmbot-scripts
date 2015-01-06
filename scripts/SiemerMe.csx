var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

var pics = new [] {
	"http://www.andrewsiemer.com/Themes/AndrewSiemer/Images/PageHeaders/Cowboy.jpg",
	"http://d13pix9kaak6wt.cloudfront.net/avatar/users/a/n/d/andrewsiemer_1410868607_63.png",
	"http://gwb.blob.core.windows.net/andrewsiemer/WindowsLiveWriter/WindowsLiveWriterknowofabetterblogauthor_A417/AndrewSiemer_Old_2.jpg",
	"http://gwb.blob.core.windows.net/andrewsiemer/WindowsLiveWriter/WindowsLiveWriterknowofabetterblogauthor_A417/AndrewSiemer_Logo_2.jpg"
};

robot.Hear(@"Siemer Me(.*)",msg => {
	msg.Send(msg.Random(pics));
});

robot.Hear(@"VGM(.*)",msg => {
	msg.Send(msg.Random(pics));
});

robot.AddHelp(
    "Andrew Siemer the man"
);