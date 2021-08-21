﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL;
using ULMClubManager.DTO;
using ULMClubManager.DTO.Abstractions;
using ULMClubManager.DTO.Exceptions;

namespace ULMClubManager.BL.Services
{
    public static class UserService
    {
        public static void Login(string userName, string password)
        {
            using (DalSession dalSession = new DalSession())
            {
                int memberID = dalSession.Members.Match(userName, password);
                IMember member = null;

                try
                {
                    member = dalSession.Pilots.ReadOne(memberID);
                }
                catch (KeyNotFoundException)
                {
                    member = dalSession.Supporters.ReadOne(memberID);
                }
                finally
                {
                    if (member.Administrator)
                        State.User = member;
                    else
                        throw new LoginAdminException();
                }
            }
        }

        public static List<IMember> ReadAll()
        {
            List<IMember> members = new List<IMember>();

            using (DalSession dalSession = new DalSession())
            {
                List<Pilot> pilots = dalSession.Pilots.ReadAll();
                List<Supporter> supporters = dalSession.Supporters.ReadAll();

                members.AddRange(pilots);
                members.AddRange(supporters);
            }

            return members.OrderBy(member => member.LastName).ToList();
        }
    }
}