"use strict";

//var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

const connection = new signalR.HubConnectionBuilder().withUrl("/chathub").configureLogging(signalR.LogLevel.Debug).withAutomaticReconnect().build();



connection.onreconnecting(error => {
    console.assert(connection.state === signalR.HubConnectionState.Reconnecting);

    document.getElementById("messageInput").disabled = true;

    const li = document.createElement("li");
    li.textContent = `Connection lost due to error "${error}". Reconnecting.`;
    document.getElementById("messageList").appendChild(li);
});



document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);

    li.textContent = `${user} says ${message}`;
});

//---------video--------

connection.on("ReceiveVideo", (user, videoUrl) => {
   
    const receivedVideoElement = document.getElementById("receivedVideo");
    receivedVideoElement.src = videoUrl;
    receivedVideoElement.play();
});





connection.start().then(function () {
    document.getElementById("sendvideo").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});





document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;

    //----------
    document.getElementById("receivedVideo").disabled = true; 

    connection.invoke("SendMessage", user, message).catch(function (err) {

        return console.error(err.toString());
    });
    event.preventDefault();
});


document.getElementById("receivedVideo").disabled = true;  //---

document.getElementById("videoInput").addEventListener("change", async (event) => {
    document.getElementById("receivedVideo").disabled =false;
    const user = document.getElementById("userInput").value;
    const videoFile = event.target.files[0];

    if (videoFile) {
        
        const formData = new FormData();
        formData.append("user", user);
        formData.append("video", videoFile);

        await fetch("/uploadVideo", {
            method: "POST",
            body: formData
        });
    }

//-------



