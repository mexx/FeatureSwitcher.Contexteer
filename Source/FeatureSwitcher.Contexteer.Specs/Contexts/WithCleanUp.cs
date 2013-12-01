using Contexteer;
using Contexteer.Configuration;
using FeatureSwitcher.Configuration;
using FeatureSwitcher.Contexteer.Specs.Domain;
using Machine.Specifications;

namespace FeatureSwitcher.Contexteer.Specs.Contexts
{
    public class WithCleanUp
    {
        Cleanup clean = () =>
                            {
                                Features.Are.HandledByDefault();
                                In<Default>.Contexts.FeaturesAre().HandledByDefault();
                                In<BusinessBranch>.Contexts.FeaturesAre().HandledByDefault();
                            };
    }
}