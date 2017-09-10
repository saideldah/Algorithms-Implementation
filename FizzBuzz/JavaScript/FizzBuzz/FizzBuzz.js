/**
 * Created by saeed on 12/4/2016.
 */

var fizzBuzz = function(n) {
    var strList = [];
    for(var i =1 ; i<= n ; i++){
        if (i % 3 == 0 && i % 5 == 0)
        {
            strList.push("FizzBuzz");
        }
        else if (i%3 == 0)
        {
            strList.push("Fizz");
        }
        else if (i%5 == 0)
        {
            strList.push("Buzz");
        }
        else
        {
            strList.push(i);
        }
    }
    return strList;
};


var fb = fizzBuzz(15);

for(var i = 0 ; i< fb.length ; i++){
    console.log(fb[i]);
}
