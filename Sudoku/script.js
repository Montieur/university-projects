function setGameTable() {

    var gameArea = document.querySelector("#gameArea");
    var gameTable = document.createElement('table');


    for (var i = 1; i < 10; i++){

        if (i == 4 || i == 7){
            gameTable.appendChild(createAltRow(i));
        }
        else {
            gameTable.appendChild(createRow(i));
        }
    }


    gameArea.appendChild(gameTable);
}

function setNumBar(){

    var numBarArea = document.querySelector("#numBarArea");
    var numBarTable = document.createElement('table');
    numBarTable.classList.add("numbar");

    for (let i = 1; i < 10; i++){

        var row = document.createElement('tr');

        var cell = document.createElement('td');
        cell.classList.add("num");

        var anchor = document.createElement('a');
        anchor.classList.add("center");
        anchor.classList.add("fill");
        anchor.innerHTML = i;

        anchor.addEventListener('click', function(){
            setNumber(i);
        })

        cell.appendChild(anchor);
        row.appendChild(cell);

        numBarTable.appendChild(row);

    }

    numBarArea.appendChild(numBarTable);
}

// function checkForWin(){

//     //var cells = document.querySelectorAll('.gameCell');

//     var cells = BoardToArray();

//     var correctCells = GridToArray();

//     // if ( cells == correctCells) return true;
//     // else return false;

//     for (var i = 0; i < GridToArray.length; i++){
//         if (cells[i] != correctCells[i])
//             return false;
//     }

//     return true;

// }

function compareCells(){

    //col, row
    //var selected = document.querySelectorAll('.gameCell');

    var selectedCell = document.querySelector('.selectedCell');

    var classes = document.querySelector('.selectedCell').classList;

    classes.forEach(element => {
        if (element.startsWith("col"))
            selectedColumn = element.substring(4, 5);
        if (element.startsWith("row"))
            selectedRow = element.substring(4, 5);
    });

    var correctCells = GridToArray();

    console.log(correctCells);

    var selectedIndex = (parseInt(selectedRow) - 1) * 9 + parseInt(selectedColumn) - 1;

    console.log(selectedIndex);

    if (correctCells[selectedIndex] == selectedCell.innerHTML)
        return true;
    else
        return false;

}


function createRow(rownum){

    var row = document.createElement('tr');
    
    for (var i = 1; i < 10; i++){

        var cell = document.createElement('td');
        cell.classList.add("gameCell");
        cell.classList.add("unselectedCell");
        cell.classList.add("col-" + i);
        cell.classList.add("row-" + rownum);

        cell.addEventListener('click',
            function(){
                deselectAll();
                this.classList.add("selectedCell");
                this.classList.remove("unselectedCell");

            });


        if (i == 3 || i == 6){
            cell.classList.add("vborder");
        }
        row.appendChild(cell);
    }

    return row;
}

function createAltRow(rownum){

    var row = document.createElement('tr');
    row.classList.add("hborder");
    
    
    for (var i = 1; i < 10; i++){
        
        var cell = document.createElement('td');
        
        cell.classList.add("gameCell");
        cell.classList.add("unselectedCell");
        cell.classList.add("col-" + i);
        cell.classList.add("row-" + rownum);

        cell.addEventListener('click',
            function(){
                deselectAll();
                this.classList.add("selectedCell");
                this.classList.remove("unselectedCell");

            });

        if (i == 3 || i == 6) {
            cell.classList.add("vborder");
        }
        row.appendChild(cell);
    }

    return row;
}

function deselectAll(){

    var gameCells = document.querySelectorAll('.gameCell');
    
    gameCells.forEach(cell => {
        cell.classList.remove("selectedCell");
        cell.classList.add("unselectedCell");
    });

}

function setNumber(number){
    
    var cell = document.querySelector('.selectedCell');
    if (!cell.classList.contains('staticCell')){
        cell.innerHTML = number;
        cell.classList.remove("selectedCell");
        cell.classList.add("unselectedCell");
    }

    //if (checkForWin) console.log('wygrana!');
    
}

function unsetNumber(){
    var cell = document.querySelector('.selectedCell');
    if (cell != null)
    if (!cell.classList.contains('staticCell')){
        cell.innerHTML = "";
        cell.classList.remove("selectedCell");
        cell.classList.add("unselectedCell");
    }
}

function hint(){
    var selectedCell = document.querySelector('.selectedCell');
    var classes = document.querySelector('.selectedCell').classList;

    classes.forEach(element => {
        if (element.startsWith("col"))
            selectedColumn = element.substring(4, 5);
        if (element.startsWith("row"))
            selectedRow = element.substring(4, 5);
    });

    var correctCells = GridToArray();
    var selectedIndex = (parseInt(selectedRow) - 1) * 9 + parseInt(selectedColumn) - 1;

    selectedCell.innerHTML = correctCells[selectedIndex];
}




var tableRows = [];
var startingBoard = [];
var solvedBoard = [];

function generateGrid(){

    ClearBoard();

   
    var diff = document.getElementById("difficultySelect");

    switch (diff.value){

        case "easy":
            fetch('http://127.0.0.1:5000/easy')
                .then(function(response) {
                    return response.json();
                })
                .then(function(json) {
                    startingBoard = json.startingRows;
                    solvedBoard = json.solvedRows;
                    fillGameTable();
                })
            break;

        case "normal":
            fetch('http://127.0.0.1:5000/normal')
                .then(function(response) {
                    return response.json();
                })
                .then(function(json) {
                    startingBoard = json.startingRows;
                    solvedBoard = json.solvedRows;
                    fillGameTable();
                })
            break;

        case "hard":
            fetch('http://127.0.0.1:5000/hard')
                .then(function(response) {
                    return response.json();
                })
                .then(function(json) {
                    startingBoard = json.startingRows;
                    solvedBoard = json.solvedRows;
                    fillGameTable();
                })
            break;

        case "expert":
            fetch('http://127.0.0.1:5000/expert')
                .then(function(response) {
                    return response.json();
                })
                .then(function(json) {
                    startingBoard = json.startingRows;
                    solvedBoard = json.solvedRows;
                    fillGameTable();
                })
            break;

        default:
            break;

    }
}



function GridToArray(){

    var allNumbers = [];

    solvedBoard.forEach(row => {
        row.split("").forEach(digit => {
            allNumbers.push(digit);
        })
    })

    return allNumbers;
}

function BoardToArray(){

    var allCells = [];

    var gamecells = document.querySelectorAll('.gameCell');
    gamecells.forEach(cell => {
        if (cell.innerHTML == "")
            allCells.push("0");
        else
            allCells.push(cell.innerHTML);
        
    })

    console.log(allCells);

    return allCells;

}

function ClearBoard() {
    var allCells = document.querySelectorAll('.gameCell');

    allCells.forEach(cell => {
        cell.innerHTML = "";
    });
    
}

function fillGameTable(){

    var cells = document.querySelectorAll(".gameCell");
    var allRows = [];

    startingBoard.forEach(row => {
        row.split("").forEach(digit => {
            allRows.push(digit);
        })
    })

    //console.log(allRows);
    let i = 0;
    cells.forEach(cell => {

        if(allRows[i] != 0){
            cell.innerHTML = allRows[i];
            cell.classList.add("staticCell");
        }
        i++;
    });
}

