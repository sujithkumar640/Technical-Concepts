console.log("Hello World");

var http = require("http");
var server = http.createServer(function(req, res) {
    console.log("Request URL" + req.url);
    res.write("<html><body><h1>Here is requested URL" + req.url+"</h1></body></html>");
    res.end();
});
server.listen(3000);