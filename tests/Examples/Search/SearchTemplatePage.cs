using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Search
{
	public class SearchTemplatePage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line7()
		{
			// tag::e068d93555351b9afbdb9dd2aff6368d[]
			var response0 = new SearchResponse<object>();
			// end::e068d93555351b9afbdb9dd2aff6368d[]

			response0.MatchesExample(@"GET _search/template
			{
			    ""source"" : {
			      ""query"": { ""match"" : { ""{{my_field}}"" : ""{{my_value}}"" } },
			      ""size"" : ""{{my_size}}""
			    },
			    ""params"" : {
			        ""my_field"" : ""message"",
			        ""my_value"" : ""some message"",
			        ""my_size"" : 5
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line110()
		{
			// tag::b19dc078255bfa1237206913ae94012f[]
			var response0 = new SearchResponse<object>();
			// end::b19dc078255bfa1237206913ae94012f[]

			response0.MatchesExample(@"POST _scripts/<templateid>
			{
			    ""script"": {
			        ""lang"": ""mustache"",
			        ""source"": {
			            ""query"": {
			                ""match"": {
			                    ""title"": ""{{query_string}}""
			                }
			            }
			        }
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line145()
		{
			// tag::e51c88800679913981757542bc639816[]
			var response0 = new SearchResponse<object>();
			// end::e51c88800679913981757542bc639816[]

			response0.MatchesExample(@"GET _scripts/<templateid>");
		}

		[U(Skip = "Example not implemented")]
		public void Line171()
		{
			// tag::ed639528456671b302ecc887f5a60987[]
			var response0 = new SearchResponse<object>();
			// end::ed639528456671b302ecc887f5a60987[]

			response0.MatchesExample(@"DELETE _scripts/<templateid>");
		}

		[U(Skip = "Example not implemented")]
		public void Line183()
		{
			// tag::de5b9f1211876f6ba7a4c93e87c27d3a[]
			var response0 = new SearchResponse<object>();
			// end::de5b9f1211876f6ba7a4c93e87c27d3a[]

			response0.MatchesExample(@"GET _search/template
			{
			    ""id"": ""<templateid>"", <1>
			    ""params"": {
			        ""query_string"": ""search for these words""
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line203()
		{
			// tag::4b13f649aa2eca6f7ee4221f708430c1[]
			var response0 = new SearchResponse<object>();
			// end::4b13f649aa2eca6f7ee4221f708430c1[]

			response0.MatchesExample(@"GET _render/template
			{
			  ""source"": ""{ \""query\"": { \""terms\"": {{#toJson}}statuses{{/toJson}} }}"",
			  ""params"": {
			    ""statuses"" : {
			        ""status"": [ ""pending"", ""published"" ]
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line256()
		{
			// tag::99e29a569f37ea83b02687e6e2793529[]
			var response0 = new SearchResponse<object>();
			// end::99e29a569f37ea83b02687e6e2793529[]

			response0.MatchesExample(@"GET _search/template
			{
			  ""id"": ""my_template"",
			  ""params"": {
			    ""status"": [ ""pending"", ""published"" ]
			  },
			  ""explain"": true
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line275()
		{
			// tag::3462452c6fdba8dc1efe2cca101246e8[]
			var response0 = new SearchResponse<object>();
			// end::3462452c6fdba8dc1efe2cca101246e8[]

			response0.MatchesExample(@"GET _search/template
			{
			  ""id"": ""my_template"",
			  ""params"": {
			    ""status"": [ ""pending"", ""published"" ]
			  },
			  ""profile"": true
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line292()
		{
			// tag::4697b9aa952ac1613ee1a6ec7b3223c1[]
			var response0 = new SearchResponse<object>();
			// end::4697b9aa952ac1613ee1a6ec7b3223c1[]

			response0.MatchesExample(@"GET _search/template
			{
			    ""source"": {
			        ""query"": {
			            ""term"": {
			                ""message"": ""{{query_string}}""
			            }
			        }
			    },
			    ""params"": {
			        ""query_string"": ""search for these words""
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line316()
		{
			// tag::eb1f3134f28a9ba8406b0f10199cf5be[]
			var response0 = new SearchResponse<object>();
			// end::eb1f3134f28a9ba8406b0f10199cf5be[]

			response0.MatchesExample(@"GET _search/template
			{
			  ""source"": ""{ \""query\"": { \""terms\"": {{#toJson}}statuses{{/toJson}} }}"",
			  ""params"": {
			    ""statuses"" : {
			        ""status"": [ ""pending"", ""published"" ]
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line348()
		{
			// tag::6be45fa02e779a727ddf48f871610aa8[]
			var response0 = new SearchResponse<object>();
			// end::6be45fa02e779a727ddf48f871610aa8[]

			response0.MatchesExample(@"GET _search/template
			{
			    ""source"": ""{\""query\"":{\""bool\"":{\""must\"": {{#toJson}}clauses{{/toJson}} }}}"",
			    ""params"": {
			        ""clauses"": [
			            { ""term"": { ""user"" : ""foo"" } },
			            { ""term"": { ""user"" : ""bar"" } }
			        ]
			   }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line393()
		{
			// tag::33bb4a6ec63a709a14dfa15a5e2cca88[]
			var response0 = new SearchResponse<object>();
			// end::33bb4a6ec63a709a14dfa15a5e2cca88[]

			response0.MatchesExample(@"GET _search/template
			{
			  ""source"": {
			    ""query"": {
			      ""match"": {
			        ""emails"": ""{{#join}}emails{{/join}}""
			      }
			    }
			  },
			  ""params"": {
			    ""emails"": [ ""username@email.com"", ""lastname@email.com"" ]
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line426()
		{
			// tag::02f0012ca77fdc409592e524e5647fb8[]
			var response0 = new SearchResponse<object>();
			// end::02f0012ca77fdc409592e524e5647fb8[]

			response0.MatchesExample(@"GET _search/template
			{
			  ""source"": {
			    ""query"": {
			      ""range"": {
			        ""born"": {
			            ""gte""   : ""{{date.min}}"",
			            ""lte""   : ""{{date.max}}"",
			            ""format"": ""{{#join delimiter='||'}}date.formats{{/join delimiter='||'}}""
				    }
			      }
			    }
			  },
			  ""params"": {
			    ""date"": {
			        ""min"": ""2016"",
			        ""max"": ""31/12/2017"",
			        ""formats"": [""dd/MM/yyyy"", ""yyyy""]
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line615()
		{
			// tag::a5cc9a86f0f9525cd86564421c721d2f[]
			var response0 = new SearchResponse<object>();
			// end::a5cc9a86f0f9525cd86564421c721d2f[]

			response0.MatchesExample(@"GET _render/template
			{
			    ""source"" : {
			        ""query"" : {
			            ""term"": {
			                ""http_access_log"": ""{{#url}}{{host}}/{{page}}{{/url}}""
			            }
			        }
			    },
			    ""params"": {
			        ""host"": ""https://www.elastic.co/"",
			        ""page"": ""learn""
			    }
			}");
		}
	}
}