"use strict";

//var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
//document.getElementById("sendButton").disabled = true;

const connection = new signalR.HubConnectionBuilder().withUrl("/chathub").configureLogging(signalR.LogLevel.Debug).withAutomaticReconnect().build();



connection.onreconnecting(error => {
    console.assert(connection.state === signalR.HubConnectionState.Reconnecting);
    console.log('onreconnecting started  ');

    const li = document.createElement("li");
    li.textContent = `Connection lost due to error "${error}". Reconnecting.`;
    document.getElementById("messageList").appendChild(li);
});


document.getElementById("sendButton").disabled = true;





connection.on("ReceiveMessage", function (user, message) {



    console.log('message Received ');

    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);

    li.textContent = `${user} says ${message}`;

    console.log('message Received completed ');
});



//connection.on("ReceiveVideo", (user, videoUrl) => {
   
//    const receivedVideoElement = document.getElementById("receivedVideo");
//    receivedVideoElement.src = videoUrl;
//    receivedVideoElement.play();
//});





connection.start().then(function () {

    console.log('connection started');
    document.getElementById("sendButton").disabled = false;
    console.log('connection completed');
}).catch(function (err) {
    return console.error(err.toString());
});




document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
 
    console.log('before invoke');
    connection.invoke("SendMessage", user, message).catch(function (err) {


        console.log('inside function  invoke');
        return console.error(err.toString());
    });
    console.log('after invoke');
    event.preventDefault();
});






//document.getElementById("receivedVideo").disabled = true;  //---

//document.getElementById("videoInput").addEventListener("change", async (event) => {
//    document.getElementById("receivedVideo").disabled = false;
//    const user = document.getElementById("userInput").value;
//    const videoFile = event.target.files[0];

//    if (videoFile) {

//        const formData = new FormData();
//        formData.append("user", user);
//        formData.append("video", videoFile);

//        await fetch("/uploadVideo", {
//            method: "POST",
//            body: formData
//       });
//});







connection.on("Receiveurl", function (user, message) {
    document.addEventListener("DOMContentLoaded", function () {
        const mediaContainer = document.getElementById("mediaContainer");
        const timeline = document.querySelector(".timeline");

        function createMediaElement(url, type) {
            const mediaElement = document.createElement(type);
            mediaElement.src = url;
            mediaElement.controls = true;
            return mediaElement;
        }

        document.getElementById("appendButton").addEventListener("click", function () {
            const imageUrl = document.getElementById("imageUrlInput").value;
            const videoUrl = document.getElementById("videoUrlInput").value;
            const textContent = document.getElementById("textContentInput").value;

            const mediaElement = document.createElement("div");
            mediaElement.className = "media-element";

            if (imageUrl) {
                const imgElement = document.createElement("img");
                imgElement.src = imageUrl;
                imgElement.alt = "Image";
                mediaElement.appendChild(imgElement);
            }

            if (videoUrl) {
                const videoElement = createMediaElement(videoUrl, "video");
                mediaElement.appendChild(videoElement);
            }

            if (textContent) {
                const textElement = document.createElement("p");
                textElement.textContent = textContent;
                mediaElement.appendChild(textElement);
            }

            // Like, Dislike, and Comment buttons
            const likeButton = document.createElement("button");
            likeButton.textContent = "Like";
            likeButton.className = "btn btn-secondary";
            mediaElement.appendChild(likeButton);

            const dislikeButton = document.createElement("button");
            dislikeButton.textContent = "Dislike";
            dislikeButton.className = "btn btn-secondary";
            mediaElement.appendChild(dislikeButton);

            const commentInput = document.createElement("input");
            commentInput.type = "text";
            commentInput.placeholder = "Enter your comment";
            commentInput.className = "form-control";
            mediaElement.appendChild(commentInput);

            const commentButton = document.createElement("button");
            commentButton.textContent = "Comment";
            commentButton.className = "btn btn-primary";
            mediaElement.appendChild(commentButton);

            // Create timeline item
            const timelineItem = document.createElement("li");
            timelineItem.className = "timeline-item";

            const timestamp = new Date().toLocaleString();
            const activityText = imageUrl ? "added an image" : videoUrl ? "added a video" : "posted text content";

            timelineItem.innerHTML = `
                        <div class="timeline-content">
                            <p><strong>User</strong> ${activityText} - ${timestamp}</p>
                        </div>
                    `;

            timeline.appendChild(timelineItem);

            mediaContainer.appendChild(mediaElement);
        });
    });


    console.log('Receiveurl Received ');

    var li = document.createElement("li");


    document.getElementById("messagesList").appendChild(li);

    li.textContent = `${user} says ${message}`;

    console.log(' Receiveurl completed ');
});













document.getElementById("appendButton").addEventListener("click", function (event) {
    var image = document.getElementById("imageUrlInput").value;
    var video = document.getElementById("videoUrlInput").value;
    var text = document.getElementById("textContentInput").value;

    console.log('before invoke Sendurltoall');
    connection.invoke("Sendurltoall", text, image).catch(function (err) {


        console.log('inside function  invoke');
        return console.error(err.toString());
    });
    console.log('after invoke Sendurltoall');
    event.preventDefault();
});




































    