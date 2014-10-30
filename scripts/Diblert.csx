/**
* <description>
*     Gets the latest dilbert comic
* </description>
*
* <commands>
*     mmbot dilbert
*     mmbot dilbert latest
* </commands>
* 
* <author>
*     dkarzon
* </author>
*/

var robot = Require<Robot>();

robot.Hear(@"dilbert(\s+latest)?$", msg =>
{
    msg.Http("http://pipes.yahoo.com/pipes/pipe.run?_id=1fdc1d7a66bb004a2d9ebfedfb3808e2&_render=json").GetJson((err, res, body) => {
        
		var firstStrip = body["value"]["items"][0];

        var html = new HtmlAgilityPack.HtmlDocument();
        html.LoadHtml(firstStrip["description"].ToString());

        var imgSrc = html.DocumentNode.SelectSingleNode("//img").Attributes["src"].Value;

        msg.Send(imgSrc);

    });
});