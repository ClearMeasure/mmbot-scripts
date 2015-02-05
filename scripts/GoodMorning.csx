var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

var pics = new [] {
	"http://1.bp.blogspot.com/-QZScgcWodAg/UZu0R2DaJOI/AAAAAAAAAIw/57rwaNQNyx8/s1600/Sunrise+landscape+render+retouches.png",
	"http://media1.santabanta.com/full1/Outdoors/Sunrise/sunrise-2a.jpg",
	"http://thelegacyletters.com/freshcutgrass/wp-content/uploads/2014/01/sunrise-image.jpg",
	"http://th07.deviantart.net/fs70/PRE/f/2013/052/2/f/into_the_sunrise_by_kkart-d5vpjxr.png",
	"http://bestwallpaperhd.com/wp-content/uploads/2012/12/desert-sunrise-wallpaper.jpg",
	"http://www.mrwallpaper.com/wallpapers/Dolphin-Jump-Sunrise.jpg",
	"http://explosionhub.com/wp-content/uploads/2012/06/sun-rising-600x250.jpg",
	"http://www.mrwallpaper.com/wallpapers/Sunrise-Railroad-1920x1080.jpg",
	"http://upload.wikimedia.org/wikipedia/commons/3/35/Port_Lincoln_Town_Jetty_at_Sunrise_-_South_Australia.jpg",
	"https://seanchow.files.wordpress.com/2013/07/sunrise.jpg",
	"http://3.bp.blogspot.com/-E9acoXVu3PY/VB6_nc_Pq1I/AAAAAAAAAj4/N9XhxNXjv88/s1600/moving%2B012.JPG",
	"http://www.citadelkalahari.com/wp-content/uploads/2013/10/DSCN8909-2.jpg",
	"http://morningbrayfarm.files.wordpress.com/2010/12/winter-solstice-sunrise3.jpg",
	"http://www.eonline.com/eol_images/Entire_Site/2013229/rs_560x415-130329112002-1024.BabyPig5.mh.032913.jpg",
	"http://cl.jroo.me/z3/2/A/F/e/a.baa-Baby-Piglet-Eats-Ice-Cream-D.jpg",
	"http://www.eonline.com/eol_images/Entire_Site/2013229/rs_560x415-130329112005-1024.BabyPig1.mh.032913.jpg",
	"http://s3-ec.buzzfed.com/static/imagebuzz/web04/2010/11/8/17/sleeping-baby-kitten-11858-1289254224-48.jpg",
	"http://images4.fanpop.com/image/photos/19700000/baby-kitten-baby-animals-19796886-339-254.jpg",
	"http://desktopwallpapers.biz/wp-content/uploads/2014/08/Baby-Duck-Free.jpg"	
};

robot.Hear(@"(.*)GOOD MORNING(.*)",msg => {
	msg.Send(msg.Random(pics));
});

robot.Hear(@"(.*)VGM(.*)",msg => {
	msg.Send(msg.Random(pics));
});

robot.AddHelp(
    "good morning - Random sunrise"
);
