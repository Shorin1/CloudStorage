﻿using CloudStorage.DAL.Interfaces.Context;
using CloudStorage.DAL.Interfaces.Interfaces;
using CloudStorage.DomainModels;

namespace CloudStorage.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IApplicationDbContext _dbContext;
        public IRepository<User> Users { get; set; }
        public IRepository<File> Files { get; set; }

        public UnitOfWork(IApplicationDbContext dbContext, IRepository<User> userRepository, IRepository<File> fileRepository)
        {
            _dbContext = dbContext;
            Users = userRepository;
            Files = fileRepository;
        }

        public void Save()
        {
            _dbContext.Save();
        }
    }
}
