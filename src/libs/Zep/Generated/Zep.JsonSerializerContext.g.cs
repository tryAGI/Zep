
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Zep.JsonConverters.ApidataRoleTypeJsonConverter),

            typeof(global::Zep.JsonConverters.ApidataRoleTypeNullableJsonConverter),

            typeof(global::Zep.JsonConverters.ModelsEntityPropertyTypeJsonConverter),

            typeof(global::Zep.JsonConverters.ModelsEntityPropertyTypeNullableJsonConverter),

            typeof(global::Zep.JsonConverters.ModelsGraphDataTypeJsonConverter),

            typeof(global::Zep.JsonConverters.ModelsGraphDataTypeNullableJsonConverter),

            typeof(global::Zep.JsonConverters.ApidataRecencyWeightJsonConverter),

            typeof(global::Zep.JsonConverters.ApidataRecencyWeightNullableJsonConverter),

            typeof(global::Zep.JsonConverters.GraphitiComparisonOperatorJsonConverter),

            typeof(global::Zep.JsonConverters.GraphitiComparisonOperatorNullableJsonConverter),

            typeof(global::Zep.JsonConverters.GraphitiMetadataFilterGroupTypeJsonConverter),

            typeof(global::Zep.JsonConverters.GraphitiMetadataFilterGroupTypeNullableJsonConverter),

            typeof(global::Zep.JsonConverters.GraphitiRerankerJsonConverter),

            typeof(global::Zep.JsonConverters.GraphitiRerankerNullableJsonConverter),

            typeof(global::Zep.JsonConverters.GraphitiGraphSearchScopeJsonConverter),

            typeof(global::Zep.JsonConverters.GraphitiGraphSearchScopeNullableJsonConverter),

            typeof(global::Zep.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataThread))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataThreadListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.ApidataThread>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataAPIError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ModelsCreateThreadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataSuccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataThreadContextResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataRoleType), TypeInfoPropertyName = "ApidataRoleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataThreadMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataThreadMessageListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.ApidataThreadMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataAddThreadMessagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.ApidataRoleType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataAddThreadMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ModelsThreadMessageUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataCreateUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataUserListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.ApidataUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataUpdateUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphitiEntityNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataUserNodeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataUserInstruction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataListUserInstructionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.ApidataUserInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataAddUserInstructionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataDeleteUserInstructionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataCreateContextTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataContextTemplateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataUpdateContextTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataListContextTemplatesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.ApidataContextTemplateResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphSetOntologyPutRequestBodyContentApplicationJsonSchemaEntities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphSetOntologyPutRequestBodyContentApplicationJsonSchemaEdges))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ModelsEntityPropertyType), TypeInfoPropertyName = "ModelsEntityPropertyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataEntityProperty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataEntityEdgeSourceTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataEdgeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.ApidataEntityProperty>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.ApidataEntityEdgeSourceTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataEntityType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataEntityTypeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.ApidataEdgeType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.ApidataEntityType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ModelsGraphDataType), TypeInfoPropertyName = "ModelsGraphDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataAddDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataGraphEpisode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataEpisodeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataAddDataBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.ApidataEpisodeData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphitiAddTripleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphitiEntityEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphitiAddTripleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataCloneGraphRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataCloneGraphResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataCreateGraphRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataGraph))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataGraphListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.ApidataGraph>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataClusterDetectConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataCoOccurrenceDetectConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataHubDetectConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataPathDetectConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataRelationshipDetectConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataDetectConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataRecencyWeight), TypeInfoPropertyName = "ApidataRecencyWeight2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphitiComparisonOperator), TypeInfoPropertyName = "GraphitiComparisonOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphitiDateFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphitiPropertyFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphitiEpisodeMetadataFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphitiMetadataFilterGroupType), TypeInfoPropertyName = "GraphitiMetadataFilterGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphitiMetadataFilterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.GraphitiEpisodeMetadataFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.GraphitiMetadataFilterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphitiSearchFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Zep.GraphitiDateFilter>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.GraphitiDateFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.GraphitiPropertyFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataPatternSeeds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataDetectPatternsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataPatternMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataPatternResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.GraphitiEntityEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataDetectPatternsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.GraphitiEntityNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.ApidataPatternResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphitiReranker), TypeInfoPropertyName = "GraphitiReranker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphitiGraphSearchScope), TypeInfoPropertyName = "GraphitiGraphSearchScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphitiGraphSearchQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.GraphitiCommunityNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataGraphSearchResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.GraphitiCommunityNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.ApidataGraphEpisode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataUpdateGraphRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataGraphEdgesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataUpdateEdgeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataGraphEpisodeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataUpdateEpisodeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataEpisodeMentions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataGraphNodesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataUpdateNodeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataCustomInstruction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataListCustomInstructionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zep.ApidataCustomInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataAddCustomInstructionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataDeleteCustomInstructionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataProjectInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataProjectInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataTaskErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataTaskProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.ApidataGetTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zep.SetOntologyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.ApidataThread>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.ApidataThreadMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.ApidataRoleType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.ApidataUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.ApidataUserInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.ApidataContextTemplateResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.ApidataEntityProperty>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.ApidataEntityEdgeSourceTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.ApidataEdgeType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.ApidataEntityType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.ApidataEpisodeData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.ApidataGraph>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.GraphitiEpisodeMetadataFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.GraphitiMetadataFilterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Zep.GraphitiDateFilter>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.GraphitiDateFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.GraphitiPropertyFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.GraphitiEntityEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.GraphitiEntityNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.ApidataPatternResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.GraphitiCommunityNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.ApidataGraphEpisode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zep.ApidataCustomInstruction>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}