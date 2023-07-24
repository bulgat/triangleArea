

document.addEventListener('DOMContentLoaded', function () { 
    var kol = document.querySelector("#test");

    kol.innerHTML += "<button class='button buttonkol_size' id='but0' onclick='event.stopPropagation()'>but0</button>";
  
    //стирает все!
    kol.innerHTML += "<button class='button buttonkol_size'  onclick='event.stopPropagation()'>but1</button>";

    var but0 = document.querySelector("#but0");

    
    but0.addEventListener("click", RemoveButton);

    function printLog() {
       
        
    }
    printLog();

    var buttonCreateReport = document.querySelector("#CreateReport");
    console.log(" l    t  = " + buttonCreateReport);
    buttonCreateReport.addEventListener("click", CreateReport);
});
function RemoveButton(event) {


    event.stopPropagation();
    

    var kol = document.querySelector("#test");
    var but0 = document.querySelector("#but0");
    kol.removeChild(but0);
    kol.innerHTML += "<button>but2</button>";
}
function CreateReport() {
    console.log("001 CreateReport    Test");
    const req = new XMLHttpRequest;
    req.open("GET", "CreateReport");
    req.send();
    req.addEventListener('readystatechange', function () {
        if (req.readyState == 4) {
            console.log(req.response);
        }
    });
    console.log("002 CreateReport    Test");
}

console.log("Test" + funDeclaration());

function funDeclaration() {
    return "ZZ";
}
let express = function funExpression() {
    return "KK";
}
console.log("0l = " + express());


