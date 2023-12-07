using AutoMapper;
using CenterMangement.Core.Entities;
using CenterMangement.DTO.Entities.Account;
using CenterMangement.DTO.Entities.Center;
using CenterMangement.DTO.Entities.Payment;
using CenterMangement.DTO.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Helpers.Maping
{
    public class MapingProfiles : Profile
    {
        public MapingProfiles()
        {
            CreateMap<Account, AccountG>();
            CreateMap<AccountA, Account>();
            CreateMap<AccountU, Account>();
            CreateMap<Account, AccountW>();

            CreateMap<Payment, PaymentG>();
            CreateMap<PaymentA, Payment>();
            CreateMap<PaymentU, Payment>();
            CreateMap<Payment, PaymentW>();

            CreateMap<User, UserG>();
            CreateMap<UserA, User>();
            CreateMap<UserU, User>();
            CreateMap<User, UserW>();

            CreateMap<Center, CenterG>();
            CreateMap<CenterA, Center>();
            CreateMap<CenterU, Center>();
            CreateMap<Center, CenterW>();
        }
    }
}
