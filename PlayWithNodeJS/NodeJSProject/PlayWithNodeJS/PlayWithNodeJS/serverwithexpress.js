console.log("Hello World");

var http = require("http");
var express = require("express");
var app = express();

app.get("/", function(req, res) {
    console.log("here is URL" + req.url);
    res.send("<html><body><h1> express </h1> <br> <h2> Here is url "+ req.url+"</h2></body></html>");
});
app.get("/customURL", function (req, res) {
    console.log("here is your custom URL" + req.url);
    res.send("<html><body><h1> express </h1> <br> <h2> Here is url " + req.url + "</h2></body></html>");
});
app.get("/api/getData", function (req, res) {
    console.log("here is your API URL" + req.url);
    res.set("Content-Type","application/json");
    res.send({name:"sujith",isValid:true, age:"25"});
});

var server = http.createServer(app);
server.listen(3000);