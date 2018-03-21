using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrnoMvc1.Business.Services
{
    public interface IEmailService
    {
        void Send(string message);
    }
}
