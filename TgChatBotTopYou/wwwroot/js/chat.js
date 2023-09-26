"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

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
    };

    const xht = new XMLHttpRequest();
    xht.open("POST", url, true);
    xht.setRequestHeader("Content-type", "application/json; charset=UTF-8");
    xht.send(JSON.stringify(obj));
}

// Отсылаем сообщение в тг
connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    li.textContent = `${user}: ${message}`;
    sendMessage(`${user}: ${message}`);
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