using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasatchNET;
namespace WasatchSpectrometer
{
    class DriverClass
    {
        Driver _driver=Driver.getInstance();
        public Driver DriverInstance { get { return _driver; } }
        public List<Spectrometer> spectrometers = new List<Spectrometer>();
        public Spectrometer specInstance;
        public Spectrometer SelectSpectrometer(Driver driver)
        {
            int specNum=driver.openAllSpectrometers();
            if(driver.getNumberOfSpectrometers()>0)
            {
                for (int i = 0; i < specNum; i++)
                {
                    specInstance = driver.getSpectrometer(i);
                    spectrometers.Add(specInstance);
                }
            }
            else
            {
                throw new Exception("没有发现WasatchNET.Spectrometer实例");
            }
            return specInstance;
        }
    }
}
