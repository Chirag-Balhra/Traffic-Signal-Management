var count = 0;
var interval = 10;
var curr = 0;
var next = 0;
var direction = "ClockWise";
var directions = ["A", "B", "C", "D"];

function init(i, d) {
    interval = i;
    direction = d;
    reset();
}
$(document).ready(function () {
    console.log("ready!");
    window.setInterval(function () {
        count++;

        $("#time").text(count);
        $("#rtime").text(interval - count);

        if (count >= interval) {
            reset();
        }
        $("#cur").text(directions[curr]);
        $("#nxt").text(directions[next]);

    }, 1000);

});

function reset() {
    count = 0;
    curr = next;
    switch (direction) {
        case "ClockWise":
            next = (curr + 1) % 4;
            break;
        case "AntiClockwise":
            next = (curr - 1) % 4;
            break;
        case "Leftandright":
            if (curr == 0) {
                next = 2;
            }
            else {
                next = 0;
            }
            break;
        case "UpandDown":
            if (curr == 1) {
                next = 3;
            }
            else {
                next = 1;
            }
            break;
    }
}