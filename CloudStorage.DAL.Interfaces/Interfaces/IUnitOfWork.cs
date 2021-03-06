﻿using CloudStorage.DAL.Interfaces.Models;

namespace CloudStorage.DAL.Interfaces.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<User> Users { get; set; }
        IRepository<File> Files { get; set; }
        void Save();
    }
}
