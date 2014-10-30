var robot = Require<Robot>();

var blurbs = new []{
	"Onion architecture to rule them all!",
	"People aren't resources!",
	"Deliverables, not consulting!",
	"Iteration zero for the win",
	"What are you better at than anybody else?",
	"Write a method from 1 to 100",
	"How can Clear Measure help you reach your personal goals?",
	"Hit me!",
	"A presentation is 50% entertainment!",
	"We can stack our jeeps!",
	""
};

var pics = new [] {
	"https://s3.amazonaws.com/clearmeasure/jeff-me.png",
	"https://s3.amazonaws.com/clearmeasure/jeff-me-2.png"
};

robot.Hear(@"JEFF ME$",msg => {
	msg.Send(msg.Random(blurbs));
	msg.Send(msg.Random(pics));
});

robot.AddHelp(
    "mmbot jeff me - Random palermo ism"
);