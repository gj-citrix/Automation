using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace sc_test
{
    public class MyLogHelper
    {
        private static log4net.ILog m_logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MyLogHelper()
        { }

        public MyLogHelper(System.Reflection.MethodBase methbase)
        {
            m_logger = log4net.LogManager.GetLogger(methbase.DeclaringType);
        }

        public log4net.ILog Logger
        {
             get { return m_logger; }
        } 
    }


}
