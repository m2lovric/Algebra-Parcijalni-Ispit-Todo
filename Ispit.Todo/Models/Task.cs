﻿using System.ComponentModel.DataAnnotations;

namespace Ispit.Todo.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string? UserId { get; set; }
        public bool Status { get; set; } = false;
        public string Description { get; set; }
        public int TodoListId { get; set; }
    }
}