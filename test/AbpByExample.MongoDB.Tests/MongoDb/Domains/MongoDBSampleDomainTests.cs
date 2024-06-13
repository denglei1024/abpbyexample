using AbpByExample.Samples;
using Xunit;

namespace AbpByExample.MongoDB.Domains;

[Collection(AbpByExampleTestConsts.CollectionDefinitionName)]
public class MongoDBSampleDomainTests : SampleDomainTests<AbpByExampleMongoDbTestModule>
{

}
