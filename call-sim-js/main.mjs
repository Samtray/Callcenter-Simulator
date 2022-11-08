import { gaussianRand } from "./gaussianRandom.mjs";
import { HOURS_IN_DAY } from "./constants.mjs";
//import { Worker } from "worker_threads";
//////////////
//
// Main thread
//
//////////////

//1. Generate random calls per hour. 
let callsPerHour = Array.from({ length: HOURS_IN_DAY }, () => Math.floor(gaussianRand()));
let currentDate = new Date();

//2. Take the value from current hour index
console.log("Current hour" + currentDate.getHours())
console.log("Current time in milis" + currentDate.getTime())
console.log("Array of calls per hour \n" + callsPerHour);
console.log("Calls in hour" + currentDate.getHours() + ": " + callsPerHour[currentDate.getHours()])

generateCallData(callsPerHour[new Date().getHours()])
    // 3. Create function interval of 1 hr
setInterval(function() {
    // Main Interval
    //3.1 Create new set of calls based on current number of hourly calls

    //for (let i = 0; i < callsPerHour[new Date().getHours()]; i++) {
    generateCallData(callsPerHour[new Date().getHours()]);

    //Current time in millis

    //worker.onError = (e) =>{
    //    console.log(e);
    //}
    //console.log(worker);
    //...
    // sleep worker until (startAt - currentTime) [difference in time] in millis
    // Once start time has begun. Fetch call. the call ID is retrieved and saved 
    // sleep worker until (hangAt - currentTime) [difference in time] in millis
    // fetch hang call from callID
    // kill worker

    //console.log(calls);
    //console.log("Duration " + Math.floor((hangAt - startAt)/1000) + " Seconds");
}, 1000 * 60 * 30);



class Calls {
    constructor(startAt, hangAt) {
        this.phoneNumber = Math.random().toString().slice(2, 11);
        this.startAt = startAt;
        this.hangAt = hangAt;
    }
}

function generateCallData(callsPerHour) {
    for (let i = 0; i < callsPerHour; i++) {
        let currentTime = currentDate.getTime();
        // Create an arbitrary start time (its always after the current time)
        let startAt = currentTime + Math.floor(1000 * 60 * 15 * Math.random());
        // Create an arbitrary hang time (always later than startAt)
        let hangAt = startAt + Math.floor(1000 * 60 * 15 * Math.random())
            // create call instance
        let calls = new Calls(startAt, hangAt)

        //create worker
        let worker = new Worker("workerFetchCall.js");

        //console.log(calls);

        worker.postMessage(calls);
        worker.onmessage = (e) => {
            console.log(e);
        }
    }
}