"use strict";

//var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
//document.getElementById("sendButton").disabled = true;

const connection = new signalR.HubConnectionBuilder().withUrl("/chathub").configureLogging(signalR.LogLevel.Debug).withAutomaticReconnect().build();

const connectedUsers = [];

connection.onreconnecting(error => {
    console.assert(connection.state === signalR.HubConnectionState.Reconnecting);
    console.log('onreconnecting started  ');

    const li = document.createElement("li");
    li.textContent = `Connection lost due to error "${error}". Reconnecting.`;
    document.getElementById("messageList").appendChild(li);
});


document.getElementById("sendButton").disabled = true;





connection.on("ReceiveMessage", function (user, message, messageCount) {

    document.getElementById("message-count").innerText = `Message Count: ${messageCount}`;

    console.log('message Received ');

    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);

    li.textContent = `${user}  says ${message}`;

    console.log('message Received completed ');
});








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







connection.on("Receiveurl", function (image, video, text, userId) {
    var imageUrl = image;
    var videoUrl = video;
    var textcontent = text;


    const mediaContainer = document.getElementById("mediaContainer");
    const timeline = document.querySelector(".timeline");

    function createMediaElement(url, type) {
        const mediaElement = document.createElement(type);
        mediaElement.src = url;
        mediaElement.controls = true;
        return mediaElement;
    }

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
                            <p><strong>User</strong> ${userId}-${activityText} - ${timestamp}</p>
                        </div>
                    `;

    timeline.appendChild(timelineItem);

    mediaContainer.appendChild(mediaElement);



    console.log('Receiveurl Received ');

    console.log('message Received ');

    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);

    li.textContent = `${userId}   ${activityText}`;


    console.log(' Receiveurl completed ');
});




connection.on("ReceiveMessagetospecificuser", (userId, sender, message) => {
    // Handle receiving the message targeted to a specific user
    // You can display the message in a specific chat window or handle it as needed
  //  console.log(`Message for ${userId} - ${sender}: ${message}`);
    console.log('ReceiveMessagetospecificuser');


});



document.getElementById("send-message-button").addEventListener("click", () => {
    const message = document.getElementById("message-input").value;
    const userId = document.getElementById("user-id-input").value;

    // Call the server method to send a message to the specified user
    connection.invoke("SendMessageTospecificUser", userId, message).catch(err => console.error(err));

    // Clear the message input
    document.getElementById("message-input").value = "";
});



connection.on("UpdateConnectedDevicesCount", (connectedDevicesCount) => {
    // Update the UI to display the updated connected devices count
    const devicesCountElement = document.getElementById("devices-count");
    devicesCountElement.textContent = connectedDevicesCount;
});






document.getElementById("appendButton").addEventListener("click", function (event) {
    var image = document.getElementById("imageUrlInput").value;
    var video = document.getElementById("videoUrlInput").value;
    var text = document.getElementById("textContentInput").value;

    console.log('before invoke Sendurltoall');
    connection.invoke("Sendurltoall", image, video, text).catch(function (err) {


        console.log('inside function  invoke');
        return console.error(err.toString());
    });
    console.log('after invoke Sendurltoall');
    event.preventDefault();
});




connection.on("UserConnected", (userId) => {
    // Add the user to the list of connected users
    connectedUsers.push(userId);

    // Update the connected users list
    updateConnectedUsersList();
    populateUserSelect();
    // Display a message indicating that a user has connected
    const chatWindow = document.getElementById("chat-window");
    const messageDiv = document.createElement("div");
    messageDiv.textContent = `${userId} has connected.`;
    chatWindow.appendChild(messageDiv);
});






connection.on("UserDisconnected", (userId) => {
    // Remove the user from the list of connected users
    const index = connectedUsers.indexOf(userId);
    if (index !== -1) {
        connectedUsers.splice(index, 1);
    }

    // Update the connected users list
    updateConnectedUsersList();
    populateUserSelect();
    // Display a message indicating that a user has disconnected
    const chatWindow = document.getElementById("chat-window");
    const messageDiv = document.createElement("div");
    messageDiv.textContent = `${userId} has disconnected.`;
    chatWindow.appendChild(messageDiv);
});





function updateConnectedUsersList() {
    const userList = document.getElementById("user-list");
    userList.innerHTML = ""; // Clear the list
    for (const userId of connectedUsers) {
        const userItem = document.createElement("li");
        userItem.textContent = userId;
        userList.appendChild(userItem);
    }
}






function populateUserSelect() {
    const selectElement = document.getElementById("private-chat-user");
    selectElement.innerHTML = '<option value="">Select a user</option>';
    for (const userId of connectedUsers) {
        const option = document.createElement("option");
        option.value = userId;
        option.textContent = userId;
        selectElement.appendChild(option);
    }
}





document.getElementById("open-private-chat-btn").addEventListener("click", () => {
    const selectedUserId = document.getElementById("private-chat-user").value;

    if (selectedUserId) {
        openPrivateChatWindow(selectedUserId);
    }
});





connection.on("UpdateMessageLikes", function (messageId, likeCount) {
    // Update like count in the UI
    const likeCountElement = document.getElementById(`like-count-${messageId}`);
    likeCountElement.textContent = likeCount;
});

connection.on("UpdateMessageDislikes", function (messageId, dislikeCount) {
    // Update dislike count in the UI
    const dislikeCountElement = document.getElementById(`dislike-count-${messageId}`);
    dislikeCountElement.textContent = dislikeCount;
});

// Attach event listeners to dynamically created like and dislike buttons
// Like button event listener




likeButton.addEventListener("click", function () {

    console.log('likeddddddddddddddddd');

    // Handle Like button click
});




// Dislike button event listener
dislikeButton.addEventListener("click", function () {
    // Handle Dislike button click
    console.log('dislikeddddddddddddddddd');

});




// Comment button event listener
commentButton.addEventListener("click", function () {
    const commentText = commentInput.value;
    // Handle Comment button click with the commentText
    console.log('cmmented..............');

});




document.getElementById("joinButtongroup").addEventListener("click", async () => {
    var groupName = document.getElementById("groupName").value;
    await connection.invoke("JoinGroup", groupName);
});

// Send a message to the group
document.getElementById("sendButtongroup").addEventListener("click", async () => {
    var groupName = document.getElementById("groupName").value;
    var message = document.getElementById("messageInputgroup").value;
    await connection.invoke("SendMessageToGroup", groupName, message);
});

// Handle incoming messages
connection.on("ReceiveMessage", (message) => {
    var messageElement = document.createElement("li");
    messageElement.textContent = message;
    document.getElementById("messagesListgroup").appendChild(messageElement);
});










