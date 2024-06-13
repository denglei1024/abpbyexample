using AbpByExample.MongoDB;
using AbpByExample.Samples;
using Xunit;

namespace AbpByExample.MongoDb.Applications;

[Collection(AbpByExampleTestConsts.CollectionDefinitionName)]
public class MongoDBSampleAppServiceTests : SampleAppServiceTests<AbpByExampleMongoDbTestModule>
{

}
