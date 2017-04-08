using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using BindableResourceManager.Properties;

namespace BindableResourceManager.Support
{
    class ResourceService : ResourceServiceBase
    {
        public ResourceService(ResourceManager resourceManager) : base(resourceManager) { }

        public static ResourceService Instance { get; } = new ResourceService(Resources.ResourceManager);

        public void ChangeCulture(string name)
        {
            Resources.Culture = new CultureInfo(name);

            base.ChangeCulture(Resources.Culture);
        }
    }
}
