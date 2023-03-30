using DataAccess.Context;
using RedisCacheCoreAPI.Models;
using Services.Iservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class MemberServices : IMemberService
    {
        private readonly Context _context;
        private readonly ICacheService _cacheServices;
        private readonly string cachekey = "membercache";
        public MemberServices(Context context, ICacheService cacheServices)
        {
            _context = context;
            _cacheServices = cacheServices;
        }
        public List<Member> getLists()
        {
            var cacheMember = _cacheServices.GetData<IEnumerable<Member>>(cachekey);
            if (cacheMember == null )
            {
                var data = _context.DataMember.Select(a => new Member
                {
                    MemberId = a.MemberId,

                    Name = a.Name,
                    Address = a.Address,
                    CountryID = a.CountryID,
                    Phone = a.Phone,

                }).ToList();
                _cacheServices.SetData<IEnumerable<Member>>(cachekey, data, DateTimeOffset.Now.AddMinutes(20));
                return data;
            }

            
            return cacheMember.Select(a => new Member
            {
                MemberId = a.MemberId,

                Name = a.Name,
                Address = a.Address,
                CountryID = a.CountryID,
                Phone = a.Phone,

            }).ToList();
        }
    }
}
