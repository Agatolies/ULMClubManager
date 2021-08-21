using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DTO.Exceptions;

namespace ULMClubManager.DAL.Repositories
{
    public class MemberRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public MemberRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int Match(string userName, string password)
        {
            string sql = $"SELECT * FROM MBR WHERE MBR_USR_PSD = @USERNAME";

            var member = _unitOfWork.Connection
                .Query(sql, new { USERNAME = userName })
                .FirstOrDefault();

            if (member != null)
            {
                int memberID = member.MBR_ID;

                bool isMatch = member.MBR_USR_PWD == password;

                if (isMatch)
                    return memberID;
                else
                    throw new LoginException();
            }
            else
            {
                throw new LoginException();
            }

        }
    }
}
