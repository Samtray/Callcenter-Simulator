import { AVG_CALLS_PER_HOUR, RANDOM_CALL_TIMES } from "./constants.js";

// pseudo gaussian random function. 
// this averages out the amount of calls per hour. Making a smooth curve.
// the higher the amount of random calls.
// The smoother the curve and the seamless the randomness is 

export function gaussianRand() {
  var remainingRandomCalls=RANDOM_CALL_TIMES;
  var accumulator = 0;
  while(remainingRandomCalls--){
      accumulator+=Math.random();
  }
  return AVG_CALLS_PER_HOUR * accumulator / RANDOM_CALL_TIMES; 
}