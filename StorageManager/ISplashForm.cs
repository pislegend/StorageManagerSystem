using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager
{
    public interface ISplashForm
    {
        /// <summary>
        /// interface for Splash Screen
        /// </summary>  
        void SetStatusInfo(string NewStatusInfo);
    }
}
