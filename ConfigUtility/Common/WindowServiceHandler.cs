using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceProcess;

namespace Elegant.Ui.Samples.ControlsSample.Common
{
    class WindowServiceHandler
    {
        public bool ServiceExists(string serviceName)
        {
            bool result = false;

            ServiceController[] controllers = ServiceController.GetServices();

            foreach (ServiceController ctrl in controllers)
            {
                if (ctrl.ServiceName.Equals(serviceName)) {
                   result = true;
                    break;
                }
            }
            return result;
        }

        public bool IsServiceRunning(string serviceName)
        {
            bool result = false;

            ServiceController[] controllers = ServiceController.GetServices();

            foreach (ServiceController ctrl in controllers)
            {
                if (ctrl.ServiceName.Equals(serviceName))
                {
                    result = (ctrl.Status.Equals(ServiceControllerStatus.Running));
                    break;
                }
            }
            return result;
        }

        //Gets the currently selected service
        private ServiceController GetService(string serviceName)
        {
            if (serviceName.Trim() != string.Empty)
                return new ServiceController(serviceName);
            else
                return null;
        }

        public bool StopService(string serviceName)
        {
            bool result = false;
            try
            {
                System.ServiceProcess.ServiceController controller = GetService(serviceName);
                controller.Stop();
                controller.WaitForStatus(ServiceControllerStatus.Stopped,
                                    new TimeSpan(0, 1, 0));
                result = true;
            }
            catch (Exception ex)
            {
                MsgrLogger.WriteLog(ex.ToString());
            }

            return result;
        }
 
        public bool StartService(string serviceName)
        {
            bool result = false;

            try
            {
                System.ServiceProcess.ServiceController controller = GetService(serviceName);
                controller.Start();
                controller.WaitForStatus(ServiceControllerStatus.Running,
                                    new TimeSpan(0, 1, 0));
                result = true;
            }
            catch (Exception ex)
            {
                MsgrLogger.WriteLog(ex.ToString());
            }
            
            return result;
        }

    }
}
