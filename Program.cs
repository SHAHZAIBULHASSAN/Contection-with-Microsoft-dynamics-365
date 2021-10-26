using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




using System.Net;
using System.ServiceModel.Description;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Tooling.Connector;

namespace Contection_with_Microsoft_dynamics_365
{
    class Program
    {
        static void Main(string[] args)
        {

            string authType = "OAuth";
            string userName = "shahzaib@SHAHZAIBSAFDAR1.onmicrosoft.com";
            string password = "safdar786ALI!";
            string url = "https://org666f01ac.crm.dynamics.com";
            string appId = "51f81489-12ee-4a9e-aaae-a2591f45987d";
            string reDirectURI = "app://58145B91-0C36-4500-8554-080854F2AC97";
            string loginPrompt = "Auto";
            string ConnectionString = string.Format("AuthType = {0};Username = {1};Password = {2}; Url = {3}; AppId={4}; RedirectUri={5};LoginPrompt={6}",authType,userName, password, url, appId, reDirectURI, loginPrompt);



            CrmServiceClient svc = new CrmServiceClient(ConnectionString);

            if (svc.IsReady)
            {
                Console.WriteLine("Connection Successful!...");
            }
            else
            {
                Console.WriteLine("Failed to Established Connection!!!");
            }

            #region PREVIOUS CODE

            

            //IOrganizationService _service = null;

            //try
            //{
            //    ClientCredentials clientCredentials = new ClientCredentials();
            //    clientCredentials.UserName.UserName = "shahzaib@SHAHZAIBSAFDAR1.onmicrosoft.com";
            //    clientCredentials.UserName.Password = "safdar786ALI!";

            //    // Copy and Paste Organization Service Endpoint Address URL
            //    _service = (IOrganizationService)new OrganizationServiceProxy(new Uri("https://org666f01ac.api.crm.dynamics.com/XRMServices/2011/Organization.svc"),
            //     null, clientCredentials, null);
            //    if (_service != null)
            //    {
            //        Guid userid = ((WhoAmIResponse)_service.Execute(new WhoAmIRequest())).UserId;
            //        if (userid != Guid.Empty)
            //        {
            //            Console.WriteLine("Connection Successful!...");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Failed to Established Connection!!!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception caught - " + ex.Message);
            //}
            #endregion
            Console.ReadKey();


        }
    }
}
