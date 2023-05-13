

document.addEventListener('DOMContentLoaded', function () { 
    var kol = document.querySelector("#test");

    kol.innerHTML += "<button class='button buttonkol_size' id='but0' onclick='event.stopPropagation()'>but0</button>";
  
    //стирает все!
    kol.innerHTML += "<button class='button buttonkol_size'  onclick='event.stopPropagation()'>but1</button>";

    var but0 = document.querySelector("#but0");

    console.log(this+" l     but0 = " + but0);
    but0.addEventListener("click", RemoveButton);
    
});
function RemoveButton(event) {

    event.stopPropagation();
    

    var kol = document.querySelector("#test");
    var but0 = document.querySelector("#but0");
    kol.removeChild(but0);
    kol.innerHTML += "<button>but2</button>";
}
console.log("Test" + funDeclaration());

function funDeclaration() {
    return "ZZ";
}
let express = function funExpression() {
    return "KK";
}
console.log("0l = " + express());


