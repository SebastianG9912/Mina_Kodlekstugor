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

function checkOffTodo(nmbr) {
  if (nmbr < 1 || nmbr > todo.length) {
    alert("illegal input of index!");
    return;
  }
  todo[nmbr - 1].isDone = true;
  console.log(todo);
}
