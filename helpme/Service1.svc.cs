using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using helpme.ServiceReference1;

namespace helpme
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ProductDataService
    {

        public GetProductResponseMessage getProduct(GetProductRequestMessage request)
        {

            var client = new ProductDataServiceClient();

            try
            {
                // Call the generated method to invoke the service operation with the GetProductRequest.
                var response = client.getProduct(request);

                // Create a new GetProductResponseMessage and set its GetProductResponse property.
                var responseMessage = new GetProductResponseMessage(response);

                // Process and return the response message.
                return responseMessage;
            }
            finally
            {
                // Close the client when done.
                client.Close();
            }
        }

        public Task<GetProductResponseMessage> getProductAsync(GetProductRequestMessage request)
        {
            throw new NotImplementedException();
        }

        public GetProductCloseOutResponseMessage getProductCloseOut(GetProductCloseOutRequestMessage request)
        {
            throw new NotImplementedException();
        }

        public Task<GetProductCloseOutResponseMessage> getProductCloseOutAsync(GetProductCloseOutRequestMessage request)
        {
            throw new NotImplementedException();
        }

        public GetProductDateModifiedResponseMessage getProductDateModified(GetProductDateModifiedRequestMessage request)
        {
            throw new NotImplementedException();
        }

        public Task<GetProductDateModifiedResponseMessage> getProductDateModifiedAsync(GetProductDateModifiedRequestMessage request)
        {
            throw new NotImplementedException();
        }

        public GetProductSellableResponseMessage getProductSellable(GetProductSellableRequestMessage request)
        {
            throw new NotImplementedException();
        }

        public Task<GetProductSellableResponseMessage> getProductSellableAsync(GetProductSellableRequestMessage request)
        {
            throw new NotImplementedException();
        }
    }
}
