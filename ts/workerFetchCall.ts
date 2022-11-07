onmessage = (e) =>{

    let currentTime = new Date();
    // 3.3.1 sleep worker until (startAt - currentTime) miliseconds
    console.log("[Start Call] Sleeping " + Math.floor(Math.abs(e.data.startAt - currentTime.getTime())/1000) + " Seconds");
    setTimeout(()=>{
        // 3.3.2 fetch start call
        console.log("Fetching start call")

    }, Math.floor(Math.abs(e.data.startAt - currentTime.getTime())));
    
    // 3.3.3 use Fetched data as needed
    // ... [Modify as required]
    ///////////////////////////////////

    //3.3.4 sleep until (hangAt - startAt) milis
    console.log("[Hang Call] Sleeping " + Math.floor(Math.abs(e.data.hangAt - e.data.startAt)/1000) + " Seconds");
    setTimeout(()=>{
        //3.3.5 fetch hang call of call ID from last fetch
        console.log("Fetching hang call")
    }, Math.floor(Math.abs(e.data.hangAt - currentTime.getTime())));

    //3.3.6 terminate worker
    postMessage("Message received");
    close(); 
}

onerror = (e) =>{
    console.log("Error"); 
    console.log(e); 
}