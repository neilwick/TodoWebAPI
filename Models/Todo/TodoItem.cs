

namespace TodoWebAPI.Models.Todo {

    public class TodoItem
    {
        public uint TodoItemId { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }

        public virtual Person Responsible { get; set; }
    }
}