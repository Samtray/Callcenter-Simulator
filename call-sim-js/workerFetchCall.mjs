addEventListener("message", (e) => {
    let currentTime = new Date();
    // 3.3.1 sleep worker until (startAt - currentTime) miliseconds
    console.log("[Start Call] Sleeping " + Math.floor(Math.abs(e.data.startAt - currentTime.getTime()) / 1000) + " Seconds");

    let fd = new FormData();
    fd.append("phonenumber", e.data.phoneNumber);

    setInterval(function () {
        // 3.3.2 fetch start call
        console.log("fetching start call");

        fetch("https://localhost:7112/api/ReceiveCall",
            { method: "post", body: fd, credentials: "include" }
        ).then((data) => {
            console.log(data)
        }).catch((error) => {
            console.log(error)
        });

    }, Math.floor(Math.abs(e.data.startAt - currentTime.getTime())));

    fd.append("statusendid", 0);

    // 3.3.3 use Fetched data as needed
    // ... [Modify as required]
    ///////////////////////////////////

    //3.3.4 sleep until (hangAt - startAt) milis
    console.log("[Hang Call] Sleeping " + Math.floor(Math.abs(e.data.hangAt - e.data.startAt) / 1000) + " Seconds");
    set(function () {
        //3.3.5 fetch hang call of call ID from last fetch
        console.log("Fetching hang call")
        fetch("https://localhost:7112/api/EndCall",
            { method: "post", body: fd, credentials: "include" }
        ).then((data) => {
            console.log(data)
        }).catch((error) => {
            console.log(error)
        });
    }, Math.floor(Math.abs(e.data.hangAt - currentTime)));

    //3.3.6 terminate worker
    postMessage("Message received");
    close();
});

addEventListener("error", (e) => {
    console.log("Error");
    console.log(e);
});