function processData(input) {
    var res = 0;
    var arr = input.split("\n");

    var n = parseInt(arr[0]);
    
    var numbers = arr[1].split(" ");;
    
    for (var i = 0; i < n; i++) {
    	res += parseInt(numbers[i]);
    };

    console.log(res);
} 

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});
function processData(input) {
    var res = 0;
    var arr = input.split("\n");

    var n = parseInt(arr[0]);
    
    var numbers = arr[1].split(" ");
    
    for (var i = 0; i < n; i++) {
    	res += parseInt(numbers[i]);
    };

    console.log(res);
} 

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});
