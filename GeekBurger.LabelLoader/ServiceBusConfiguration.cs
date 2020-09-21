using System;
using System.Collections.Generic;
using System.Text;

namespace GeekBurger.LabelLoader
{
    public class ServiceBusConfiguration
    {
        public ServiceBusConfiguration()
        {
            ResourceGroup = "FIAP-16NET";
            NamespaceName = "geekburger16NET";
            ConnectionString = "Endpoint=sb://geekburger16net.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=hWUhqKVScU2nzRMe3qcs+wJSewH37tCoFIBwqH/xA1U=";
            ClientId = "46dbd19e-9f4e-4eeb-af56-de8dc11b9d48";
            ClientSecret = "4o-_S6Mk96nvAs3SE.RuH0B4pyGqf1.4IT";
            SubscriptionId = "505af470-d6ac-4547-9743-3a97059e8e1d";
            TenantId = "0ddea7e6-2201-4f52-8353-a58bf25762ab";
        }

        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string TenantId { get; set; }
        public string SubscriptionId { get; set; }
        public string ResourceGroup { get; set; }
        public string NamespaceName { get; set; }
        public string ConnectionString { get; set; }
    }
}
