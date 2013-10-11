using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;

namespace miataruclientcsharp
{
	public class miataruclient
	{
		public miataruclient ()
		{
		}

		#region GetLocation
		public List<MiataruLocation> GetLastLocationForDevice(String DeviceID, String ServerURL)
		{
			// run the request
			GetLocationRequest Request = new GetLocationRequest (DeviceID);

			// get the JSON representation
			string json = JsonConvert.SerializeObject(Request);

			// run a request and get the response...
			WebClient client = new WebClient ();

			client.Headers["Content-Type"] = "application/json";

			string ReturnJSONValue = client.UploadString (ServerURL + "/GetLocation", json);

			GetLocationResponse Response = JsonConvert.DeserializeObject<GetLocationResponse>(ReturnJSONValue);

			Console.WriteLine (ReturnJSONValue);
			return null;

		}
		#endregion
	}
}