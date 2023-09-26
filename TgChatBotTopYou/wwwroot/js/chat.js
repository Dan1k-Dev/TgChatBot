"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

<<<<<<< HEAD
document.getElementById("sendButton").disabled = true;

let tg = {
    token: "6549211492:AAFtGp6j36GGBi6-0KzI2y-n-9lPWJ6yQTc", // Your bot's token that got from @BotFather
    chat_id: "1272309767" // The user's(that you want to send a message) telegram chat id
}

function sendMessage(text) {
    const url = `https://api.telegram.org/bot${tg.token}/sendMessage` // The url to request

    const obj = {
        chat_id: tg.chat_id, // Telegram chat id
        text: text // The text to send
=======
document.getElementById("sendButton").disabled = true; // Отключать кнопку отсылки сообщения, когда подключение нестабильно

let tg = {
    token: "6549211492:AAFtGp6j36GGBi6-0KzI2y-n-9lPWJ6yQTc", // Токен
    chat_id: "1272309767" // id чат бота
}


function sendMessage(text) {
    const url = `https://api.telegram.org/bot${tg.token}/sendMessage` // url post request 

    const obj = {   
        chat_id: tg.chat_id,
        text: text // Текст, который будет отсылаться
>>>>>>> master
    };

    const xht = new XMLHttpRequest();
    xht.open("POST", url, true);
    xht.setRequestHeader("Content-type", "application/json; charset=UTF-8");
    xht.send(JSON.stringify(obj));
}

<<<<<<< HEAD
=======
// Отсылаем сообщение в тг
>>>>>>> master
connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    li.textContent = `${user}: ${message}`;
<<<<<<< HEAD
    sendMessage(message);
=======
    sendMessage(`${user}: ${message}`);
>>>>>>> master
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

// Обработка ивента кнопки
document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});