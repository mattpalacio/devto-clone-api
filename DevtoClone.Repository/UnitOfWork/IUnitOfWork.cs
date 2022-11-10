using DevtoClone.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevtoClone.Entities.UnitOfWork
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        IPostRepository Posts { get; }
        ITagRepository Tags { get; }

        void Save();
    }
}
