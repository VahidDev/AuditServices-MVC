using AuditServices.Models.Entities;
using AuditServices.Models.Pages;
using AuditServices.ViewModels;
using AuditServices.ViewModels.AdminVMs.PageVMs.FooterVMs;
using AuditServices.ViewModels.AdminVMs.PageVMs.HomePageVMs;
using AuditServices.ViewModels.AdminVMs.UserVMs;
using AutoMapper;

namespace AuditServices.Mapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Footer, FooterVM>().ReverseMap();
            CreateMap<Footer, FooterUpdateVM>().ReverseMap();
            CreateMap<FooterPart, FooterPartVM>().ReverseMap();
            CreateMap<FooterPart, FooterPartUpdateVM>().ReverseMap();
            CreateMap<FooterPartLink, FooterPartLinkUpdateVM>().ReverseMap();
            CreateMap<UserUpdateVM, User>().ReverseMap();
            CreateMap<HomePageCard, HomePageCardVM>().ReverseMap();
            CreateMap<FooterPartLink, FooterPartLinkVM>().ReverseMap();
            CreateMap<HomePageTrendingSection, HomePageTrendingSectionVM>().ReverseMap();
            CreateMap<HomePageTrendingSectionUpdateVM, HomePageTrendingSection>().ReverseMap();
            CreateMap<HomePageTrendingSectionPart, HomePageTrendingSectionPartVM>().ReverseMap();
            CreateMap<HomePageTrendingSectionPartUpdateVM, HomePageTrendingSectionPart>().ReverseMap();
        }
    }
}
