

var connectionUsercount = new signalR.HubConnectionBuilder().withUrl("/Hubs/usercount").build();









//connection.Usercount.on("UpdateTottalViews", (value) => {
//    console.error("Error ..1111111111..................", error);
//    var newcountsspan = document.getElementById("tottalviewCounter");
//    newcountsspan.innerText = value.tostring();
//});


connection.on("UpdateTotalViews", (value) => {
    console.log("Received updated total views:", value);
    var newCountsSpan = document.getElementById("totalViewCounter");
    newCountsSpan.innerText = value.toString();
});



function newwindowloadedonclient() {


       
        connectionUsercount.send("newwindowloaded");
      
        console.log("Connection is  in the 'Connected' state.");
    }




    else {
        connectionUsercount.start()
            .then(() => {
                console.error("Error ....................", error);
                connectionUsercount.send("newwindowloaded");
            })
            .catch(error => {
                console.error("Error starting the SignalR connection:", error);
            });


        console.log("Connection is not in the 'Connected' state.");
    }
}



function fullfilled() {

    console.log("connection to userhub successfull");
    newwindowloadedonclient();
}




function rejected() {
    console.log("connection to userhub failed");
}






connectionUsercount.start().then(fullfilled, rejected);