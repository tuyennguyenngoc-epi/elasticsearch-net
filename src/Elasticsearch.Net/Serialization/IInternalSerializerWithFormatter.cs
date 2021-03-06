using Elasticsearch.Net.Utf8Json;

namespace Elasticsearch.Net
{
	internal interface IInternalSerializer
	{
		bool TryGetJsonFormatter(out IJsonFormatterResolver formatterResolver);
	}

}
