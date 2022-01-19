const milk = {
  text: "handla mjölk",
  isDone: false,
};

const reclaim = {
  text: "reklamera looper-pedal",
  isDone: false,
};

const vaccine = {
  text: "covid19 tredje vaccin",
  isDone: false,
};

const todo = [milk, reclaim, vaccine];

function copy(obj) {
  const str = JSON.stringify(obj);
  const cpy = JSON.parse(str);
  return cpy;
}
todo[0].isDone = true;
console.log(todo);
console.log(copy(todo));

function addNewItem(whatToDo) {
  todo.push({
    text: whatToDo,
    isDone: false,
  });
  console.log("new task: " + whatToDo + ", entered");
}

const newTask = "gå ut med hunden";

addNewItem(newTask);
console.log(todo);

/*const userName = prompt("What is your name?");
alert("Welcome " + userName);
const correctName = confirm("Is your name correct?");
if (!correctName) alert("Sorry!");*/

addNewItem(prompt("What is your new task?"));

let allTodos = "";
for (let i = 0; i < todo.length; i++) {
  allTodos += i + 1 + ". " + todo[i].text + ", Done: " + todo[i].isDone + "\n";
}
alert(allTodos);

const userPick = prompt("Välj 1 eller 2");
if (userPick == 1) {
  addNewItem(prompt("What is your new task?"));
} else if (userPick == 2) {
  checkOffTodo(prompt("what number is the todo to check off?"));
} else {
  alert("illegal answer");
}

function checkOffTodo(nmbr) {
  if (nmbr < 1 || nmbr > todo.length) {
    alert("illegal input of index!");
    return;
  }
  todo[nmbr - 1].isDone = true;
}
console.log(todo);
