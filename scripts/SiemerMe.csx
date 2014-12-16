var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

var pics = new [] {
	"http://www.andrewsiemer.com/Themes/AndrewSiemer/Images/PageHeaders/Cowboy.jpg",
	"http://d13pix9kaak6wt.cloudfront.net/avatar/users/a/n/d/andrewsiemer_1410868607_63.png",
	"http://gwb.blob.core.windows.net/andrewsiemer/WindowsLiveWriter/WindowsLiveWriterknowofabetterblogauthor_A417/AndrewSiemer_Old_2.jpg",
	"https://a1-images.myspacecdn.com/images03/3/c970e36aed0f4e1294a9aa00e330c36b/300x300.jpghttp://d13pix9kaak6wt.cloudfront.net/background/users/a/n/d/andrewsiemer_1410867339_2.jpg",
	"http://gwb.blob.core.windows.net/andrewsiemer/WindowsLiveWriter/WindowsLiveWriterknowofabetterblogauthor_A417/AndrewSiemer_Logo_2.jpg",
	"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQC_lnoSa0YHO7feH44-KDj3jKyoVjCgqGGHHOiLnNSME1kUWYpYg",
	"https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcT8wSx8XL0uR7KbtkUvgUgGgO6Ljy3otQ86tplaRameD0DEzXZM1A"
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