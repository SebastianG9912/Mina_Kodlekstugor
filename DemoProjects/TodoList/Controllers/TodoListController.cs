using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TodoList.Controllers
{
    // TODO förmåga att POST:a nya todos
    // TODO förmåga att en enskild todo
    // TODO implementera hela crud
    [Route("api")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        private List<string> _todoList;

        [Route("todos")]
        [HttpGet]
        public List<string> GetTodos(int? count)
        {
            _todoList = new List<string>
            {
                "Handla mjölk",
                "Spela fiol kl 14:00",
                "Pusha kod"
            };
            int c = count ?? _todoList.Count;

            return _todoList.Take(c).ToList();
        }

        [Route("todos/{index:int}")]
        [HttpGet]
        public ActionResult<string> GetTodo(int index)
        {
            if (index == null)
            {
                return NotFound();
            }

            return _todoList.ElementAt(index);
        }

        //#1
        //För att hämta json objekt som en inparameter
        //så behöver vi en C# klass med samma form,
        //även kallat DTO
        //#2
        //för att permanent lagra den nya todon så
        //behöver vi en dbcontext

        [HttpPost]
        public ActionResult<PostResult> PostTodo(PostInput input)
        {
            return NotFound();
        }

        public class PostInput
        {
            public string Todo { get; set; }
        }

        public class PostResult
        {
            public int Index { get; set; }
            public string Todo { get; set; }
        }
    }
}
