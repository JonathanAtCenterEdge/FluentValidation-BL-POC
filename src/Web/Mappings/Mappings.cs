using AutoMapper;
using Shared.Models;
using Web.Models;

namespace Web.Mappings;

public class Mappings : Profile
{
    public Mappings()
    {
        CreateMap<Membership, MembershipDto>()
            .ReverseMap();

        CreateMap<BillingTerms, BillingTermsDto>()
            .ReverseMap();

        CreateMap<InstallmentPlan, InstallmentPlanDto>()
            .ReverseMap();

        CreateMap<Duration, DurationDto>()
            .ReverseMap();
    }
}
