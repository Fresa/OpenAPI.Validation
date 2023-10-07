using Json.Schema;
using OpenAPI.Evaluation.ParameterParsers;

namespace OpenAPI.Evaluation;

internal sealed class OpenApiEvaluationOptions
{
    internal required JsonNodeBaseDocument Document { get; init; }
    internal List<IParameterValueParser> ParameterValueConverters { get; } = new();
    internal required EvaluationOptions JsonSchemaEvaluationOptions { get; init; }
}