"use strict";

//const { Button } = require("bootstrap");

/*const bigNumber = 1000000;
let myNumber = 34;

const myName = "Basse";

let isHungry = true;

const me = {
  namn: "Basse",
  height: 175,
  heightType: "metric centimeters",
  isHungry: false,
};

if (me.isHungry >= 180) {
  console.log("Välkommen in på klubben!");
}*/ /*Ignore code above*/

/*const userName = prompt("What is your name?");
alert("Welcome " + userName);
const correctName = confirm("Is your name correct?");
if (!correctName) alert("Sorry!");*/

/*addNewItem(prompt("What is your new task?"));

function printTodos() {
  let allTodos = "";
  for (let i = 0; i < todo.length; i++) {
    allTodos +=
      i + 1 + ". " + todo[i].text + ", Done: " + todo[i].isDone + "\n";
  }
  alert(allTodos);
}*/

//const ul = document.querySelector(".todo-List");
//Method 1
/*const newLi = document.createElement("li");
newLi.textContent = "Test of new Li";
newLi.classList.add("todo-Item");
ul.append(newLi);*/
//Method 2
/*const word = "Ta vaccinspruta";
ul.innerHTML += `
<li class="todo-Item">
  <label for="checkTodo">${word}</label>
  <input type="checkbox" id="checkTodo" />
</li>
`;*/
//Method 3
//const word = "Ät glass";
//ul.insertAdjacentHTML(
//  "beforeend",
//  /*html*/ `<li class="todo-Item">
//  <label for="checkTodo">${word}</label>
//  <input type="checkbox" id="checkTodo" />
//</li>`
//);
//Programflöde
let isRunning = false;
while (isRunning) {
  const userPick = parseInt(prompt("Välj 1 eller 2"));
  if (userPick === 1) {
    //addNewItem(prompt("What is your new task?"));
    todos_To_HTML(prompt("What is your new task?"));
  } else if (userPick === 2) {
    checkOffTodo(prompt("what number is the todo to check off?"));
  } else {
    isRunning = false;
  }
}

document.getElementById("submit-Button").onclick = function () {
  let textFromInput = document.getElementById("todo-Text").value;
  todos_To_HTML(textFromInput);
  document.getElementById("todo-Text").value = "";
};

function todos_To_HTML(todo_Text) {
  const list = document.querySelector(".todo-List");
  list.insertAdjacentHTML(
    "beforeend",
    /*html*/ `<li class="todo-Item">
      <label for="checkTodo">${todo_Text}</label>
      <input type="checkbox" id="checkTodo" />
    </li>`
  );
}
