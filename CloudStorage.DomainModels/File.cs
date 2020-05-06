﻿using System;

namespace CloudStorage.DomainModels
{
    public class File
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Content { get; set; }
    }
}
