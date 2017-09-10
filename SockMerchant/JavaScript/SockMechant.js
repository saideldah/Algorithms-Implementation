process.stdin.resume();
process.stdin.setEncoding('ascii');

var input_stdin = "";
var input_stdin_array = "";
var input_currentline = 0;

process.stdin.on('data', function(data) {
    input_stdin += data;
});

process.stdin.on('end', function() {
    input_stdin_array = input_stdin.split("\n");
    main();
});

function readLine() {
    return input_stdin_array[input_currentline++];
}

/////////////// ignore above this line ////////////////////

function sockMerchant(n, ar) {
    var pairs = 0;
    for (var i = 0; i < n; i++) {
        for (var j = i + 1; j < n; j++) {
            if (ar[i] == ar[j] && ar[i] > 0) {
                pairs++;
                ar[i] = -1;
                ar[j] = -1;
                break;
            }
        }
    }
    return pairs;
}

function main() {
    var n = parseInt(readLine());
    ar = readLine().split(' ');
    ar = ar.map(Number);
    var result = sockMerchant(n, ar);
    process.stdout.write("" + result + "\n");

}