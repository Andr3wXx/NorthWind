using NortWind.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortWind.Entities.Interfaces
{
    public interface IUserActionWriter
    {
        void Write(UserAction action);
    }
}
