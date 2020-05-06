﻿using System;

namespace CloudStorage.DAL.Interfaces.Models
{
    public class UserFolderModel
    {
        public Guid UserId { get; set; }
        public UserModel User { get; set; }

        public Guid FolderId { get; set; }
        public FolderModel Folder { get; set; }

        //Rights
        public bool CanAccess { get; set; }
        public bool CanChange { get; set; }
    }
}