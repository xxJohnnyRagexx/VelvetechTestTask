﻿namespace TodoApiDTO.Models
{
    public class TodoItemResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
