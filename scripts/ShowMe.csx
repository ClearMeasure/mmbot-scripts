var robot = Require<Robot>();

var pages = new []{1,2,3,4,5,6,7,8,9,10};

robot.Hear(@"SHOW ME (.*)", msg => 
	{
		var start = msg.Random(pages);
		var url = "https://ajax.googleapis.com/ajax/services/search/images?v=1.0&q=" + msg.Match[1] + "&safe=active&start=" + start.ToString();
		robot.Http(url).GetJson((err, res, body) => 
		{
			var response = body["responseData"];
			var results = response["results"];
			var result = results[0];
			var imgurl = result["url"].ToString();
			msg.Send(imgurl);
		});		
	}
);

robot.AddHelp(
    "show me - shows you an image of the thing you searched for"
);