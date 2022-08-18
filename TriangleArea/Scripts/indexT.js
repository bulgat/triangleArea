console.log("Test");

document.addEventListener('DOMContentLoaded', function () { 
    var kol = document.querySelector("#test");

    kol.innerHTML = "<button id='but0'>but0</button>";
  
    //стирает все!
    kol.innerHTML += "<button>but1</button>";

    var but0 = document.querySelector("#but0");

    console.log(this+" l     but0 = " + but0);
    but0.addEventListener("click", RemoveButton);
    
});
function RemoveButton() {
    console.log(" l = "+this );

    var kol = document.querySelector("#test");
    var but0 = document.querySelector("#but0");
    kol.removeChild(but0);
    kol.innerHTML += "<button>but2</button>";
}


