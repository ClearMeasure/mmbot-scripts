/**
* <description>
*     Pugme is the most important thing in your life
* </description>
*
* <commands>
*     mmbot pug me - Receive a pug;
      mmbot pug bomb N - get N pugs
* </commands>
* 
* <notes>
*     Ported from https://github.com/github/hubot/blob/master/src/scripts/pugme.coffee
* </notes>
* 
* <author>
*     PeteGoo
* </author>
*/

var robot = Require<Robot>();
robot.Name = robot.GetConfigVariable("MMBOT_ROBOT_NAME");

robot.Hear(@"pug me(.*)", msg =>
{
    msg.Http("http://pugme.herokuapp.com/random").GetJson((err, res, body) => {
        msg.Send((string)body["pug"]);
    });
});

robot.Respond(@"pug bomb( (\d+))?", msg =>
{
    var count = msg.Match.Count() > 2 ? msg.Match[2] : "5";
    msg.Http("http://pugme.herokuapp.com/bomb?count=" + count).GetJson((err, res, body) => {
        foreach(var pug in body["pugs"])
        {
            msg.Send((string)pug);
        }
    });
});

robot.Hear(@"how many pugs are there", msg =>
{
    msg.Http("http://pugme.herokuapp.com/count").GetJson((err, res, body) => {
        msg.Send(string.Format("There are {0} pugs.", body["pug_count"]));
    });
});