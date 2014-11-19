var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

robot.Hear(@"LATIN ME (.*)", msg => 
	{
		var match = msg.Match[1];
		var url = "http://loripsum.net/api/" + match.ToString();
		
		msg.Send(url);
	}
);

robot.AddHelp("latin me - Reply with output "+
	"Supported parameters: "+
	"{int} - number of paragraphs to generate "+
	"short,medium,long,verylong - size of paragraphs "+
	"decorate - add bold, italic, marked text "+
	"link - Add links "+
	"ul - Add unordered lists "+
	"ol - Add numbered lists "+
	"dl - Add description lists "+
	"bq - Add blockquotes "+
	"code - Add code samples "+
	"headers - Add headers "+
	"allcaps - Use ALL CAPS "+
	"prude - Prude version "+
	"plaintext - Return plain text, no HTML"
);

