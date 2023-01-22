window.onload = function () {

    for (var i = 0; i < 3; i++) {
        document.getElementsByClassName("deleteOrder")[i].onclick = function () {

            let caughtThing = document.getElementsByClassName("orderID");

            let id = caughtThing[i - 1].innerHTML;
            console.log(id);

        }
    }
}