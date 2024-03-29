using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Geekbeing.Pusher.LiveChat.Web.Models
{
    // To quickly get started building a Single Page Application based on the following model
    // class, build your solution (Build -> Build Solution), then right-click on the "Controllers" folder, 
    // choose Add -> Controller, and set the following options:
    //
    //  * Controller name:    TasksController
    //  * Template:           Single Page Application with read/write actions and views, using Entity Framework
    //  * Model class:        TodoItem (Geekbeing.Pusher.LiveChat.Web.Models)
    //  * Data Context class: Choose <New data context...>, then click OK
    //
    // Afterwards, launch your application (Debug -> Start Debugging), then browse to the URL /Tasks
    // For more information, see http://go.microsoft.com/fwlink/?LinkId=238343

    public class TodoItem
    {
        public int TodoItemId { get; set; }
        [Required]
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
