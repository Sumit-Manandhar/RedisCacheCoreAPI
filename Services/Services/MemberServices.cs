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
        public MemberServices(Context context)
        {
            _context = context;
        }
        public List<Member> getLists()
        {
            var data = _context.DataMember.Select(a=> new Member
            {
                MemberId= a.MemberId,

                Name= a.Name,
                Address= a.Address,
                CountryID= a.CountryID,
                Phone= a.Phone,

            }).ToList();
            return data;
        }
    }
}
