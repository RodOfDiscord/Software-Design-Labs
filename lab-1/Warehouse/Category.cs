﻿namespace Warehouse
{
    public class Category
    {
        public Guid Id { get; }
        public string Name { get; set; }

        public Category(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
