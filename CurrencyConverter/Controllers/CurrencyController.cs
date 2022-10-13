using CurrencyConverter.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CurrencyConverter.Controllers
{
    public class CurrencyController : ApiController
    {
        private readonly ICurrencyData _currencyData;
        public CurrencyController(ICurrencyData currencyData)
        {
            _currencyData = currencyData;
        }
        #region Actions   
        [Route("getCurrencyDenomination")]
        [HttpGet]
        public HttpResponseMessage GetCurrencyDenomination(decimal givenAmount, decimal price)
        {
            HttpResponseMessage httpResponseMessage;
            try
            {
                httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, _currencyData.getCurrencyDenomination(givenAmount, price));
            }
            catch (System.Exception)
            {
                throw;
            }
            return httpResponseMessage;
        }
        #endregion
    }
}
