var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

var blurbs = new []{
	"http://c.tadst.com/gfx/600x400/christmas.jpg?1",
	"http://www.joniskelis.lt/wp-content/uploads/2012/12/christmas.jpg",
	"http://nisha.pl/wp-content/uploads/2014/09/choinka.jpg",
	"http://1.bp.blogspot.com/-Optnfnfj5IM/ULzLBFYNdkI/AAAAAAAAB3Y/uRFE2DywY_c/s1600/amazing+Christmas+decorations.jpg",
	"http://sonumid.sjg.edu.ee/wp-content/uploads/2013/12/Christmas-wallpapers-06.jpg",
	"http://cdn.gretawire.foxnewsinsider.com/wp-content/uploads/2012/11/christmas-tree-wallpaper1024x768-562x421.jpg",
	"http://www.theskintfoodie.com/uploads/2/3/0/0/2300045/7620805_orig.jpg?0",
	"http://www.danburymint.com/secure/Content/ImagesProducts/7501032e-aeb2-4631-becf-9d7e945d9c87.jpg",
	"http://www.txtraders.com/images/MerryChristmasfromTexas-websmall.jpg",
	"http://www.imgion.com/images/01/Choose-One-FOr-Celebration.jpg",
	"http://www.agriphar.com/images/upload/News/christmas-present-male1.jpg",
	"http://www.boathouseatwinona.com/sites/default/files/merry-christmas4_0.jpg",
	"http://www.hollyandpaul.it/wp-content/uploads/2013/12/Christmas-Gift.jpg",
	"http://www.misadventureswithandi.com/wp-content/uploads/2011/12/Merry-Christmas.jpg",
	"http://ouuna.co.uk/new/wp-content/uploads/2014/11/Christmas-Garland.jpg",
	"http://cdn.cutestpaw.com/wp-content/uploads/2011/12/A-lot-of-Christmas-Gifts-l.jpg",
	"http://www.freshfieldsrescue.org.uk/images/uploads/articles/cute_xmas_dog_and_cat.jpg",
	"http://2.bp.blogspot.com/-QddJO2W5nhw/TvRuLxgWrKI/AAAAAAAAAlo/59bAI77Ru30/s72-c/1-christmas-animals-1-1.png",
	"http://www.hdwallpaperscool.com/wp-content/uploads/2013/12/christmas-wish-high-definition-wallpapers-beautiful-desktop-background-images-widescreen.jpg",
	"http://s1.ibtimes.com/sites/www.ibtimes.com/files/styles/v2_article_large/public/2013/12/24/dont-say-christmas-army.jpg?itok=3Wzu3QMd"
};

robot.Hear(@"(.*)christmas(.*)",msg => {
		msg.Send(msg.Random(blurbs));
});

robot.AddHelp(
    "mmbot christmas -  Random xmas pic"
);