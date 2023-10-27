using Project.ENTİTİES.Enums;
using System;

namespace Project.BLL.DesignPatterns.GenericRepository.BaseRep
{
    public class BaseRepository
    {
        public DataStatus Status { get; internal set; }
        public object CreatedDate { get; internal set; }
        public DateTime ModifiedDate { get; internal set; }
    }
}