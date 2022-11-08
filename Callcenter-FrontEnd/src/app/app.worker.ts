/// <reference lib="webworker" />

addEventListener('message', ({ data }) => {
  console.log(data)
  let currentTime = new Date();
  // 3.3.1 sleep worker until (startAt - currentTime) miliseconds
  console.log("[Start Call] Sleeping " + Math.floor(Math.abs(data.startAt - currentTime.getTime()) / 1000) + " Seconds");

  let fd = new FormData();
  fd.append("phonenumber", data.phoneNumber);

  setInterval(function () {
      // 3.3.2 fetch start call
      console.log("fetching start call");

      fetch("https://localhost:7112/api/ReceiveCall",
          { method: "post", body: fd }
      ).then((data) => {
          console.log(data)
      }).catch((error) => {
          console.log(error)
      });

  }, Math.floor(Math.abs(data.startAt - currentTime.getTime())));

  fd.append("statusendid", "0");

  // 3.3.3 use Fetched data as needed
  // ... [Modify as required]
  ///////////////////////////////////

  //3.3.4 sleep until (hangAt - startAt) milis
  console.log("[Hang Call] Sleeping " + Math.floor(Math.abs(data.hangAt - data.startAt) / 1000) + " Seconds");
  setInterval(function () {
      //3.3.5 fetch hang call of call ID from last fetch
      console.log("Fetching hang call")
      fetch("https://localhost:7112/api/EndCall",
          { method: "post", body: fd }
      ).then((data) => {
          console.log(data)
      }).catch((error) => {
          console.log(error)
      });
  }, Math.floor(Math.abs(data.hangAt - currentTime.getTime())));

  postMessage("Message received");
});
