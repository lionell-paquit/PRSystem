using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PRSystemWinForm
{
    public static class ServiceClient
    {
        internal async static Task<List<ClsEnquire>> GetEnquiriesAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<ClsEnquire>>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/prsystem/GetEnquiries/"));
        }

        internal async static Task<ClsEnquire> GetEnquiryDetailsAsync(string prEnquireId)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<ClsEnquire>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/prsystem/GetEnquiryDetails?EnquireId =" + prEnquireId));
        }

        internal async static Task<List<string>> GetRegionNamesAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/prsystem/GetRegionNames/"));
        }

        internal async static Task<ClsRegion> GetRegionNamesAsync(string prRegionName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<ClsRegion>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/prsystem/GetRegion?RegionName=" + prRegionName));
            //throw new NotImplementedException();
        }

        internal async static Task<ClsRegion> GetRegionPropertyAsync(string prRegionName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<ClsRegion>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/prsystem/GetRegionProperties?RegionName=" + prRegionName));
            //throw new NotImplementedException();
        }

        internal async static Task<string> DeletePropertyAsync(ClsAllProperties prProperties)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
            ($"http://localhost:60064/api/prsystem/DeleteProperty?PropertyId={prProperties.PropertyId}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
            throw new NotImplementedException();
        }

        internal async static Task<string> InsertPropertyAsync(ClsAllProperties prProperties)
        {
            return await InsertOrUpdateAsync(prProperties, "http://localhost:60064/api/prsystem/PostProperty", "POST");
        }

        internal async static Task<string> UpdatePropertyAsync(ClsAllProperties prPoperties)
        {
            return await InsertOrUpdateAsync(prPoperties, "http://localhost:60064/api/prsystem/PutProperty", "PUT");
        }

        private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        {
            using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
            using (lcReqMessage.Content =
                new StringContent(JsonConvert.SerializeObject(prItem), Encoding.Default, "application/json"))
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }
    }
}
