"use strict";

require("dotenv-extended").load();
const restify = require("restify");
const { ChatConnector, UniversalBot } = require("botbuilder");

const botSettings = {
  appId: process.env.MicrosoftAppId,
  appPassword: process.env.MicrosoftAppPassword
};
const connector = new ChatConnector(botSettings);
const server = restify.createServer();
server.listen(process.env.port || process.env.PORT || 3978, () => {
  console.log("%s listening to %s", server.name, server.url);
});
server.post("/api/messages", connector.listen());

const bot = new UniversalBot(connector, (session, response, next) => {
  session.send("You said: %s", session.message.text);
});
