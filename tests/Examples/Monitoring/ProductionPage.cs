using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Monitoring
{
	public class ProductionPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line38()
		{
			// tag::a941fd568f2e20e13df909ab24506073[]
			var response0 = new SearchResponse<object>();

			var response1 = new SearchResponse<object>();
			// end::a941fd568f2e20e13df909ab24506073[]

			response0.MatchesExample(@"GET _cluster/settings");

			response1.MatchesExample(@"PUT _cluster/settings
			{
			  ""persistent"": {
			    ""xpack.monitoring.collection.enabled"": false
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line76()
		{
			// tag::0b47b0bef81b9b5eecfb3775695bd6ad[]
			var response0 = new SearchResponse<object>();
			// end::0b47b0bef81b9b5eecfb3775695bd6ad[]

			response0.MatchesExample(@"POST /_security/user/remote_monitor
			{
			  ""password"" : ""changeme"",
			  ""roles"" : [ ""remote_monitoring_agent""],
			  ""full_name"" : ""Internal Agent For Remote Monitoring""
			}");
		}
	}
}