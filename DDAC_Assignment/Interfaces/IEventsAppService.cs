using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using DDAC_Assignment.Models;

namespace DDAC_Assignment.Interfaces
{
    public interface IEventsAppService
    {
        Task<IEnumerable<ActiveDirectoryUser>> ActiveDirectoryUsersAsync();
    }
}