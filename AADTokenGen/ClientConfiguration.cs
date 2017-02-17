using System;
using System.Configuration;

namespace AADTokenGen
{
    public class ClientConfiguration
    {
        public string ODataEndpointUri { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ActiveDirectoryResource { get; set; }
        public String ActiveDirectoryTenant { get; set; }
        public String ActiveDirectoryClientAppId { get; set; }

        public ClientConfiguration()
        {
            ODataEndpointUri = ConfigurationManager.AppSettings.Get("ODataEndpointUri");

            if (string.IsNullOrEmpty(ODataEndpointUri))
                throw new ConfigurationErrorsException("ODataEndpointUri needs to be configured in config file");

            UserName = ConfigurationManager.AppSettings.Get("UserName");

            if (string.IsNullOrEmpty(UserName))
                throw new ConfigurationErrorsException("UserName needs to be configured in config file");

            Password = ConfigurationManager.AppSettings.Get("Password");

            if (string.IsNullOrEmpty(Password))
                throw new ConfigurationErrorsException("Password needs to be configured in config file");

            ActiveDirectoryResource = ConfigurationManager.AppSettings.Get("ActiveDirectoryResource");

            if (string.IsNullOrEmpty(ActiveDirectoryResource))
                throw new ConfigurationErrorsException("ActiveDirectoryResource needs to be configured in config file");

            ActiveDirectoryTenant = ConfigurationManager.AppSettings.Get("ActiveDirectoryTenant");

            if (string.IsNullOrEmpty(ActiveDirectoryTenant))
                throw new ConfigurationErrorsException("ActiveDirectoryTenant needs to be configured in config file");

            ActiveDirectoryClientAppId = ConfigurationManager.AppSettings.Get("ActiveDirectoryClientAppId");

            if (string.IsNullOrEmpty(ActiveDirectoryClientAppId))
                throw new ConfigurationErrorsException("ActiveDirectoryClientAppId needs to be configured in config file");
        }
    }
}
