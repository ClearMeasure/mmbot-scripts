var robot = Require<Robot>();

var pics = new [] {
	"http://www.allgraphics123.com/graphics/good-luck/good-luck43.png",
	"http://pad1.whstatic.com/images/thumb/6/69/Wish-Someone-Good-Luck-Step-1.jpg/670px-Wish-Someone-Good-Luck-Step-1.jpg",
	"http://www.imagesbuddy.com/images/81/2013/08/keep-calm-and-good-luck-graphic.png",
	"http://telford-ice-skating-club.co.uk/wp-content/uploads/2014/10/good-luck.jpg",
	"http://blogs.bournemouth.ac.uk/research/files/2013/11/Good-Luck-1973933.jpg",
	"http://lowres.cartoonstock.com/animals-luck-lucky-bunny-good_luck-good_luck_charms-gfon374_low.jpg",
	"http://s.twistynoodle.com/img/r/finish-line/good-luck/good-luck_coloring_page_png_468x609_q85.jpg",
	"http://3.bp.blogspot.com/-KpwcrqW_KP4/UFlegJ8Hz_I/AAAAAAAAAD0/CTHS13NuZoE/s1600/chin-up-and-fight-to-win.png",
	"http://dub-sofine.com/great_smile.png",
	"http://4.bp.blogspot.com/-kaRJh-6qZsQ/TtEKTiX98iI/AAAAAAAABcA/ykV2vKVDKoM/s1600/good+luck.JPG"
};

robot.Hear(@"GOOD LUCK$",msg => {
	msg.Send(msg.Random(pics));
});

robot.AddHelp(
    "mmbot good luck - Random good luck image"
);