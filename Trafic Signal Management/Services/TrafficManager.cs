using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trafic_Signal_Management.Models;

namespace Trafic_Signal_Management.Services
{
    public class TrafficManager
    {
        Dictionary<string, GlobalConfig> _Configs =
        new Dictionary<string, GlobalConfig>();
        
        public void SaveConfig(string username ,GlobalConfig config)
        {
            _Configs.Add(username, config);
            // save to db
        }
    }
}
