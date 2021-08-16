using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.Abstractions;

namespace ULMClubManager.DAL.Repositories
{
    public class MemberRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public MemberRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Match(string userName, string password)
        {
            string sql = $"SELECT * FROM MBR WHERE MBR_USR_PSD = @USERNAME";

            var member = _unitOfWork.Connection.Query(sql, new { USERNAME = userName }).FirstOrDefault();

            string queryPWD = member.MBR_USR_PWD;

            return queryPWD == password;
        }
    }
}
