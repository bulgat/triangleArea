

document.addEventListener('DOMContentLoaded', function () { 
    console.log("000 ** g *");
});



function ReqursionQuickSort(array) {
    if (array.length <= 0) {
        return array;
    }
    let pivotIndex = Math.floor(array.length / 2);
    let pivot = array[pivotIndex];
    let less = [];
    let great = [];
    for (var i = 0; i < array.length; i++) {
        if (i === pivotIndex) {
            continue;
        }
        if (array[i] < pivot) {
            less.push(array[i]);
        } else {
            great.push(array[i]);
        }
    }
    return [...ReqursionQuickSort(less), pivot, ...ReqursionQuickSort(great)]
}

var ReqursionSort = ReqursionQuickSort([10, 5, 6, 7, 99]);

console.log("  Reqursion sort = ", ReqursionSort);

//graph sort
const graph = {};
graph.a = ['b', 'c'];
graph.b = ['f'];
graph.c = ['d', 'e'];
graph.d = ['f'];
graph.e = ['f'];
graph.f = ['g'];

function graphSearch(Graph,Start,End) {
    let queue = [];
    queue.push(Start);
    while (queue.length > 0) {
        const current = queue.shift();
        if (!Graph[current]) {
            Graph[current] = [];
        }
       
       // console.log("001 ******", End);
      //  console.log("002 ******", Graph[current].includes(End));
        if (Graph[current].includes(End)) {

            return true;
        } else { 
            console.log("003 ******", queue, " ==  queue[current] = ", queue[current]);
            queue = [...queue, ...graph[current]];
        }
    }
    
}
function clickTarget(event) {
    console.log("Tes ", event.target);
    console.log("Repo   Test", event.currentTarget);
}
console.log("graphSearch ******" + graphSearch(graph, 'a', 'g'));

