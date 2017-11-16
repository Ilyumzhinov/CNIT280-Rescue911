using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    public class Provider
    {
        private string CompanyId;
        private string ProviderType;
        private string ProviderName;
        private string Address;

        public Provider(string CompanyId,string ProviderType,string ProviderName,string Address)
        {
            this.CompanyId = CompanyId;
            this.ProviderType = ProviderType;
            this.ProviderName = ProviderName;
            this.Address = Address;
        }
        public Provider() {}


        public void setCompanyId(string CompanyId) { this.CompanyId = CompanyId; }
        public void setProviderType(string ProviderType) { this.ProviderType = ProviderType; }
        public void setProviderName(string ProviderName) { this.ProviderName = ProviderName; }
        public void setAddress(string Address) { this.Address = Address; }

    }
}
