var robot = Require<Robot>();

var blurbs = new []{
	"Toodle pip!",
	"I'm all in!",
	"Are you having a laugh?",
	"Oh Andy!?",
	"Royal cock up!",
	"Away with the fairies",
	"Swings and round abouts!",
	"It's horses for courses isn't it?",
	"Bob's your uncle!",
	"Chin wag!",
	"I haven't seen you in donkey's years!",
	"Let's have a butchers at that!",
	"It's monkeys!",
	"Up the wooden hill to bedfordshire",
	"Up the duff",
	"Cheeky monkey!",
	"At sixes and sevens",
	"Oh my giddy aunt!",
	"Shut the front door!",
	"Going on like a big girls blouse",
	"Full marks!"
};

robot.Hear(@"SHAW ME$",msg => {
	msg.Send("http://www.cloudy-movie.com/game/inventionchallenge/img/std/chester_help.png");
	msg.Send(msg.Random(blurbs));
});

robot.AddHelp(
    "mmbot shaw me -  Random English Response"
);